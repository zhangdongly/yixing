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

namespace Yixing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ImageList il = new ImageList();
            il.ImageSize = new Size(1,30);
            this.exListView1.SmallImageList = il;
            this.exListView1.BeginUpdate();

            for (int i = 0; i < 100; i++)
            {
                EXListViewItem item = new EXListViewItem(i.ToString());
                
                
                item.SubItems.Add("a" + i);
                item.SubItems.Add("b" + (i - 100));
                EXControlListViewSubItem cs = new EXControlListViewSubItem();
                CheckBox cb = new CheckBox();
                cb.Checked = i % 2 > 0;
                item.SubItems.Add(cs);
                this.exListView1.AddControlToSubItem(cb, cs);

                EXControlListViewSubItem csb = new EXControlListViewSubItem();

                Button b = new Button();
                b.Text = "删除";
                b.Height = 25;
                b.Tag = item;
                item.SubItems.Add(csb);
                b.Click += new System.EventHandler(this.btn_Click);
                this.exListView1.AddControlToSubItem(b, csb);

                this.exListView1.Items.Add(item);
            }
            this.exListView1.EndUpdate();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            String result = "";

            
          
            EXListViewItem item = b.Tag as EXListViewItem;
            this.exListView1.Items.Remove(item);

            MessageBox.Show("OK");
            
        }
    }
}
