using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Yixing.util
{
    class InpFactory
    {
        //处理inp文件，转换问VM文档
        public static String convertInp(String filePath)
        {
            //用于记录Ngrid下面那个数的值
            int grid = 0;
            StreamReader objReader = new StreamReader(filePath);
            String newPath = filePath.Substring(0, filePath.IndexOf(".")) + ".vm";
            FileStream fs = new FileStream(newPath, FileMode.Create);
            
            StreamWriter sw = new StreamWriter(fs);

            string sLine = objReader.ReadLine();
            while (sLine != null)
            {
                if (sLine != null && !sLine.Equals(""))
                {
                    #region 处理开始的<>之间的部分
                    if (sLine.ToLower().Equals("restart.bin"))
                    {
                        //开始写入
                        sw.WriteLine(sLine);
                        sw.WriteLine("#if($flag)");
                        sw.WriteLine(">");
                        sw.WriteLine("#if($zn)");
                        sw.WriteLine("pke_tu $!{zn.fddls}");
                        sw.WriteLine("tke0 $!{tke0}");
                        sw.WriteLine("tke1 $!{tke1}");
                        sw.WriteLine("#end");
                        sw.WriteLine("#if($gj)");
                        sw.WriteLine("#if($!{gj.xzs} && $!{gj.xzs}>0)");
                        sw.WriteLine("epsa_r $!{gj.xzs}");
                        sw.WriteLine("#end#end");
                        sw.WriteLine("#if($!{s.dslxs}>0)");
                        sw.WriteLine("cltarg $!{s.dslxs}");
                        sw.WriteLine("dalim 0.2#end");
                        sw.WriteLine("< #end");
                        sw.WriteLine("");
                    }
                    #endregion

                    #region 处理剩余文本
                    else
                    {
                        char[] separator = { ' ' };
                        String[] lineArr = sLine.Split(separator);
                        if (lineArr != null)
                        {
                            int count = 0;
                            #region 循环匹配，判断是否为mach 那一行
                            foreach (String str in lineArr)
                            {
                                if (!str.Equals(""))
                                {
                                    if (str.ToUpper().Trim().Equals("ALPHA"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("BETA"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("REUE,MIL"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("TINF,DR"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("IALPH"))
                                    {
                                        count++;
                                    }
                                }
                            }
                            #endregion

                            #region 为mach 那一行,然后后续处理
                            if (count > 3)
                            {
                                sw.WriteLine("#set($reue=$!{s.mahe}*$!{mhln}) ");
                                sw.WriteLine("     XMACH     ALPHA      BETA  REUE,MIL   TINF,DR     IALPH     IHIST");
                                sLine = objReader.ReadLine();
                                String[] mlineArr = sLine.Split(separator);
                                if (mlineArr != null)
                                {
                                    //用于记录当前输出到第几个数
                                    int datacount = 1;
                                    StringBuilder line = new StringBuilder();
                                    foreach (String str in mlineArr)
                                    {
                                        if (!str.Equals(""))
                                        {
                                            if (datacount == 1)
                                            {
                                                line.Append("$s.mahe.ToString(\"0.00000\")");
                                            }
                                            else if (datacount == 2)
                                            {
                                                line.Append("$s.dyj.ToString(\"0.00000\")");
                                            }
                                            else if (datacount == 4)
                                            {
                                                line.Append("$reue.ToString(\"0.00000\")");
                                            }
                                            else { line.Append(str); }
                                            datacount++;
                                        }
                                        else { line.Append(" "); }
                                    }
                                    sw.WriteLine(line.ToString());
                                    sLine = objReader.ReadLine();
                                    continue;
                                }
                            }
                            #endregion

                            #region 判断是否为DT那一行，如果是处理
                            count = 0;
                            foreach (String str in lineArr)
                            {
                                if (!str.Equals(""))
                                {
                                    if (str.ToUpper().Trim().Equals("DT"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("IREST"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("IFLAGTS"))
                                    {
                                        count++;
                                    }
                                    if (str.ToUpper().Trim().Equals("FMAX"))
                                    {
                                        count++;
                                    }
                                }
                            }

                            if (count > 3)
                            {
                                #region 处理DT行的东西
                                sw.WriteLine("        DT     IREST   IFLAGTS      FMAX     IUNST    CFLTAU");
                                sLine = objReader.ReadLine();
                                String[] mlineArr = sLine.Split(separator);
                                if (mlineArr != null)
                                {
                                    //用于记录当前输出到第几个数
                                    int datacount = 1;
                                    StringBuilder line = new StringBuilder();
                                    foreach (String str in mlineArr)
                                    {
                                        if (!str.Equals(""))
                                        {
                                            if (datacount == 1)
                                            {
                                                line.Append("-$gj.cfl.ToString(\"0.00000\")");
                                            }
                                            else { line.Append(str); }
                                            datacount++;
                                        }
                                        else { line.Append(" "); }
                                    }
                                    sw.WriteLine(line.ToString());
                                }
                                #endregion

                                #region 处理DT行接着的NGRID行,获取ngrid 下面的那个数据
                                sLine = objReader.ReadLine();
                                sw.WriteLine(sLine);
                                sLine = objReader.ReadLine();
                                sw.WriteLine(sLine);
                                String[] gridlineArr = sLine.Split(separator);
                                foreach (String str in gridlineArr)
                                {
                                    if (!str.Equals(""))
                                    {
                                        if (int.TryParse(str, out grid))
                                            break;
                                    }
                                }
                                #endregion

                                #region 处理NGRID行接着的NGC行
                                sLine = objReader.ReadLine();
                                sw.WriteLine(sLine);
                                sLine = objReader.ReadLine();
                                grid = Math.Abs(grid);
                                sw.WriteLine("#foreach($i in [1.." + grid + "])");
                                String[] ncglineArr = sLine.Split(separator);
                                int ncgcount = 1;
                                StringBuilder ncgline = new StringBuilder();
                                foreach (String str in ncglineArr)
                                {
                                    if (!str.Equals(""))
                                    {
                                        if (ncgcount == 5 || ncgcount == 6 || ncgcount == 7)
                                        {
                                            ncgline.Append("#if($zn)19#else$!{s.dlmx}#end");
                                        }
                                        else { ncgline.Append(str); }
                                        ncgcount++;
                                    }
                                    else { ncgline.Append(" "); }
                                }
                                sw.WriteLine(ncgline + "\n");
                                sw.WriteLine("#end");
                                #endregion
                                for (int i = 0; i < grid; i++)
                                {
                                    sLine = objReader.ReadLine();
                                }
                                continue;
                            }
                            #endregion

                            #region 处理NCYC的部分，即处理高级的迭代部分
                            Boolean isncyc = false;
                            foreach (String str in lineArr)
                            {
                                if (!str.Equals(""))
                                {
                                    if (str.ToUpper().Trim().Equals("NCYC"))
                                    {
                                        isncyc = true;
                                        break;
                                    }
                                }
                            }
                            if (isncyc)
                            {
                                sw.WriteLine(sLine);
                                for (int i = 1; i < 4; i++)
                                {
                                    sLine = objReader.ReadLine();
                                    String[] ncyclineArr = sLine.Split(separator);
                                    if (ncyclineArr != null)
                                    {
                                        int datacount = 1;
                                        StringBuilder line = new StringBuilder();
                                        foreach (String str in ncyclineArr)
                                        {
                                            if (!str.Equals(""))
                                            {
                                                if (datacount == 1)
                                                {
                                                    if (i == 1) { line.Append("$!{gj.onedd}"); }
                                                    if (i == 2) { line.Append("$!{gj.secdd}"); }
                                                    if (i == 3) { line.Append("$!{gj.thirdd}"); }
                                                }
                                                else { line.Append(str); }
                                                datacount++;
                                            }
                                            else { line.Append(" "); }
                                        }
                                        sw.WriteLine(line.ToString());
                                    }
                                }
                                sLine = objReader.ReadLine();
                                continue;
                            }
                            #endregion
                        }
                        //如果在else中，且没有在前面continue掉，那么此处必定需要写一行
                        sw.WriteLine(sLine);
                    }
                    #endregion
                }
                sLine = objReader.ReadLine();
            }
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
            objReader.Close();
            return newPath;
        }

        //移动文件
        public static void MoveFileTo(string from, string to)
        {
            //检查是否存在目的目录
            if (!Directory.Exists(to))
                Directory.CreateDirectory(to);
            File.Copy(from, Path.Combine(to, Path.GetFileName(from)), true); //复制文件

        }

        //将文件读取到List中
        public static List<String> readFile(String filePath)
        {
            List<String> result = new List<String>();
            StreamReader objReader = new StreamReader(filePath);
            string sLine = objReader.ReadLine();
            while (sLine != null)
            {
                result.Add(sLine);
                sLine = objReader.ReadLine();
            }
            return result;
        }

        public static void processCommand(String command,String path)
        {
            Process cmd = new Process();
            //没有这个命令。暂时改为cd吧。
            cmd.StartInfo.FileName = command;
            //cmd.StartInfo.FileName = @"java";
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.CreateNoWindow = true ;
            cmd.StartInfo.WorkingDirectory = path;
            cmd.Start();
            //string info = cmd.StandardOutput.ReadToEnd();
            //cmd.WaitForExit();
            cmd.Close();
        }
    }
}