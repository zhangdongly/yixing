using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.UserControl
{
    class Qidong:System.Windows.Forms.UserControl
    {
        private Dingchang1 dingchang1;
        private BuDingchang budingchang;
        private Sanwei sanwei;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        
        public Qidong()
        {
            this.InitializeComponent();


        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("定常");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("非定常");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("二维", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("三维");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("气动特性评估", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dingchang1 = new Yixing.UserControl.Dingchang1();
            this.budingchang = new Yixing.UserControl.BuDingchang();
            this.sanwei = new Yixing.UserControl.Sanwei();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dingchang1);
            this.splitContainer1.Size = new System.Drawing.Size(939, 600);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "dingchang";
            treeNode1.Text = "定常";
            treeNode2.Name = "feidingchang";
            treeNode2.Text = "非定常";
            treeNode3.Name = "节点1";
            treeNode3.Text = "二维";
            treeNode4.Name = "sanwei";
            treeNode4.Text = "三维";
            treeNode5.Name = "节点0";
            treeNode5.Text = "气动特性评估";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(144, 590);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dingchang1
            // 
            this.dingchang1.Location = new System.Drawing.Point(0, 0);
            this.dingchang1.Name = "dingchang1";
            this.dingchang1.Size = new System.Drawing.Size(800, 600);
            this.dingchang1.TabIndex = 0;
            this.dingchang1.Load += new System.EventHandler(this.dingchang1_Load);
            // 
            // budingchang
            // 
            this.budingchang.Location = new System.Drawing.Point(0, 0);
            this.budingchang.Name = "budingchang";
            this.budingchang.Size = new System.Drawing.Size(800, 600);
            this.budingchang.TabIndex = 0;
            // 
            // sanwei
            // 
            this.sanwei.Location = new System.Drawing.Point(0, 0);
            this.sanwei.Name = "sanwei";
            this.sanwei.Size = new System.Drawing.Size(800, 600);
            this.sanwei.TabIndex = 0;
            // 
            // Qidong
            // 
            this.Controls.Add(this.splitContainer1);
            this.Name = "Qidong";
            this.Size = new System.Drawing.Size(939, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            String name = e.Node.Name;
            if (name.Equals("dingchang"))
            {
                this.splitContainer1.Panel2.Controls.Add(dingchang1);
            }
            else if (name.Equals("feidingchang"))
            {
                this.splitContainer1.Panel2.Controls.Add(budingchang);
            }
            else if (name.Equals("sanwei"))
            {
                this.splitContainer1.Panel2.Controls.Add(sanwei);
            }
            else
            {
                this.splitContainer1.Panel2.Controls.Clear();
            }

        }

        private void dingchang1_Load(object sender, EventArgs e)
        {
            this.treeView1.ExpandAll();
        }

        
    }
}
