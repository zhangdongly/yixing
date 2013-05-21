using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.constant;
using Yixing.model;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.Dialog
{
    public partial class Texingpingu : Form
    {
        private Dictionary<int, Status> ztDic;

        private DCGaoji gj;

        private bool isgjOpened = false;

        private int znCl = 1;
        //用于判定进程是否结束
        bool isExist = false;
        //计算时的等待次数，每次等待为3秒种
        int waitcount = 10;
        //计算时的等待时间,这个是毫秒级别
        int waittime = 3000;
        ThreadStart ts;
        Thread t;

        DCYixing yx ;

        List<CalcModel> cmList = new List<CalcModel>();

        public Texingpingu()
        {
            InitializeComponent();
        }

        public Texingpingu(Dictionary<int, Status> _ztDic)
        {
            InitializeComponent();
            ztDic = _ztDic;
            int i = 1;
            foreach (int key in ztDic.Keys)
            {
                EXListViewItem item = new EXListViewItem("状态" +i);
                Status s = ztDic[key];
                item.SubItems.Add(s.mahe + "");
                item.SubItems.Add(s.dslxs + "");
                this.exListView1.Items.Add(item);
                i++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Texingpingu_Load(object sender, EventArgs e)
        {
            //this.checkBox1.Checked = true;
            this.radioButton3.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                zhuannie z = new zhuannie();
                z.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DingChangGaoji dcgj;
            if (isgjOpened)
            {
                dcgj = new DingChangGaoji(gj, new StatusEditAble());
            }
            else
            {
                gj = new DCGaoji();
                gj.cfl = 2;
                gj.onedd = 1000;
                gj.secdd = 1000;
                gj.thirdd = 600;
                if (this.checkBox1.Checked)
                    gj.thirdd = 2500;
                gj.xzs = 0;
                dcgj = new DingChangGaoji(gj, new StatusEditAble());
            }
            if (dcgj.ShowDialog() == DialogResult.OK)
            {
                isgjOpened = true;
                gj = new DCGaoji();
                gj.cfl = dcgj.cfl;
                gj.onedd = dcgj.onedd;
                gj.secdd = dcgj.secdd;
                gj.thirdd = dcgj.thirdd;
                gj.xzs = dcgj.xzs;
            }
        }

        private void exListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //更改颜色。
            foreach (EXListViewItem i in this.exListView1.Items)
            {
                i.BackColor = Color.White;
            }
            this.exListView1.SelectedItems[0].BackColor = Color.DodgerBlue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yx = new DCYixing();
            float fddls;
            float wnxb;

            //风洞湍流度处理
            #region
            if (!float.TryParse(this.textBox1.Text, out fddls))
            {
                MessageBox.Show("风洞湍流度必须为数字");
                return;
            }
            if (!float.TryParse(this.textBox2.Text, out wnxb))
            {
                MessageBox.Show("涡粘性比必须为数字");
                return;
            }
            if (fddls <= 0 || fddls >= 0.05)
            {
                MessageBox.Show("风洞湍流度范围在0—0.05之间，请修改！");
                return;
            }
            if (wnxb <= 0 || wnxb >= 100)
            {
                MessageBox.Show("风洞湍流度范围在0—100之间，请修改！");
                return;
            }
            DCZhuannie zn = new DCZhuannie();
            zn.fddls = fddls;
            zn.wnxb = wnxb;
            #endregion

            #region 选择输出路径
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            String lastFileFolder = Properties.Settings.Default.defaultFileFolder;
            if (!String.IsNullOrWhiteSpace(lastFileFolder))
            {
                folderDlg.SelectedPath = lastFileFolder;
            }
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.defaultFileFolder = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("你必须选中一个输出路径,否则不进行计算");
                return;
            }
            #endregion

            #region 处理翼型，此处翼型本该由上层传递下来，但是暂时虚拟一个
            yx.type = 1;
            yx.name="cfl3d.inp";
            
            //临时的。如果type为1,则是默认生成，否则不是
            if (yx.type == 1)
            {
                yx.inpPath = @"./template/cfl3d.inp";
                yx.xyzPath = @"./template/CFD.xyz";
            }

            //构建模版文件
            String vmpath = InpFactory.convertInp(yx.inpPath);
            String vmDirpath = Path.GetDirectoryName(vmpath);
            //根据模版文件生成，对应的inp文件
            TemplateHelper tp = new TemplateHelper(vmDirpath);
            String vmname = Path.GetFileName(vmpath);
            String yxname = yx.name.Substring(0, yx.name.IndexOf("."));
            string outpath = Yixing.Properties.Settings.Default.defaultFileFolder + "/" + yxname;
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            else
            {
                try
                {
                    System.IO.Directory.Delete(outpath, true);
                }
                catch (System.IO.IOException exce)
                {
                    Console.WriteLine(exce.Message);
                }
            }
            #endregion

            #region 初始化计算对象
            //测试代码，VM文件都放置于@"..//..//template"
            foreach (int key in ztDic.Keys)
            {
                Status s = ztDic[key];
                CalcModel cm = new CalcModel();
                cm.mahe = s.mahe;
                cm.isZn = false;
                cm.isyj = s.isyj;
                cm.yj = s.dslxs;
                cm.xc = 5;

                if (this.checkBox1.Checked)
                {
                    cm.isZn = true;
                    float tke0 = s.mahe * s.mahe * zn.fddls * zn.fddls * 1.5f * 1000000;
                    float tke1 = tke0 / zn.wnxb;
                    tp.Put("tke0", tke0);
                    tp.Put("tke1", tke1);
                }
                #region 处理状态对象
                DCStatus dcs = new DCStatus();
                dcs.mahe = s.mahe;
                dcs.isyj = s.isyj;
                if (s.isyj)
                {
                    dcs.dyj = s.dslxs;
                }
                else
                {
                    dcs.dslxs = s.dslxs;
                }
                if (this.radioButton1.Checked)
                {
                    dcs.lsgs = Constant.LSGS_ROE;
                }
                else
                {
                    dcs.lsgs = Constant.LSGS_LEER;
                }
                if (this.checkBox1.Checked)
                {
                    //如果选择了转涅，这个断流模型只能选择sst 所以值为7
                    dcs.dlmx = 7;
                }
                else
                {
                    if (this.radioButton3.Checked)
                    {
                        dcs.dlmx = Constant.DLMX_SA;
                    }
                    else
                    {
                        dcs.dlmx = Constant.DLMX_SST;
                    }
                }
                #endregion 

                if (gj == null)
                {
                    gj = new DCGaoji();
                    gj.cfl = 2;
                    gj.onedd = 1000;
                    gj.secdd = 1000;
                    gj.thirdd = 600;
                }
                tp.Put("gj", gj);
                tp.Put("zn", zn);
                tp.Put("s", dcs);
                tp.Put("mhln", 100);
                tp.Put("flag", true);
                if (zn == null && gj.xzs == 0 && s.isyj)
                {
                    tp.Put("flag", false);
                }

                String mahe = string.Format("{0:0.000}", s.mahe);
                mahe = mahe.Replace(".", "");
                String zt;
                if (s.isyj)
                {
                    //迎角应该是x100
                    zt = string.Format("{0:00.00}", s.dslxs);
                    zt = "a" + zt.Replace(".", "");
                }
                else
                {
                    zt = string.Format("{0:0.000}", s.dslxs);
                    zt = "cl" + zt.Replace(".", "");
                }
                String a = tp.BuildString(vmname, yxname, mahe, zt);
                cm.inpPath = a;
                cmList.Add(cm);
            }
            ts = new ThreadStart(this.startCalc);
            t = new Thread(ts);
            // 启动.
            t.Start();
            #endregion
        }


        private void startCalc()
        {
            List<CalcResult> resultList = new List<CalcResult>();
            for (int i = 0; i < cmList.Count(); i++)
            {
                CalcResult re = new CalcResult();
                CalcModel cm = cmList[i];
                String inpPath = cm.inpPath;
                Boolean iszn = cm.isZn;
                String path = Path.GetDirectoryName(inpPath);
                re.inpPath = path;
                String inpName = Path.GetFileName(inpPath);
                String inpNameWithout = inpName.Substring(0, inpName.IndexOf("."));
                //移动xyz文件到，inp所在的文件夹
                InpFactory.MoveFileTo(yx.xyzPath, path);
                //移动alpha文件到，inp所在的文件夹
                //InpFactory.MoveFileTo("./template/cfl3d.alpha", path);
                //InpFactory.MoveFileTo("./template/cfl3d.res", path);
                Boolean isSucess = false;
                if (iszn)
                {
                    isSucess = processCommand(" -n " + cm.xc + " cfd2.exe " + inpName, path);
                }
                else
                {
                    isSucess = processCommand(" -np " + cm.xc + " cfd1.exe", path);
                }

                #region 处理输出结果文件
                if (!isSucess && !File.Exists(path + "/" + inpNameWithout + ".res"))
                {
                    MessageBox.Show("Ma:=" + cm.mahe + " alpha:=" + cm.yj + "计算失败，该状态自动忽略");
                    continue;
                }

                re.ma = cm.mahe;
                #region 处理alpha
                if (cm.isyj)
                {
                    re.alpha = cm.yj;
                }
                else
                {
                    List<String> alphaList = InpFactory.readFile(path + "/" + inpNameWithout + ".alpha");
                    if (alphaList != null && alphaList.Count() > 0)
                    {
                        String line = alphaList[alphaList.Count - 1];
                        List<String> lineList = this.processLine(line);
                        String str = lineList[4];
                        re.alpha = Convert.ToDouble(str);
                    }
                }
                #endregion
                List<String> resList = InpFactory.readFile(path + "/" + inpNameWithout + ".res");
                if (resList != null && resList.Count() > 0)
                {
                    int count = resList.Count();
                    double cl = 0; double cd = 0; double cmz = 0;
                    for (int j = count - znCl; j < count; j++)
                    {
                        String line = resList[j];
                        List<String> lineList = this.processLine(line);
                        cl += Convert.ToDouble(lineList[2]);
                        cd += Convert.ToDouble(lineList[3]);
                        if (!iszn)
                        {
                            cmz += Convert.ToDouble(lineList[5]);
                        }
                        else
                        {
                            cmz += Convert.ToDouble(lineList[9]);
                        }
                    }
                    cl = cl / znCl;
                    cd = cd / znCl;
                    re.cl = cl;
                    re.cd = cd;
                    re.cm = cmz;
                    re.k = (cl / cd);
                }
                #endregion

                resultList.Add(re);
            }
            processResult(resultList);
        }

        public Boolean processCommand(String command, String path)
        {
            Process cmd = new Process();
            try
            {
                //没有这个命令。暂时改为cd吧。
                //cmd.StartInfo.FileName = command;
                // MessageBox.Show("begin");
                cmd.StartInfo.FileName = @"mpiexec.exe";
                cmd.StartInfo.Arguments = command;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.WorkingDirectory = path;
                cmd.EnableRaisingEvents = true;
                //cmd.StartInfo.UserName = "sueely";
                //SecureString s = new SecureString();
                //s.AppendChar('1');
                //s.AppendChar('2');
                //s.AppendChar('3');
                //cmd.StartInfo.Password =s;

                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.OutputDataReceived += new DataReceivedEventHandler(SortOutputHandler);
                // cmd.StandardInput.WriteLine(command);
                // cmd.StandardInput.WriteLine("");
                //判断程序是否在运行
                //cmd.WaitForExit();

                //判断程序是否在运行
                while (!isExist)
                {
                    waitcount++;
                    if (waitcount > 15)
                    {
                        isExist = false;
                        cmd.Dispose();
                        cmd.Kill();
                        return false;
                    }
                    else
                    {
                        cmd.WaitForExit(waittime);
                    }
                }
                //string info = cmd.StandardOutput.ReadToEnd();
                isExist = false;
                cmd.Dispose();
                cmd.Kill();
                // MessageBox.Show(info);
            }
            catch (Exception ex)
            {
            }
            return true;
        }

        private void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            waitcount = 0;
            if (outLine == null || outLine.Data == null)
                return;
            String result = outLine.Data;
            if (result.Contains("program finished"))
            {
                isExist = true;
            }
            this.setProcessInfo(result + "\r\n");
        }
        private delegate void ProcessInfoClient(String msg);
        int lincount = 0;
        private void setProcessInfo(String msg)
        {
            lincount++;
            if (rtb_info.InvokeRequired)
            {
                ProcessInfoClient fc = new ProcessInfoClient(setProcessInfo);
                if (msg == null)
                    msg = "===";
                this.Invoke(fc, new object[] { msg });
            }
            else
            {
                if (lincount > 3200)
                {
                    lincount = 0;
                    this.rtb_info.Clear();
                }
                this.rtb_info.AppendText(msg);
                this.rtb_info.Focus();
                this.rtb_info.Select(this.rtb_info.Text.Length, 0);
                this.rtb_info.ScrollToCaret();
            }
        }

        private List<String> processLine(String line)
        {
            List<String> result = new List<string>();
            char[] separator = { ' ' };
            String[] lineArr = line.Split(separator);
            if (lineArr != null)
            {
                foreach (String str in lineArr)
                {
                    if (!str.Equals(""))
                    {
                        result.Add(str);
                    }
                }
            }
            return result;
        }

        private void processResult(List<CalcResult> resultList)
        {
            if (resultList == null || resultList.Count <= 0)
            {
                return;
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                CalcResult result = resultList[i];
                String path = result.inpPath + ".res";
                //这次取到的位置是 yx + mahe
                String tempmapath = Path.GetDirectoryName(path) + ".dat";
                String mafileName = "initialresult.dat";
                String mapath = Path.GetDirectoryName(path) + "/" + mafileName;

                String tempyxpath = Path.GetDirectoryName(mapath) + ".dat";
                tempyxpath = Path.GetDirectoryName(tempyxpath) + ".dat";
                String yxfileName = "initialresult.dat";
                String yxpath = tempyxpath.Substring(0, tempyxpath.IndexOf(".")) + "/" + yxfileName;


                //if (!File.Exists(mapath))
                //{
                //    File.Create(mapath).Close();
                //    this.writeLine(mapath, "Ma   alpha   Cl   Cd    Cm    K");
                //}
                if (!File.Exists(yxpath))
                {
                    File.Create(yxpath).Close();
                    this.writeLine(yxpath, "Ma   alpha   Cl   Cd    Cm    K");
                }
                String line = result.ma.ToString("E5") + "  " + result.alpha.ToString("E5") + "  " + result.cl.ToString("E5") + "  "
                    + result.cd.ToString("E5") + "  " + result.cm.ToString("E5") + "  " + result.k.ToString("E5");
                //this.writeLine(mapath, line);
                this.writeLine(yxpath, line);
            }
        }

        private void writeLine(String path, string value)
        {

            //实例化一个文件流--->与写入文件相关联
            FileStream fs = new FileStream(path, FileMode.Append);
            //实例化一个StreamWriter-->与fs相关联
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.WriteLine(value);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
