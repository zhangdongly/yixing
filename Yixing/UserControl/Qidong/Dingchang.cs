using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;
using Yixing.Dialog;
using System.Drawing;

namespace Yixing.UserControl
{
    class Dingchang : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private Yixing.UserTool.EXListView exListView2;
        private System.Windows.Forms.Button button3;
        private Panel panel4;
        private OpenFileDialog openFileDialog1;
        private Button button9;
        private Panel panel7;
        private GroupBox groupBox4;
        private Panel panel9;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private EXListView exListView1;
        private Label label11;
        private Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
        private System.Windows.Forms.Panel panel1;
    
        public Dingchang()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dingchang));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单位马赫雷诺数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "万";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 597);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 558);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "开始计算";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.exListView2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(334, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 415);
            this.panel3.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(324, 41);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "导入计算状态 ";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // exListView2
            // 
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(3, 165);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(452, 211);
            this.exListView2.TabIndex = 4;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "计算状态总数：5 个";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 48);
            this.panel2.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Location = new System.Drawing.Point(25, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Location = new System.Drawing.Point(16, 129);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(303, 471);
            this.panel7.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel9);
            this.groupBox4.Controls.Add(this.exListView1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 420);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.toolStrip1);
            this.panel9.Location = new System.Drawing.Point(3, 376);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(291, 30);
            this.panel9.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新增计算翼型";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "删除计算翼型";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "编辑计算翼型";
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(3, 41);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(291, 335);
            this.exListView1.TabIndex = 1;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "计算翼型个数：5个";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "保存计算状态 ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(18, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(202, 113);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "编辑计算状态 ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Dingchang
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Dingchang";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Dingchang_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            QidongResult qidongResult = new QidongResult();
            qidongResult.Show();
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = this.selectFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DingChangGaoji dcgj = new DingChangGaoji();
            dcgj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wanggeshezhi w = new Wanggeshezhi();
            w.ShowDialog();
        }

        private void Dingchang_Load(object sender, EventArgs e)
        {
            this.exListView2.Columns.Add("马赫数");
            this.exListView2.Columns.Add("迎角/升力系数",100);
            this.exListView2.Columns.Add("转捩");
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 25);
            this.exListView2.SmallImageList = iList;

            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.comboBox2.Text = this.comboBox2.Items[0].ToString();
            this.radioButton1.Checked = true;
           // this.checkBox1.Checked = true;

            this.exListView1.Columns.Add("文件名",50);
            this.exListView1.Columns.Add("路径",180);
        }

        private void addMethodAndStatus()
        {
            String mahe = this.textBox2.Text;

            if (String.IsNullOrEmpty(mahe))
            {
                MessageBox.Show("请输入马赫数");
                return;
            }
            String y = textBox3.Text;
            float low=0;
            float high=0;
            float step=0;
            if (!radioButton3.Checked)
            {
                if (radioButton5.Checked)
                {
                    y = textBox8.Text;
                }
                else
                {
                    try
                    {
                         low =float.Parse(this.textBox5.Text);
                         high = float.Parse(this.textBox4.Text);
                         step = float.Parse(this.textBox6.Text);
                       
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("上限，下限，步长请输入数字");
                    }
                }
            }
            if (radioButton6.Checked)
            {
                for (float yl = low; yl < high; yl += step)
                {
                    EXListViewItem item = new EXListViewItem(mahe);
                    item.SubItems.Add(string.Format("{0:#0.00}",yl));
                    CheckBox c = new CheckBox();
                    c.Checked = this.checkBox1.Checked;
                    EXControlListViewSubItem clv = new EXControlListViewSubItem();
                    item.SubItems.Add(clv);
                    this.exListView2.AddControlToSubItem(c, clv);
                    this.exListView2.Items.Add(item);
                }
            }
            else
            {
                EXListViewItem item = new EXListViewItem(mahe);
                item.SubItems.Add(y);
                CheckBox c = new CheckBox();
                c.Checked = this.checkBox1.Checked;
                EXControlListViewSubItem clv = new EXControlListViewSubItem();
                item.SubItems.Add(clv);
                this.exListView2.AddControlToSubItem(c, clv);
                this.exListView2.Items.Add(item);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.addMethodAndStatus();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                this.radioButton5.Checked = true;
                this.panel5.Enabled = true;
            }
            else
            {
                this.panel5.Enabled = false; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox10.Text = this.selectFile();
        }

        private String selectFile()
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.FileName = null;
            openFileDialog1.Filter = "(*.txt,*.res)|*.jpg;*gif;*jpeg;*bmp|所有文件(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   return  this.openFileDialog1.FileName;
                }
                catch
                {
                }
            }
            return null;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                textBox8.Enabled = true;
                this.panel6.Enabled = false;
            }
            else
            {
                textBox8.Enabled = false;
                this.panel6.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Yixingjihetu y = new Yixingjihetu();
            y.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                zhuannie z = new zhuannie();
                z.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String filePath = FileDialogUtil.getSelectFileName(this.openFileDialog1);
            if (filePath != null)
            {
              //  MessageBox.Show(file);
                String fileName = filePath.Substring(filePath.LastIndexOf("\\"));
                EXListViewItem item = new EXListViewItem(fileName);
                item.SubItems.Add(filePath);
                this.exListView1.Items.Add(item);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            foreach(EXListViewItem item in this.exListView1.Items){
                if (item.Selected)
                {
                    this.exListView1.Items.Remove(item);
                }
            }
        }


       
    }
}
