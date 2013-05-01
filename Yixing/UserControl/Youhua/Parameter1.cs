using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yixing.UserTool;
using System.Windows.Forms;
using Yixing.Dialog;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yixing.UserControl.Youhua
{
    class Parameter1:System.Windows.Forms.UserControl
    {
        private int varCount = 0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private UserTool.EXListView exListView1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox2;
        private Panel panel5;
        private Button button5;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
    
        public Parameter1()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exListView1);
            this.panel4.Location = new System.Drawing.Point(24, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(755, 259);
            this.panel4.TabIndex = 1;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.Location = new System.Drawing.Point(25, 12);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(702, 237);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 223);
            this.panel2.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.LightGray;
            this.chart1.BorderSkin.BorderWidth = 2;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.LabelStyle.Format = "{0.00}";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(470, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(296, 162);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(472, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "相关设置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "输出翼型数据";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 217);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始翼型网格生成方法";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(9, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 72);
            this.panel5.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "浏览...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "浏览...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(257, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 21);
            this.textBox3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "边界文件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "翼型网格";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(249, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "指定网格";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "自动生成";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FFD",
            "CST",
            "Hicks-Henne"});
            this.comboBox1.Location = new System.Drawing.Point(88, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "浏览...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(270, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "参数化方法";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始翼型";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Parameter1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Name = "Parameter1";
            this.Size = new System.Drawing.Size(825, 500);
            this.Load += new System.EventHandler(this.control_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
             
                int varCount = this.varCount;
                this.exListView1.Items.Clear();
           
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
                MessageBox.Show("请输入设计变量个数 "+exception.Message);
            }

        }

        private void addParameter(double begin,double end,double currentValue)
        {
            
            try
            {
               // int varCount = Convert.ToInt32(this.textBox2.Text);
                int varCount = this.varCount;
                this.exListView1.Items.Clear();
                for (int i = 1; i <= varCount; i++)
                {
                    EXListViewItem item = new EXListViewItem(i + "");
                    item.SubItems.Add("x" + i);
                    EXControlListViewSubItem lower = new EXControlListViewSubItem();
                    TextBox t = new TextBox();
                    t.Text = begin.ToString();
                    item.SubItems.Add(lower);
                    this.exListView1.AddControlToSubItem(t, lower);

                    item.SubItems.Add("<=");

                    EXControlListViewSubItem current = new EXControlListViewSubItem();

                    TextBox c = new TextBox();
                    c.Text = currentValue.ToString();
                    item.SubItems.Add(current);
                    this.exListView1.AddControlToSubItem(c, current);

                    item.SubItems.Add("<=");

                    EXControlListViewSubItem up = new EXControlListViewSubItem();
                    TextBox u = new TextBox();
                    u.Text = end.ToString();
                    item.SubItems.Add(up);
                    this.exListView1.AddControlToSubItem(u, up);

                    this.exListView1.Items.Add(item);


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("请输入设计变量个数 " + exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
            if(!String.IsNullOrWhiteSpace(this.textBox1.Text)){
                this.showJihetu();
            }
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
                FFD1 f = new FFD1();

                if (f.ShowDialog() == DialogResult.OK)
                {
                    this.varCount =Convert.ToInt32(f.count.ToString());
                    this.addParameter(-0.02, 0.02, 0);
                }
            }
            else if (this.comboBox1.Text.Equals("CST"))
            {
                CST cst = new CST();
                if (cst.ShowDialog() == DialogResult.OK)
                {
                    this.varCount =Convert.ToInt32(cst.count.ToString());
                    this.addParameter(-0.006, 0.006, 0);
                }
            }else
            {
                    XK x = new XK();
                    if (x.ShowDialog() == DialogResult.OK)
                    {
                        this.varCount =Convert.ToInt32( x.count.ToString());
                        this.addParameter(0,1, 0);
                    }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.panel5.Enabled = this.radioButton2.Checked;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.textBox3.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void showJihetu()
        {
            System.Windows.Forms.DataVisualization.Charting.Series serise = this.chart1.Series[0];
            serise.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            double[] XList = { 1.00000, 0.97780, 0.95111, 0.93869, 0.91913, 0.89958, 0.88002, 0.87024, 0.85069, 0.83113, 0.80668, 0.78224, 0.75779, 0.73335, 0.70890, 0.68445, 0.66001, 0.63556, 0.61112, 0.58667, 0.56223, 0.53778, 0.51334, 0.48889, 0.46445, 0.44000, 0.41556, 0.39111, 0.36666, 0.34222, 0.31777, 0.29333, 0.26888, 0.24444, 0.21999, 0.19555, 0.17110, 0.14666, 0.12221, 0.09288, 0.08310, 0.07333, 0.06355, 0.05377, 0.04497, 0.03911, 0.03519, 0.02933, 0.02248, 0.01564, 0.00977, 0.00704, 0.00489, 0.00176, 0.00078, 0.00029, 0.00000, 0.00029, 0.00078, 0.00176, 0.00489, 0.00704, 0.00978, 0.01565, 0.02249, 0.02934, 0.03520, 0.03912, 0.04498, 0.05378, 0.06356, 0.07334, 0.08312, 0.09290, 0.12223, 0.14667, 0.17112, 0.19557, 0.22001, 0.24446, 0.26890, 0.29335, 0.31779, 0.34224, 0.36668, 0.39113, 0.41557, 0.44002, 0.46446, 0.48891, 0.51335, 0.53780, 0.56224, 0.58669, 0.61113, 0.63558, 0.66002, 0.68447, 0.70891, 0.73336, 0.75780, 0.78225, 0.80669, 0.83114, 0.85069, 0.87025, 0.88003, 0.89958, 0.91914, 0.93869, 0.95111, 0.97780, 1.00000 };
            double[] YList = { 0.00252, 0.00198, 0.00358, 0.00491, 0.00747, 0.01036, 0.01336, 0.01484, 0.01771, 0.02044, 0.02367, 0.02673, 0.02964, 0.03241, 0.03504, 0.03754, 0.03988, 0.04208, 0.04413, 0.04604, 0.04781, 0.04943, 0.05092, 0.05225, 0.05343, 0.05445, 0.05533, 0.05610, 0.05679, 0.05742, 0.05800, 0.05851, 0.05889, 0.05906, 0.05893, 0.05841, 0.05739, 0.05571, 0.05322, 0.04880, 0.04687, 0.04467, 0.04213, 0.03919, 0.03614, 0.03384, 0.03217, 0.02944, 0.02585, 0.02162, 0.01715, 0.01458, 0.01216, 0.00722, 0.00475, 0.00286, 0.00000, -0.00260, -0.00408, -0.00579, -0.00862, -0.00979, -0.01091, -0.01261, -0.01401, -0.01509, -0.01587, -0.01633, -0.01696, -0.01780, -0.01864, -0.01942, -0.02016, -0.02089, -0.02299, -0.02467, -0.02626, -0.02772, -0.02900, -0.03007, -0.03092, -0.03158, -0.03208, -0.03249, -0.03284, -0.03312, -0.03333, -0.03342, -0.03337, -0.03316, -0.03279, -0.03227, -0.03161, -0.03081, -0.02988, -0.02879, -0.02757, -0.02619, -0.02467, -0.02301, -0.02122, -0.01928, -0.01718, -0.01490, -0.01292, -0.01080, -0.00971, -0.00755, -0.00555, -0.00393, -0.00318, -0.00243, -0.00251 };
            for (int i = 0; i < XList.Length; i++)
            {
                serise.Points.Add(new DataPoint(XList[i], YList[i]));
            }
        }

       
    }
}
