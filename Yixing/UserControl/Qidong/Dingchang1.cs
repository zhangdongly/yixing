using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;
using Yixing.Dialog;
using System.Drawing;
using Yixing.model;
using Yixing.util;
using System.Globalization;

namespace Yixing.UserControl
{
    class Dingchang1 : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.GroupBox groupBox3;
        private Panel panel4;
        private OpenFileDialog openFileDialog1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;

        private Panel panel1;
        private TextBox textBox11;
        private Label label12;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button3;
        private TextBox textBox9;
        private Panel panel3;
        private GroupBox groupBox2;
        private Button button9;
        private Button button11;
        private Button button10;
        private Button button7;
        private Button button1;
        private Panel panel2;
        private GroupBox panel7;
        private Panel panel9;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton6;
        private Label label11;
        private Label label10;
        private EXListView exListView2;
        private System.Windows.Forms.ColumnHeader mahe;
        private System.Windows.Forms.ColumnHeader yj;
        private System.Windows.Forms.ColumnHeader lsgs;
        private System.Windows.Forms.ColumnHeader 端流模型;
        private System.Windows.Forms.ColumnHeader wnxb;
        private System.Windows.Forms.ColumnHeader CFL;
        private System.Windows.Forms.ColumnHeader 修正熵;
        private EXListView exListView1;

        int znkey = 0;
        int gjkey = 0;
        int ztkey = 0;
        int yxkey = 0;
        //记录单独状态的DIC 包括高级和转涅
        Dictionary<int, DCStatus> ztDic = new Dictionary<int, DCStatus>();
        //记录单独转涅的DIC 包括高级和转涅
        Dictionary<int, DCZhuannie> znDic = new Dictionary<int, DCZhuannie>();
        private Button edit;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        //记录单独高级的DIC 包括高级和转涅
        Dictionary<int, DCGaoji> gjDic = new Dictionary<int, DCGaoji>();

        //用于保存添加了多少个翼型
        Dictionary<int, DCYixing> yxDic = new Dictionary<int, DCYixing>();

        public Dingchang1()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dingchang1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.edit = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.mahe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsgs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.端流模型 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wnxb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CFL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.修正熵 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.GroupBox();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新增计算翼型";
            this.toolStripButton1.Click += new System.EventHandler(this.button12_Click);
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
            this.toolStripButton2.Click += new System.EventHandler(this.delete_Click);
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
            this.toolStripButton3.Click += new System.EventHandler(this.edit_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 576);
            this.panel1.TabIndex = 4;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(659, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "同时计算的状态数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "单位马赫雷诺数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "万";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "开始计算";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(387, 13);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(121, 21);
            this.textBox9.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(312, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 471);
            this.panel3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.exListView2);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 465);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加状态";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(10, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 170);
            this.panel5.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(223, 156);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(302, 101);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 23);
            this.edit.TabIndex = 12;
            this.edit.Text = "编辑计算状态 ";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click_1);
            // 
            // exListView2
            // 
            this.exListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mahe,
            this.yj,
            this.lsgs,
            this.端流模型,
            this.wnxb,
            this.CFL,
            this.修正熵});
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(10, 196);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(436, 263);
            this.exListView2.TabIndex = 11;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // mahe
            // 
            this.mahe.Text = "马赫数";
            this.mahe.Width = 51;
            // 
            // yj
            // 
            this.yj.Text = "迎角/升力系数";
            this.yj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yj.Width = 93;
            // 
            // lsgs
            // 
            this.lsgs.Text = "离散格式";
            this.lsgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 端流模型
            // 
            this.端流模型.Text = "端流模型";
            this.端流模型.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wnxb
            // 
            this.wnxb.Text = "转涅";
            this.wnxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wnxb.Width = 52;
            // 
            // CFL
            // 
            this.CFL.Text = "CFL";
            this.CFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 修正熵
            // 
            this.修正熵.Text = "修正熵";
            this.修正熵.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(302, 16);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "导入计算状态 ";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(302, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "全部删除";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(302, 44);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "保存计算状态";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(302, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "删除计算状态";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加计算状态";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 471);
            this.panel2.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.exListView1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 465);
            this.panel7.TabIndex = 6;
            this.panel7.TabStop = false;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(3, 31);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(291, 401);
            this.exListView1.TabIndex = 9;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            this.exListView1.DoubleClick += new System.EventHandler(this.exListView1_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.toolStrip1);
            this.panel9.Location = new System.Drawing.Point(3, 431);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(291, 30);
            this.panel9.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "新增计算翼型";
            this.toolStripButton4.Click += new System.EventHandler(this.button12_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "删除计算翼型";
            this.toolStripButton5.Click += new System.EventHandler(this.delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "编辑计算翼型";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "计算状态的线程数";
            // 
            // Dingchang1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "Dingchang1";
            this.Size = new System.Drawing.Size(791, 593);
            this.Load += new System.EventHandler(this.Dingchang_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float mhln;
            if (!float.TryParse(this.textBox1.Text, out mhln))
            {
                MessageBox.Show("马赫雷诺数必须为数字，且必填");
                return;
            }

            //测试代码，VM文件都放置于@"..//..//template"
            foreach (int key in ztDic.Keys)
            {
                DCStatus dcs = ztDic[key];
                DCGaoji gj = gjDic[dcs.gjKey];
                DCZhuannie zn = null;
                if (dcs.znKey != 0)
                {
                    zn = znDic[dcs.znKey];
                }

                DCYixing yx = dcs.yx;

                TemplateHelper tp = new TemplateHelper();
                if (zn != null)
                {
                    float tke0 = dcs.mahe * dcs.mahe * zn.fddls * zn.fddls * 1.5f;
                    float tke1 = tke0 / zn.wnxb;
                    tp.Put("tke0", tke0);
                    tp.Put("tke1", tke1);
                }
                tp.Put("gj", gj);
                tp.Put("zn", zn);
                tp.Put("s", dcs);
                tp.Put("mhln", mhln);
                String yxname = yx.name.Substring(0, yx.name.IndexOf("."));
                String mahe = string.Format("{0:0.000}", dcs.mahe);
                mahe = mahe.Replace(".", "");
                String zt;
                if (dcs.dyj > 0)
                {
                    zt = string.Format("{0:0.000}", dcs.dyj);
                    zt = "a" + zt.Replace(".", "");
                }
                else
                {
                    zt = string.Format("{0:0.000}", dcs.dslxs);
                    zt = "cl" + zt.Replace(".", "");
                }

                String a = tp.BuildString("cfl3d.vm", yxname, mahe, zt);
            }

            QidongResult qidongResult = new QidongResult();
            qidongResult.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this.textBox7.Text = this.selectFile();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Wanggeshezhi w = new Wanggeshezhi();
            w.ShowDialog();
        }


        private void Dingchang_Load(object sender, EventArgs e)
        {

            //this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            //this.comboBox2.Text = this.comboBox2.Items[0].ToString();

            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 25);

            this.exListView1.Columns.Add("文件名", 50);
            this.exListView1.Columns.Add("路径", 240);
           // this.exListView1.Columns.Add("添加状态", 60);
            this.exListView1.SmallImageList = iList;
        }

        private void show_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Selected)
                {
                    Yixingjihetu y = new Yixingjihetu();
                    y.ShowDialog();
                }
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            YixingTianjia y = new YixingTianjia();
            if (y.ShowDialog() == DialogResult.OK)
            {
                YixingModel yixing = y.yixing;
                if (yixing.filePath != null)
                {
                    yxkey++;
                    String fileName = CommonUtil.getFileNameByPath(yixing.filePath);
                    EXListViewItem item = new EXListViewItem(fileName);
                    item.SubItems.Add(yixing.filePath);
                    item.Tag = yxkey;
                  //  CheckBox c = new CheckBox();
                  // c.Checked = true;
                  //  EXControlListViewSubItem exc = new EXControlListViewSubItem();
                  //  item.SubItems.Add(exc);
                  //  this.exListView1.AddControlToSubItem(c, exc);

                    DCYixing yx = new DCYixing();
                    yx.name = fileName;
                    yx.filePath = yixing.filePath;
                    yx.key = yxkey;
                    yxDic.Add(yxkey,yx);

                    this.exListView1.Items.Add(item);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Selected)
                {
                    this.exListView1.Items.Remove(item);
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            String filePath = "";
            int index = filePath.LastIndexOf("\\");
            String fileName = filePath.Substring(index);
            EXListViewItem item = new EXListViewItem(fileName);
            item.SubItems.Add(filePath);
            CheckBox c = new CheckBox();
            c.Checked = true;
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(c, exc);
            this.exListView1.Items.Add(item);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView1.Items)
            {
                if (item.Selected)
                {
                    YixingModel yixing = (YixingModel)item.Tag;
                    YixingTianjia y = new YixingTianjia();
                    y.yixing = yixing;
                    if (y.ShowDialog() == DialogResult.OK)
                    {
                        yixing = y.yixing;
                        String fileName = CommonUtil.getFileNameByPath(yixing.filePath);
                        item.SubItems[0].Text = fileName;
                        item.SubItems[1].Text = yixing.filePath;
                    }
                }
            }
        }

        //添加计算状态的按钮
        private void button1_Click(object sender, EventArgs e)
        {
            List<DCYixing> yxList = new List<DCYixing>();
            //将选中的翼型读出来
            int count = this.exListView1.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = this.exListView1.SelectedItems[0];
                String yxkey = item.Tag.ToString();
                int key =0;
                int.TryParse(yxkey,out key);
                if (int.TryParse(yxkey, out key) && key != 0)
                {
                    DCYixing yx = yxDic[key];
                    yxList.Add(yx);
                }   
            }

            if (yxList.Count > 0)
            {
                AddStatus add = new AddStatus(yxList);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    //给翼型添加DcList

                    List<DCStatus> dcList = new List<DCStatus>();
                
                    //将添加的状态一个个写入 本类的DIC中，并改写其他key
                    foreach (int key in add.ztDic.Keys)
                    {
                        ztkey++;
                        DCStatus dcs = add.ztDic[key];
                        dcs.key = ztkey;
                        if (dcs.znKey != 0)
                        {
                            znkey++;
                            DCZhuannie zn = add.znDic[dcs.znKey];
                            this.znDic.Add(znkey, zn);
                            dcs.znKey = znkey;
                        }

                        if (dcs.gjKey != 0)
                        {
                            gjkey++;
                            DCGaoji gj = add.gjDic[dcs.gjKey];
                            this.gjDic.Add(gjkey, gj);
                            dcs.gjKey = gjkey;
                        }
                        this.ztDic.Add(ztkey, dcs);
                        this.addToList(dcs, ztkey);
                        dcList.Add(dcs);
                    }

                    //将本次添加的，状态写到yx中去
                    foreach (DCYixing yx in yxList)
                    {
                       List<DCStatus> yxdcList = yx.dcList;
                       if (yxdcList == null)
                       {
                           yxdcList = new List<DCStatus>();
                       }
                       yxdcList.AddRange(dcList);
                       yx.dcList = yxdcList; 
                    }

                }
            }
            else
            {
                MessageBox.Show("请至少选中一个翼型");
            }
        }

        //删除选中条目
        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = this.exListView2.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.exListView2.SelectedItems[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    DCStatus zt = ztDic[ztKey];
                    gjDic.Remove(zt.gjKey);
                    znDic.Remove(zt.znKey);
                    ztDic.Remove(ztKey);

                }
                this.exListView2.Items.Remove(item);
            }
        }

        //全部清除
        private void button11_Click(object sender, EventArgs e)
        {
            this.exListView2.Items.Clear();
            //清除所有缓存数据，并将key置为0
            gjDic.Clear();
            znDic.Clear();
            ztDic.Clear();
            ztkey = 0;
            znkey = 0;
            gjkey = 0;
        }

        //添加一跳记录到ListView2
        private void addToList(DCStatus dc, int key)
        {
            float mahe; float dyj; float dslxs;
            mahe = dc.mahe;
            dyj = dc.dyj;
            dslxs = dc.dslxs;
            EXListViewItem item = new EXListViewItem(mahe.ToString());

            //CheckBox c = new CheckBox();
            //c.Checked = true;
            //EXControlListViewSubItem exc = new EXControlListViewSubItem();
            //item.SubItems.Add(exc);
            //this.exListView2.AddControlToSubItem(c, exc);

            if (dyj > 0)
            {
                item.SubItems.Add(dyj.ToString());
            }
            else
            {
                item.SubItems.Add(dslxs.ToString());
            }

            item.SubItems.Add(dc.lsgs.ToString());

            if (dc.dlmx != 0f)
            {
                item.SubItems.Add(dc.dlmx.ToString());
            }
            else
            {
                item.SubItems.Add("无");
            }

            //处理转涅相关参数
            int znkey = dc.znKey;

            if (znkey != 0)
            {
                item.SubItems.Add("是");
            }
            else
            {
                item.SubItems.Add("否");
            }

            //处理高级相关参数
            int gjkey = dc.gjKey;

            if (gjkey != 0)
            {
                DCGaoji gj = gjDic[gjkey];
                item.SubItems.Add(gj.cfl.ToString());
                if (gj.xzs != 0)
                    item.SubItems.Add(gj.xzs.ToString());
                else
                    item.SubItems.Add("无");
            }
            else
            {
                item.SubItems.Add("无");
                item.SubItems.Add("无");
            }
            //使用tag来保存对应的高级和转涅的配置
            item.Tag = key;
            this.exListView2.Items.Add(item);
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            List<int> ztkeyList = new List<int>();
            for (int i =0;i< this.exListView2.Items.Count; i++)
            {
                ListViewItem item = this.exListView2.Items[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    ztkeyList.Add(ztKey);
                }
            }

            if (ztkeyList.Count > 0)
            {
                AddStatus add = new AddStatus(ztkeyList, ztDic, znDic, gjDic);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    this.exListView2.Items.Clear();

                    foreach (int ztKey in ztDic.Keys)
                    {
                        DCStatus dcs = ztDic[ztKey];
                        this.addToList(dcs, ztKey);
                    }
                }
            }
            else
            {
                MessageBox.Show("你必须至少选中一项进行编辑！");
            }
        }

        private void exListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //更改颜色。
            foreach (EXListViewItem i in this.exListView1.Items)
            {
                i.BackColor = Color.White;
            }          
            this.exListView1.SelectedItems[0].BackColor = Color.DodgerBlue;
            //更改颜色

            int count = this.exListView1.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = this.exListView1.SelectedItems[0];
                String yxkey = item.Tag.ToString();
                int key = 0;
                int.TryParse(yxkey, out key);
                if (int.TryParse(yxkey, out key) && key != 0)
                {
                    //若存在，先将listview清空，再考虑添加的问题
                    this.exListView2.Items.Clear();
                    DCYixing yx = yxDic[key];
                    List<DCStatus> dcList = yx.dcList;
                    if (dcList != null)
                    {
                        foreach (DCStatus dcs in dcList)
                        {
                            this.addToList(dcs, dcs.key);
                        }
                    }
                }
            }
        }
    }
}
