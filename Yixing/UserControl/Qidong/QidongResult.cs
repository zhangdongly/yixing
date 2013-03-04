using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.Dialog;
using Yixing.UserTool;

namespace Yixing.UserControl
{
    class QidongResult:System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Label label4;
        private Label label3;
        private Label label2;
        private UserTool.EXListView exListView1;
        private Label label5;
        private System.Windows.Forms.Panel panel1;
    
        public QidongResult()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 44);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "计算失败失败状态数：4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "已完成状态数：10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "总状态数：100";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exListView1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 535);
            this.panel2.TabIndex = 1;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(8, 47);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(760, 364);
            this.exListView1.TabIndex = 4;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "绘图";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "保存结果";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "计算结果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "当前计算状态：Ma=0.6，alpha=2.0";
            // 
            // QidongResult
            // 
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QidongResult";
            this.Text = "气动特性评估计算过程";
            this.Load += new System.EventHandler(this.QidongResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = " txt files(*.txt)|*.txt|All files(*.*)|*.*";  
  
    //设置默认文件类型显示顺序  
    saveFileDialog1.FilterIndex = 2;  
  
    //保存对话框是否记忆上次打开的目录  
    saveFileDialog1.RestoreDirectory = true;  
  
    //点了保存按钮进入  
    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
    {
        MessageBox.Show(saveFileDialog1.FileName);
    }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowResult sr = new ShowResult();

            sr.ShowDialog();
        }

        private void QidongResult_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("No");
            this.exListView1.Columns.Add("Mach");
            this.exListView1.Columns.Add("alpha");
            this.exListView1.Columns.Add("cl",100);
            this.exListView1.Columns.Add("cd",100);
            this.exListView1.Columns.Add("cm",100);
            this.exListView1.Columns.Add("k",100);
            this.exListView1.Columns.Add("计算是否成功",200);
            
            for(int i=1;i<10;i++){
                EXListViewItem item = new EXListViewItem(i.ToString());
                item.SubItems.Add("0.5");
                item.SubItems.Add("0");
                item.SubItems.Add(" 0.06741300 ");
                item.SubItems.Add("0.00835220");
                item.SubItems.Add("0.00070531");
                item.SubItems.Add("8.07128661");
                item.SubItems.Add("是");
                this.exListView1.Items.Add(item);

            }
           
        }
    }
}
