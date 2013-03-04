using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yixing.UserTool;
using System.Windows.Forms;
using Yixing.Dialog;

namespace Yixing.UserControl.Youhua
{
    class Parameter:System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel4;
        private UserTool.EXListView exListView1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private Button button3;
        private System.Windows.Forms.Panel panel1;
    
        public Parameter()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "相关设置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "输出翼型数据";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "设置变量取值范围";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exListView1);
            this.panel4.Location = new System.Drawing.Point(24, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 337);
            this.panel4.TabIndex = 1;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.Location = new System.Drawing.Point(29, 21);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(702, 299);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 100);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(376, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数化方法";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "设计变量个数";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FFD",
            "CST",
            "Hicks-Henne"});
            this.comboBox1.Location = new System.Drawing.Point(163, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "参数化方法";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 94);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "......";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始翼型";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Parameter
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Parameter";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.control_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void control_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("",50);
            this.exListView1.Columns.Add("参数",100);
            this.exListView1.Columns.Add("下限",120);
            this.exListView1.Columns.Add("",50);
            this.exListView1.Columns.Add("当前值",100);
            this.exListView1.Columns.Add("",50);
            this.exListView1.Columns.Add("上限",100);
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                int varCount = Convert.ToInt32(this.textBox2.Text);
           
            for (int i = 1; i <= varCount; i++)
            {
                EXListViewItem item = new EXListViewItem(i+"");
                item.SubItems.Add("x"+i);
                EXControlListViewSubItem lower = new EXControlListViewSubItem();
                TextBox t = new TextBox();
                item.SubItems.Add(lower);
                this.exListView1.AddControlToSubItem(t,lower);

                item.SubItems.Add("<=");

                EXControlListViewSubItem current = new EXControlListViewSubItem();

                TextBox c = new TextBox();

                item.SubItems.Add(current);
                this.exListView1.AddControlToSubItem(c, current);

                item.SubItems.Add("<=");

                EXControlListViewSubItem up = new EXControlListViewSubItem();
                TextBox u = new TextBox();
                item.SubItems.Add(up);
                this.exListView1.AddControlToSubItem(u,up);

                this.exListView1.Items.Add(item);


            }
            }
            catch (Exception exception)
            {
                MessageBox.Show("请输入设计变量个数");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox com = (ComboBox)sender;
           
              //  this.button4.Enabled = !com.Text.Equals("CST");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (this.comboBox1.Text.Equals("FFD"))
            {
                FFD f = new FFD();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.textBox2.Text = f.count.ToString();
                }
            }
            else if (this.comboBox1.Text.Equals("CST"))
            {
                CST cst = new CST();
                if (cst.ShowDialog() == DialogResult.OK)
                {
                    this.textBox2.Text = cst.count.ToString();
                }
            }else
            {
                    XK x = new XK();
                    if (x.ShowDialog() == DialogResult.OK)
                    {
                        this.textBox2.Text = x.count.ToString();
                    }
               
            }
        }

       
    }
}
