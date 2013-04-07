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
using Yixing.constant;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
        private System.Windows.Forms.ColumnHeader 转捩;
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
        private ColumnHeader flag;
        private TextBox txt_wnxb;
        private TextBox txt_fddls;
        private Label label14;
        private Label label15;

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
            this.txt_wnxb = new System.Windows.Forms.TextBox();
            this.txt_fddls = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.edit = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.mahe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsgs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.端流模型 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.转捩 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(659, 12);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 21);
            this.textBox11.TabIndex = 26;
            this.textBox11.Text = "1";
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
            this.textBox9.Text = "5";
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
            this.groupBox2.Controls.Add(this.txt_wnxb);
            this.groupBox2.Controls.Add(this.txt_fddls);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
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
            // txt_wnxb
            // 
            this.txt_wnxb.Location = new System.Drawing.Point(302, 200);
            this.txt_wnxb.Name = "txt_wnxb";
            this.txt_wnxb.Size = new System.Drawing.Size(78, 21);
            this.txt_wnxb.TabIndex = 17;
            // 
            // txt_fddls
            // 
            this.txt_fddls.Location = new System.Drawing.Point(88, 200);
            this.txt_fddls.Name = "txt_fddls";
            this.txt_fddls.Size = new System.Drawing.Size(79, 21);
            this.txt_fddls.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "涡粘性比";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "风洞湍流度";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(10, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 170);
            this.panel5.TabIndex = 13;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.LabelStyle.Format = "{0.00}";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(9, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "翼型几何形状";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(249, 156);
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
            this.flag,
            this.lsgs,
            this.端流模型,
            this.转捩,
            this.CFL,
            this.修正熵});
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(10, 229);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(436, 230);
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
            // flag
            // 
            this.flag.DisplayIndex = 7;
            this.flag.Text = "flag";
            this.flag.Width = 0;
            // 
            // lsgs
            // 
            this.lsgs.DisplayIndex = 2;
            this.lsgs.Text = "离散格式";
            this.lsgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 端流模型
            // 
            this.端流模型.DisplayIndex = 3;
            this.端流模型.Text = "端流模型";
            this.端流模型.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 转捩
            // 
            this.转捩.DisplayIndex = 4;
            this.转捩.Text = "转捩";
            this.转捩.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.转捩.Width = 52;
            // 
            // CFL
            // 
            this.CFL.DisplayIndex = 5;
            this.CFL.Text = "CFL";
            this.CFL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 修正熵
            // 
            this.修正熵.DisplayIndex = 6;
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
            this.button9.Click += new System.EventHandler(this.button9_Click);
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
            this.button10.Click += new System.EventHandler(this.button10_Click);
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
            this.exListView1.CheckBoxes = true;
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
            this.exListView1.Click += new System.EventHandler(this.exListView1_SelectedIndexChanged);
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
            this.toolStripButton6.Click += new System.EventHandler(this.edit_Click);
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
            this.groupBox2.PerformLayout();
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
            float fddls;
            float wnxb;

            if (!float.TryParse(this.txt_fddls.Text, out fddls))
            {
                MessageBox.Show("风洞湍流度必须为数字");
                return;
            }
            if (!float.TryParse(this.txt_wnxb.Text, out wnxb))
            {
                MessageBox.Show("涡粘性比必须为数字");
                return;
            }
            if (fddls <= 0 || fddls >= 0.05)
            {
                MessageBox.Show("风洞湍流度范围在0—0.05之间，请修改！");
                return;
            }
            if (wnxb <=0 || wnxb >= 100)
            {
                MessageBox.Show("风洞湍流度范围在0—100之间，请修改！");
                return;
            }

            DCZhuannie znFinally = new DCZhuannie();
            znFinally.fddls = fddls;
            znFinally.wnxb = wnxb;

            float mhln;
            if (!float.TryParse(this.textBox1.Text, out mhln))
            {
                MessageBox.Show("马赫雷诺数必须为数字，且必填");
                return;
            }

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            String lastFileFolder = Properties.Settings.Default.defaultFileFolder;
            if (!String.IsNullOrWhiteSpace(lastFileFolder))
            {
                folderDlg.SelectedPath = lastFileFolder;
            }
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.defaultFileFolder = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("你必须选中一个输出路径,否则不进行计算");
                return;
            }

            List<CalcModel> cmList = new List<CalcModel>();

            int count = this.exListView1.SelectedItems.Count;
            DCYixing yx;
            if (count > 0)
            {
                ListViewItem item = this.exListView1.SelectedItems[0];
                String yxkey = item.Tag.ToString();
                int key = 0;
                int.TryParse(yxkey, out key);
                if (int.TryParse(yxkey, out key) && key != 0)
                {
                    yx = yxDic[key];
                }
                else
                {
                    MessageBox.Show("请选中一个翼型！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选中一个翼型！");
                return;
            }

            yx.inpPath = "D:\\cfl3d.inp";
            yx.xyzPath = "D:\\cfl3d.xyz";

            //构建模版文件
            String vmpath = InpFactory.convertInp(yx.inpPath);
            vmpath = CommonUtil.getFilePathByPath(vmpath);
            //根据模版文件生成，对应的inp文件
            TemplateHelper tp = new TemplateHelper(vmpath);

            //测试代码，VM文件都放置于@"..//..//template"
            foreach (DCStatus dcs in yx.dcList)
            {
                CalcModel cm = new CalcModel();
                cm.mahe = dcs.mahe;
                cm.isZn = false;
                cm.isyj = dcs.isyj;
                cm.yj = dcs.dyj;
                //DCStatus dcs = ztDic[key];
                DCGaoji gj = gjDic[dcs.gjKey];
                DCZhuannie zn = null;
                if (dcs.znKey != 0)
                {
                    //zn = znDic[dcs.znKey];
                    zn = znFinally;
                }

                if (zn != null)
                {
                    cm.isZn = true;
                    float tke0 = dcs.mahe * dcs.mahe * zn.fddls * zn.fddls * 1.5f*1000000;
                    float tke1 = tke0 / zn.wnxb;
                    tp.Put("tke0", tke0);
                    tp.Put("tke1", tke1);
                }
                tp.Put("gj", gj);
                tp.Put("zn", zn);
                tp.Put("s", dcs);
                tp.Put("mhln", mhln);
                tp.Put("flag", true);
                if (zn == null && gj.xzs==0 && dcs.isyj)
                {
                    tp.Put("flag",false);
                }
                String yxname = yx.name.Substring(0, yx.name.IndexOf("."));
                String mahe = string.Format("{0:0.000}", dcs.mahe);
                mahe = mahe.Replace(".", "");
                String zt;
                if (dcs.isyj)
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
                cm.inpPath = a;
                cmList.Add(cm);
            }

            QidongResult qidongResult = new QidongResult(cmList, yx);
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
                DCYixing yixing = new DCYixing();
                yixing = y.yixing;
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

                   
                    yixing.name = fileName;
                    yixing.filePath = yixing.filePath;
                    yixing.key = yxkey;
                    yxDic.Add(yxkey,yixing);

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
                   int yxKey=(int)item.Tag;
                   DCYixing yixing = yxDic[yxKey];

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
                AddStatus add = new AddStatus(yxList,gjDic);
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
                        this.addToList(dcs, dcs.key);
                        dcList.Add(dcs);
                    }

                    //将添加的状态一个个写入 本类的DIC中，并改写其他key
                    foreach (int key in add.delZtkey)
                    {
                        DCStatus zt = ztDic[key];
                        gjDic.Remove(zt.gjKey);
                        znDic.Remove(zt.znKey);
                        ztDic.Remove(key);
                        int ztdicKey = zt.key;
                        DCYixing yx = zt.yx;
                        int yxkey = yx.key;
                        if (yx.key != 0)
                        {
                           List<DCStatus > ztList= yx.dcList;
                           if (ztList != null)
                           {
                               for (int j = 0; j < ztList.Count; j++)
                               {
                                   DCStatus sta=ztList[j];
                                   if (sta.key == ztdicKey)
                                   {
                                       ztList.Remove(sta);
                                   }
                              
                               }
                           }
                        }
                    }
                    if (add.delZtkey.Count>0)
                        removefromlist(add.delZtkey);

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

        private void removefromlist(List<int> removekeyList)
        {
            for (int i = this.exListView2.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.exListView2.Items[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    if (removekeyList.Contains(ztKey))
                    {
                        this.exListView2.Items.Remove(item);
                    }
                }
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
                    int ztdicKey = zt.key;
                    DCYixing yx = zt.yx;
                    int yxkey = yx.key;
                    if (yx.key != 0)
                    {
                       List<DCStatus > ztList= yx.dcList;
                       if (ztList != null)
                       {
                           for (int j = 0; j < ztList.Count; j++)
                           {
                               DCStatus sta=ztList[j];
                               if (sta.key == ztdicKey)
                               {
                                   ztList.Remove(sta);
                               }
                              
                           }
                       }
                    }
                }
                this.exListView2.Items.Remove(item);
            }
        }

        //全部清除
        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = this.exListView2.Items.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.exListView2.Items[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    DCStatus zt = ztDic[ztKey];
                    gjDic.Remove(zt.gjKey);
                    znDic.Remove(zt.znKey);
                    ztDic.Remove(ztKey);
                    int ztdicKey = zt.key;
                    DCYixing yx = zt.yx;
                    int yxkey = yx.key;
                    if (yx.key != 0)
                    {
                        List<DCStatus> ztList = yx.dcList;
                        if (ztList != null)
                        {
                            for (int j = 0; j < ztList.Count; j++)
                            {
                                DCStatus sta = ztList[j];
                                if (sta.key == ztdicKey)
                                {
                                    ztList.Remove(sta);
                                }

                            }
                        }
                    }
                }
                this.exListView2.Items.Remove(item);
            }   
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

            if (dc.isyj)
            {
                EXListViewSubItem sub = new EXListViewSubItem(dyj.ToString("0.000"));
                item.SubItems.Add(sub);
                EXListViewSubItem subflag = new EXListViewSubItem("1");
                item.SubItems.Add(subflag);
            }
            else
            {
                EXListViewSubItem sub = new EXListViewSubItem(dslxs.ToString("0.000"), Color.Red, Color.White);
                item.SubItems.Add(sub);
                EXListViewSubItem subflag = new EXListViewSubItem("2");
                item.SubItems.Add(subflag);

            }

            if (dc.lsgs == Constant.LSGS_ROE)
            {
                item.SubItems.Add("Roe");
            }
            else { item.SubItems.Add("Van Leer"); }

            if (dc.dlmx == Constant.DLMX_SA)
            {
                item.SubItems.Add("Sa");
            }
            else
            {
                item.SubItems.Add("kw sst");
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

            //排序
            this.exListView2.sort();
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

        private void showJihetu(DCYixing dcYixing)
        {
            System.Windows.Forms.DataVisualization.Charting.Series serise = this.chart1.Series[0];
            double[] XList = { 1.00000, 0.97780, 0.95111, 0.93869, 0.91913, 0.89958, 0.88002, 0.87024, 0.85069, 0.83113, 0.80668, 0.78224, 0.75779, 0.73335, 0.70890, 0.68445, 0.66001, 0.63556, 0.61112, 0.58667, 0.56223, 0.53778, 0.51334, 0.48889, 0.46445, 0.44000, 0.41556, 0.39111, 0.36666, 0.34222, 0.31777, 0.29333, 0.26888, 0.24444, 0.21999, 0.19555, 0.17110, 0.14666, 0.12221, 0.09288, 0.08310, 0.07333, 0.06355, 0.05377, 0.04497, 0.03911, 0.03519, 0.02933, 0.02248, 0.01564, 0.00977, 0.00704, 0.00489, 0.00176, 0.00078, 0.00029, 0.00000, 0.00029, 0.00078, 0.00176, 0.00489, 0.00704, 0.00978, 0.01565, 0.02249, 0.02934, 0.03520, 0.03912, 0.04498, 0.05378, 0.06356, 0.07334, 0.08312, 0.09290, 0.12223, 0.14667, 0.17112, 0.19557, 0.22001, 0.24446, 0.26890, 0.29335, 0.31779, 0.34224, 0.36668, 0.39113, 0.41557, 0.44002, 0.46446, 0.48891, 0.51335, 0.53780, 0.56224, 0.58669, 0.61113, 0.63558, 0.66002, 0.68447, 0.70891, 0.73336, 0.75780, 0.78225, 0.80669, 0.83114, 0.85069, 0.87025, 0.88003, 0.89958, 0.91914, 0.93869, 0.95111, 0.97780, 1.00000 };
            double[] YList = { 0.00252, 0.00198, 0.00358, 0.00491, 0.00747, 0.01036, 0.01336, 0.01484, 0.01771, 0.02044, 0.02367, 0.02673, 0.02964, 0.03241, 0.03504, 0.03754, 0.03988, 0.04208, 0.04413, 0.04604, 0.04781, 0.04943, 0.05092, 0.05225, 0.05343, 0.05445, 0.05533, 0.05610, 0.05679, 0.05742, 0.05800, 0.05851, 0.05889, 0.05906, 0.05893, 0.05841, 0.05739, 0.05571, 0.05322, 0.04880, 0.04687, 0.04467, 0.04213, 0.03919, 0.03614, 0.03384, 0.03217, 0.02944, 0.02585, 0.02162, 0.01715, 0.01458, 0.01216, 0.00722, 0.00475, 0.00286, 0.00000, -0.00260, -0.00408, -0.00579, -0.00862, -0.00979, -0.01091, -0.01261, -0.01401, -0.01509, -0.01587, -0.01633, -0.01696, -0.01780, -0.01864, -0.01942, -0.02016, -0.02089, -0.02299, -0.02467, -0.02626, -0.02772, -0.02900, -0.03007, -0.03092, -0.03158, -0.03208, -0.03249, -0.03284, -0.03312, -0.03333, -0.03342, -0.03337, -0.03316, -0.03279, -0.03227, -0.03161, -0.03081, -0.02988, -0.02879, -0.02757, -0.02619, -0.02467, -0.02301, -0.02122, -0.01928, -0.01718, -0.01490, -0.01292, -0.01080, -0.00971, -0.00755, -0.00555, -0.00393, -0.00318, -0.00243, -0.00251 };
            for (int i = 0; i < XList.Length; i++)
            {
                serise.Points.Add(new DataPoint(XList[i], YList[i]));
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

            //修改几何图，暂时为空
            this.showJihetu(null);

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

        //保存计算状态
        private void button10_Click(object sender, EventArgs e)
        {
            if (this.exListView2.Items.Count == 0)
            {
                MessageBox.Show("选中翼型没有状态，不进行保存！");
                return;
            }
            #region 选择输出路径
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            String lastFileFolder = Properties.Settings.Default.statusSaveFolder;
            if (!String.IsNullOrWhiteSpace(lastFileFolder))
            {
                folderDlg.SelectedPath = lastFileFolder;
            }
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.statusSaveFolder = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("你必须选中一个输出路径.");
                return;
            }
            #endregion

            List<StautsSerializeObj> serializeList = new List<StautsSerializeObj>();
            #region 循环取出需要存储的状态
            String fileName = "status.info";
            for (int i = 0; i < this.exListView2.Items.Count; i++)
            {
                ListViewItem item = this.exListView2.Items[i];
                String ztKeyStr = item.Tag.ToString();
                int ztKey;
                if (int.TryParse(ztKeyStr, out ztKey))
                {
                    DCStatus dcs = ztDic[ztKey];
                    StautsSerializeObj obj = new StautsSerializeObj();
                    obj.mahe = dcs.mahe;
                    obj.isyj = dcs.isyj;
                    obj.dyj = dcs.dyj;
                    obj.dslxs = dcs.dslxs;
                    obj.lsgs = dcs.lsgs;
                    obj.dlmx = dcs.dlmx;
                    obj.iszn = false;
                    if (dcs.znKey != 0)
                    {
                        obj.iszn = true;
                    }
                    if (dcs.gjKey != 0)
                    {
                        DCGaoji gj = gjDic[dcs.gjKey];
                        obj.cfl = gj.cfl;
                        obj.onedd = gj.onedd;
                        obj.secdd = gj.secdd;
                        obj.thirdd = gj.thirdd;
                        obj.xzs = gj.xzs;
                    }
                    serializeList.Add(obj);
                    DCYixing yx = dcs.yx;
                    fileName = yx.name.Substring(0,yx.name.IndexOf(".")) + "_stutas.info";
                }
            }
            #endregion
        
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream
            (Properties.Settings.Default.statusSaveFolder + "/" + fileName, FileMode.Create))
            {
                bf.Serialize(fs, serializeList);
            }
            MessageBox.Show("保存完成");
        }
         
        //读取文件添加状态的东西
        private void button9_Click(object sender, EventArgs e)
        {
            DCYixing yx = null;
            //将选中的翼型读出来
            int count = this.exListView1.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem item = this.exListView1.SelectedItems[0];
                String yxkey = item.Tag.ToString();
                int key = 0;
                int.TryParse(yxkey, out key);
                if (int.TryParse(yxkey, out key) && key != 0)
                {
                    yx = yxDic[key];
                }
            }
            if (yx == null)
            {
                MessageBox.Show("请选中一个翼型！");
                return;
            }

            List<DCStatus> dcList = new List<DCStatus>();
            String filePath = FileDialogUtil.getSelectFileName(this.openFileDialog1, "翼型状态(*.info)|*.info");
            BinaryFormatter bf = new BinaryFormatter();
            //用于标识是否有重复的状态
            Boolean isrepeat = false;
            using (FileStream fs = File.Open(filePath, FileMode.Open))
            {
                List<StautsSerializeObj> serializeList = (List<StautsSerializeObj>)bf.Deserialize(fs);
                #region 循环处理，转化为本类需要的对象
                foreach (StautsSerializeObj obj in serializeList)
                {
                    DCStatus dcs = new DCStatus();
                    dcs.mahe = obj.mahe;
                    dcs.isyj = obj.isyj;
                    dcs.dyj = obj.dyj;
                    dcs.dslxs = obj.dslxs ;
                    dcs.lsgs = obj.lsgs;
                    dcs.dlmx = obj.dlmx;
                    if (obj.iszn)
                    {
                        DCZhuannie zn = new DCZhuannie();
                        znkey++;
                        this.znDic.Add(znkey, zn);
                        dcs.znKey = znkey;
                    }
                    else
                    {
                        dcs.znKey = 0;
                    }

                    DCGaoji gj = new DCGaoji();
                    gj.cfl = obj.cfl;
                    gj.onedd = obj.onedd;
                    gj.secdd = obj.secdd;
                    gj.thirdd = obj.thirdd;
                    gj.xzs = obj.xzs;
                    gjkey++;
                    this.gjDic.Add(gjkey,gj);
                    dcs.gjKey = gjkey;
                    dcs.yx = yx;
                    if (isStatusExites(dcs, yx.dcList))
                    {
                        dcList.Add(dcs);
                        ztkey++;
                        ztDic.Add(ztkey, dcs);
                        this.addToList(dcs, ztkey);
                    }
                    else { isrepeat = true; }
                }
                #endregion
            }
            if (isrepeat) { MessageBox.Show("包含重复状态，重复状态将被自动忽略！"); }
            if (yx.dcList != null)
            {
                yx.dcList.AddRange(dcList);
            }
            else { yx.dcList = dcList; }
            
        }

        private Boolean isStatusExites(DCStatus dc ,List<DCStatus> statusList)
        {
            if (statusList == null || statusList.Count == 0)
            {
                return true;
            }
            //先验证当前添加的
            foreach (DCStatus olddc in statusList)
            {
                if (olddc.mahe == dc.mahe && olddc.dslxs == dc.dslxs && !dc.isyj)
                {
                    //MessageBox.Show("马赫数：" + mahe + "  定升力系数：" + dc.dslxs + " 该条状态重复，请修改定升力系数，或者定马赫数");
                    return false;
                }
                if (dc.dyj == 0)
                {
                    if (olddc.mahe == dc.mahe && olddc.dyj == dc.dyj && dc.isyj && olddc.isyj && olddc.dyj == 0)
                    {
                        return false;
                    }
                }
                else
                {
                    if (olddc.mahe == dc.mahe && olddc.dyj == dc.dyj && dc.isyj)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
