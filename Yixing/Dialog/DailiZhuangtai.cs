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
    public partial class DailiZhuangtai : Form
    {
        public DailiZhuangtai()
        {
            InitializeComponent();
        }

        private void DailiZhuangtai_Load(object sender, EventArgs e)
        {
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1,25);
            this.exListView1.SmallImageList = iList;
            this.exListView1.Columns.Add("状态", 100);
            this.exListView1.Columns.Add("是否使用代理",200);

            for (int i = 1; i <= 10; i++)
            {
                EXListViewItem item = new EXListViewItem("状态"+i);
                CheckBox cb = new CheckBox();
                EXControlListViewSubItem cs = new EXControlListViewSubItem();
                item.SubItems.Add(cs);
                this.exListView1.AddControlToSubItem(cb, cs);
                this.exListView1.Items.Add(item);
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
    }
}
