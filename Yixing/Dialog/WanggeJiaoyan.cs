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
    public partial class WanggeJiaoyan : Form
    {
        public WanggeJiaoyan()
        {
            InitializeComponent();
        }

        private void WanggeJiaoyan_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("马赫数");
            this.exListView1.Columns.Add("迎角/升力系数");
            this.exListView1.Columns.Add("转捩");
            Random rd=new Random();
            for (int i = 0; i < 5; i++)
            {
                EXListViewItem item = new EXListViewItem("0.6");
                item.SubItems.Add((i+rd.Next(10))+"");
                CheckBox c = new CheckBox();
                c.Checked = true;
                EXControlListViewSubItem exc = new EXControlListViewSubItem();
                item.SubItems.Add(exc);
                this.exListView1.AddControlToSubItem(c,exc);
                this.exListView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
