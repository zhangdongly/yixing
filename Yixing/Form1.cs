using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.Dialog;
using Yixing.model;
using Yixing.UserControl;
using Yixing.UserControl.Youhua;
using Yixing.UserTool;

namespace Yixing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           // this.skinEngine1.SkinFile = "MP10.ssk";
           //String a = Yixing.Properties.Resources.defaultYixingFolder;
          //  System.Resources.ResourceManager rs = new System.Resources.ResourceManager(typeof(Form1));
           
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(youhua);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(qidong);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Jiankong j = new Jiankong();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(j);
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            YouhuaStatus j = new YouhuaStatus();
            j.ShowDialog();
           
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Chuli l = new Chuli();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(l);

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ShowResult sr = new ShowResult();
            sr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login l = new Login(this);
            l.ShowDialog();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(qidong);
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            String folderPath = FileDialogUtil.getSelectFolder(this.folderBrowserDialog1);
            while (String.IsNullOrWhiteSpace(folderPath))
            {
                folderPath = FileDialogUtil.getSelectFolder(this.folderBrowserDialog1);
            }
            Yixing.Properties.Settings.Default.currentProjectFolder = folderPath+"\\"; 
            this.panel1.Controls.Add(youhua);
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            Jiankong j = new Jiankong();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(j);
           
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {

            YouhuaStatus j = new YouhuaStatus();
            j.ShowDialog();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
            Chuli l = new Chuli();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(l);

        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            ShowResult sr = new ShowResult();
            sr.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Jihetexing j = new Jihetexing();
            j.ShowDialog();
        }

        private void 文件保存路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetFileFolder s = new SetFileFolder();
            s.ShowDialog();
        }

       
    }
}
