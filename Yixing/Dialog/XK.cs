using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class XK : Form
    {
        public XK()
        {
            InitializeComponent();
        }

        private void XK_Load(object sender, EventArgs e)
        {
            
            this.exListView1.Columns.Add("xk序号",100);
            this.exListView1.Columns.Add("上表面",110);
           // this.exListView1.Columns.Add("下表面",110);
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 25);
            this.exListView1.SmallImageList = iList;


            this.exListView2.Columns.Add("xk序号", 100);
            this.exListView2.Columns.Add("下表面", 110);          
            this.exListView2.SmallImageList = iList;
          
        }
        public void setCount(int count)
        {
            this.count = count;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.count = this.exListView1.Items.Count+this.exListView2.Items.Count;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXListViewItem item = new EXListViewItem((this.exListView1.Items.Count+1).ToString());
            TextBox t = new TextBox();
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(t, exc);
            this.exListView1.Items.Add(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Selected)
                {
                    this.exListView1.Items.Remove(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EXListViewItem item = new EXListViewItem((this.exListView2.Items.Count + 1).ToString());
            TextBox t = new TextBox();
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView2.AddControlToSubItem(t, exc);
            this.exListView2.Items.Add(item);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView2.Items)
            {
                if (item.Selected)
                {
                    this.exListView2.Items.Remove(item);
                }
            }
        }

       
    }
}
