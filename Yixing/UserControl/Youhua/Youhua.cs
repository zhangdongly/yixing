using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;

namespace Yixing.UserControl.Youhua
{
    class Youhua:System.Windows.Forms.UserControl
    {
        private UserTool.EXListView exListView1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;

        private Parameter p;
        private Model m;
        private Panel panel1;
        private Jiankong j;
        private Chuli c;

        private ArrayList youhuaSteps;

        private Button button2;
        private Button button1;
        private YouhuaMethod ym;
        private int current = 0;
    
        public Youhua()
        {
            this.InitializeComponent();
            

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youhua));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.p = new Yixing.UserControl.Youhua.Parameter();
            this.m = new Yixing.UserControl.Youhua.Model();
            this.ym = new Yixing.UserControl.Youhua.YouhuaMethod();
            this.j = new Yixing.UserControl.Youhua.Jiankong();
            this.c = new Yixing.UserControl.Youhua.Chuli();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exListView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(930, 600);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // exListView1
            // 
            this.exListView1.AutoArrange = false;
            this.exListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.exListView1.Location = new System.Drawing.Point(3, 3);
            this.exListView1.Margin = new System.Windows.Forms.Padding(5);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(125, 600);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            this.exListView1.Click += new System.EventHandler(this.exListView1_DoubleClick);
            this.exListView1.DoubleClick += new System.EventHandler(this.exListView1_DoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 554);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "下一步";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "上一步";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 594);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "true.png");
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(0, 0);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(800, 500);
            this.p.TabIndex = 0;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(0, 0);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(800, 600);
            this.m.TabIndex = 0;
            // 
            // ym
            // 
            this.ym.Location = new System.Drawing.Point(0, 0);
            this.ym.Name = "ym";
            this.ym.Size = new System.Drawing.Size(800, 560);
            this.ym.TabIndex = 0;
            // 
            // j
            // 
            this.j.Location = new System.Drawing.Point(0, 0);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(800, 550);
            this.j.TabIndex = 0;
            this.j.Visible = false;
            this.j.Load += new System.EventHandler(this.j_Load);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(0, 0);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(800, 600);
            this.c.TabIndex = 0;
            this.c.Visible = false;
            this.c.Load += new System.EventHandler(this.c_Load);
            // 
            // Youhua
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "Youhua";
            this.Size = new System.Drawing.Size(930, 600);
            this.Load += new System.EventHandler(this.control_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void control_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("优化步骤",100);
            this.exListView1.Columns.Add("",25);
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1,45);
            this.exListView1.SmallImageList = iList;
          
           
            EXListViewItem item = new EXListViewItem("参数优化");
                
           //item.SubItems.Add(new EXMultipleImagesListViewSubItem(new ArrayList(){this.imageList1.Images[0]}));
           this.exListView1.Items.Add(item);

           item = new EXListViewItem("目标函数定义");

           this.exListView1.Items.Add(item);

           item = new EXListViewItem("优化方法选择");

           this.exListView1.Items.Add(item);

           //item = new EXListViewItem("前处理");

           //this.exListView1.Items.Add(item);

//           item = new EXListViewItem("优化后处理");

  //         this.exListView1.Items.Add(item);

           youhuaSteps = new ArrayList();
           youhuaSteps.Add(p);
           youhuaSteps.Add(m);
           youhuaSteps.Add(ym);
           youhuaSteps.Add(j);
           youhuaSteps.Add(c);

           this.panel1.Controls.Add((System.Windows.Forms.UserControl)this.youhuaSteps[current]);

  
        }

        private void exListView1_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            current -= 1;
            if (current < 0)
            {
                
                return;
            }
            if (current <= 0)
            {
                this.button1.Visible = false;

            }
            this.button2.Visible = true;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add((System.Windows.Forms.UserControl)this.youhuaSteps[current]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            current += 1;
            if (current > 2)
            {
               
                return;
            }
            if (current >= 2)
            {
                this.button2.Visible = false;
            }
            this.button1.Visible = true;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add((System.Windows.Forms.UserControl)this.youhuaSteps[current]);
                
        }

        private void exListView1_DoubleClick(object sender, EventArgs e)
        {
            EXListView item = (EXListView)sender;
            foreach (EXListViewItem i in item.Items)
            {
                i.BackColor = Color.White;
            }
            int index = item.SelectedItems[0].Index;
          //  item.SelectedItems[0].SubItems.Add(new EXMultipleImagesListViewSubItem(new ArrayList() { this.imageList1.Images[0] })); 
            current = index;
            item.SelectedItems[0].BackColor = Color.DodgerBlue;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add((System.Windows.Forms.UserControl)this.youhuaSteps[current]);
            
        }

        private void c_Load(object sender, EventArgs e)
        {

        }

        private void j_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
       
    }
}
