using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yixing.UserTool;

namespace Yixing.UserControl.DataSourceOperate
{
    public partial class SelectAirfoil : Form
    {
        public SelectAirfoil()
        {
            InitializeComponent();
            this.iList = new ImageList();
            this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iList.ImageSize = new System.Drawing.Size(1, 30);
            this.iList.TransparentColor = System.Drawing.Color.Transparent;
            this.exListView1.SmallImageList = iList;
            this.exListView1.Columns.Add("翼型名", 150);
            this.exListView1.Columns.Add("备注", 250);
            this.exListView1.Columns.Add("选择", 100);
            this.initData();
        }

        private void initData()
        {

            for (int i = 0; i < 15; i++)
            {
                EXListViewItem item = new EXListViewItem("NASA_NIF_" + i);
                if (i % 6 == 0)
                {
                    item.SubItems.Add("NASA_NIF备注");
                }
                else
                {
                    item.SubItems.Add("");
                }

                CheckBox c = new CheckBox();
                c.Tag = item;
                EXControlListViewSubItem check = new EXControlListViewSubItem();
                item.SubItems.Add(check);
                this.exListView1.AddControlToSubItem(c, check);
                this.exListView1.Items.Add(item);
            }
        }
    }
}
