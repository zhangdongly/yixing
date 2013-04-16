using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.Dialog;
using Yixing.model;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl
{
    class QidongResult:System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Label label4;
        private Label label3;
        private Label label2;
        private UserTool.EXListView exListView1;
        private Label label5;
        private System.Windows.Forms.Panel panel1;

        private List<CalcModel> cmList;
        private DCYixing yx;
        ThreadStart ts;
        Thread t;
        private RichTextBox rtb_info;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;

        private int znCl = 10;
        //用于判定进程是否结束
        bool isExist = false;
        //计算时的等待次数，每次等待为3秒种
        int waitcount = 10;
        //计算时的等待时间,这个是毫秒级别
        int waittime =3000;

        public QidongResult()
        {
            this.InitializeComponent();
        }

        public QidongResult(List<CalcModel> cmList, DCYixing yx)
        {
            this.InitializeComponent();
            this.cmList =cmList;
            this.yx = yx;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 44);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "当前计算状态：Ma=0.6，alpha=2.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "计算失败失败状态数：4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "已完成状态数：10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "总状态数：100";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtb_info);
            this.panel2.Controls.Add(this.exListView1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 595);
            this.panel2.TabIndex = 1;
            // 
            // rtb_info
            // 
            this.rtb_info.Location = new System.Drawing.Point(8, 417);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.Size = new System.Drawing.Size(760, 132);
            this.rtb_info.TabIndex = 6;
            this.rtb_info.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(592, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "绘图";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "保存结果";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算结果";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(8, 47);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(760, 364);
            this.exListView1.TabIndex = 4;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // QidongResult
            // 
            this.ClientSize = new System.Drawing.Size(784, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QidongResult";
            this.Text = "气动特性评估计算过程";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QidongResult_FormClosing);
            this.Load += new System.EventHandler(this.QidongResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " txt files(*.txt)|*.txt|All files(*.*)|*.*";  
  
            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 2;  
  
            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;  
  
            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowResult sr = new ShowResult();

            sr.ShowDialog();
        }

        private void QidongResult_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("No");
            this.exListView1.Columns.Add("Mach");
            this.exListView1.Columns.Add("alpha");
            this.exListView1.Columns.Add("cl",100);
            this.exListView1.Columns.Add("cd",100);
            this.exListView1.Columns.Add("cm",100);
            this.exListView1.Columns.Add("k",100);
            this.exListView1.Columns.Add("计算是否成功",200);
            ts = new ThreadStart(this.startCalc);
            t = new Thread(ts);
            // 启动.
            t.Start();
        }
        private delegate void setStatus(String total, String completed, String failCount, String mahe, String yj);
        private void setCalcStatus(String total,String completed,String failCount,String mahe,String yj)
        {
            if (exListView1.InvokeRequired)
            {
                setStatus fc = new setStatus(setCalcStatus);
                this.Invoke(fc, new object[] { total, completed, failCount, mahe, yj });
            }
            else
            {
                if(!total.Equals(""))
                    this.label2.Text = "总状态数：" + total;
                if (!completed.Equals(""))
                this.label3.Text = "已完成状态数：" + completed;
                if (!failCount.Equals(""))
                this.label4.Text = "计算失败失败状态数：" + failCount;
                if (!mahe.Equals(""))
                this.label5.Text = "当前计算状态：Ma=" + mahe + " alpha=" + yj;
            }
        }

        int failedcount = 0;
        private void startCalc()
        {
            this.setCalcStatus("" + cmList.Count(), "", "", "", "");
            for (int i = 0; i < cmList.Count(); i++)
            {
                CalcModel cm = cmList[i];
                this.setCalcStatus("", "" + (i + 1), "", "" + cm.mahe, "" + cm.yj);
                String inpPath = cm.inpPath;
                Boolean iszn = cm.isZn;
                String path = Path.GetDirectoryName(inpPath);
                String inpName = Path.GetFileName(inpPath);
                String inpNameWithout = inpName.Substring(0, inpName.IndexOf("."));
                //移动xyz文件到，inp所在的文件夹
                InpFactory.MoveFileTo(yx.xyzPath, path);
                //移动alpha文件到，inp所在的文件夹
                //InpFactory.MoveFileTo("./template/cfl3d.alpha", path);
                //InpFactory.MoveFileTo("./template/cfl3d.res", path);
                if (iszn)
                {
                    processCommand(" -n " + cm.xc + " cfd2.exe " + inpName, path);
                }
                else
                {
                    processCommand(" -np " + cm.xc + " cfd1.exe", path);
                }
                #region 处理输出结果文件
                if (!File.Exists(path + "/" + inpNameWithout + ".res"))
                {
                    failedcount++;
                    MessageBox.Show(cm.mahe + "没有生成结果文件，该状态自动忽略");
                    continue;
                }

                EXListViewItem item = new EXListViewItem(""+(i+1));
                item.SubItems.Add("" + cm.mahe);
                #region 处理alpha
                if (cm.isyj)
                {
                    item.SubItems.Add("" + cm.yj.ToString("E5"));
                }
                else
                {
                    List<String> alphaList = InpFactory.readFile(path + "/" + inpNameWithout + ".alpha");
                    if (alphaList != null && alphaList.Count() > 0)
                    {
                        String line = alphaList[alphaList.Count - 1];
                        List<String> lineList = this.processLine(line);
                        String str = lineList[4];
                        item.SubItems.Add(Convert.ToDouble(str).ToString("E5"));
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
                    item.SubItems.Add(cl.ToString("E5"));
                    item.SubItems.Add(cd.ToString("E5"));
                    item.SubItems.Add((cmz / znCl).ToString("E5"));
                    item.SubItems.Add((cl / cd).ToString("E5"));
                }
                #endregion

                if (iszn)
                {
                    item.SubItems.Add("0");
                }
                else
                {
                    item.SubItems.Add("1");
                }
                item.SubItems.Add("0");
                this.setItem(item);
                this.setCalcStatus("" , "", "" + failedcount, "", "");
            }
            if(t.IsAlive)
                t.Abort(); 
        }

        private delegate void FlushClient(EXListViewItem item);

        private void setItem(EXListViewItem item)
        {
            if (exListView1.InvokeRequired)
            {
                FlushClient fc = new FlushClient(setItem);
                this.Invoke(fc, new object[] {item});
            }
            else
            {
                this.exListView1.Items.Add(item);
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

        public void processCommand(String command, String path)
        {
            Process cmd = new Process();
            try {
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
                        cmd.Dispose();
                        cmd.Kill();
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
            }catch(Exception ex){
            }
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
                this.Invoke(fc, new object[] {msg});
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

        private void SortOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            waitcount = 0;
            if (outLine == null || outLine.Data==null)
                return;
            String result = outLine.Data;
            if (result.Contains("program finished"))
            {
                isExist = true;
            }
            this.setProcessInfo(result + "\r\n");
        }

        private void QidongResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}
