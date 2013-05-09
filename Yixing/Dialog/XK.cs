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

            this.addItem(this.exListView1,this.textBox1);
            this.addItem(this.exListView2,this.textBox2);
          
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

        private void addUp_Click(object sender, EventArgs e)
        {
            this.addItem(this.exListView1,this.textBox1);
        }

        private void addItem(EXListView ex,TextBox text)
        {
            String upNumberStr = text.Text;
            ex.Items.Clear();
            try
            {
                int upNumber = Int32.Parse(upNumberStr);
                for (int i = 0; i < upNumber; i++)
                {
                    EXListViewItem item = new EXListViewItem((ex.Items.Count + 1).ToString());
                    TextBox t = new TextBox();
                    EXControlListViewSubItem exc = new EXControlListViewSubItem();
                    double value = 1.0 / (upNumber + 1) * (i + 1);
                    t.Text = string.Format("{0:#0.0000}", value);
                    exc.Tag = t;
                    item.SubItems.Add(exc);
                    ex.AddControlToSubItem(t, exc);
                   ex.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("请输入数字." + exception.Message);
            }
        }

        private void deleteUp_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Selected)
                {
                    this.exListView1.Items.Remove(item);
                }
            }
        }

        private void addDown_Click(object sender, EventArgs e)
        {
            this.addItem(this.exListView2,this.textBox2);
        }

        private void deleteDown_Click(object sender, EventArgs e)
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
