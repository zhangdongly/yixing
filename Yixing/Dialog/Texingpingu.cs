using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.model;
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class Texingpingu : Form
    {
        public Texingpingu()
        {
            InitializeComponent();
        }

        public Texingpingu(Dictionary<int, Status> ztDic)
        {
            InitializeComponent();
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
            DingChangGaoji gj = new DingChangGaoji();
            gj.Show();
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

    }
}
