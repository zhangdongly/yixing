using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yixing.UserControl
{
    class QidongTitle:System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.TreeView treeView1;
    
        public QidongTitle()
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(6, 14);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
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
            this.treeView1.Size = new System.Drawing.Size(124, 572);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // QidongTitle
            // 
            this.Controls.Add(this.treeView1);
            this.Name = "QidongTitle";
            this.Size = new System.Drawing.Size(130, 600);
            this.ResumeLayout(false);

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            TreeView tr = (TreeView)sender;
            
           // MessageBox.Show("Clieck");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            String name = e.Node.Name;
            if(name.Equals("dingchang")){

            }

            MessageBox.Show(e.Node.Name);

        }
    }
}
