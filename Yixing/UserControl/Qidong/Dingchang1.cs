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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private Yixing.UserTool.EXListView exListView2;
        private System.Windows.Forms.Button button3;
        private Panel panel4;
        private OpenFileDialog openFileDialog1;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button7;
        private TextBox textBox9;
        private Label label10;
        private GroupBox panel7;
        private EXListView exListView1;
        private Label label11;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox11;
        private Label label12;
        private Button button16;
        private Panel panel5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panel6;
        private RadioButton radioButton6;
        private Panel panel8;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox8;
        private RadioButton radioButton5;
        private Button button2;
        private Label label9;
        private Label label8;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private TextBox textBox2;
        private Label label4;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private Panel panel9;
        private System.Windows.Forms.Panel panel1;

        Boolean isznOpened = false;
        Boolean isgjOpened = false;
        int znkey = 0;
        int gjkey = 0;
        int ztkey = 0;
        //记录单独状态的DIC 包括高级和转涅
        Dictionary<int, DCStatus> ztDic = new Dictionary<int, DCStatus>();
        //记录单独转涅的DIC 包括高级和转涅
        Dictionary<int, DCZhuannie> znDic = new Dictionary<int, DCZhuannie>();
        //记录单独高级的DIC 包括高级和转涅
        Dictionary<int, DCGaoji> gjDic = new Dictionary<int, DCGaoji>();
    
        public Dingchang1()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dingchang1));
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button16 = new System.Windows.Forms.Button();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 576);
            this.panel1.TabIndex = 3;
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
            this.button3.Location = new System.Drawing.Point(371, 541);
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
            this.panel3.Size = new System.Drawing.Size(467, 471);
            this.panel3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.exListView2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 465);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加状态";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.radioButton4);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(7, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 381);
            this.panel5.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SA",
            "kw sst"});
            this.comboBox2.Location = new System.Drawing.Point(91, 311);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(78, 20);
            this.comboBox2.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Roe",
            "Van Leer"});
            this.comboBox1.Location = new System.Drawing.Point(91, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 20);
            this.comboBox1.TabIndex = 33;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radioButton6);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.radioButton5);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(5, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 163);
            this.panel6.TabIndex = 32;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(9, 34);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 16);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.Text = "范围";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox6);
            this.panel8.Controls.Add(this.textBox5);
            this.panel8.Controls.Add(this.textBox4);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(31, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(129, 85);
            this.panel8.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(55, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(71, 21);
            this.textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(54, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 21);
            this.textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(54, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 21);
            this.textBox4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "步长";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "下限";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "上限";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(78, 21);
            this.textBox8.TabIndex = 8;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(47, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "单个";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "高级选项";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "湍流模型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "空间离散格式";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(5, 344);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "自由转捩";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 21);
            this.textBox3.TabIndex = 27;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 83);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 16);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "定迎角:";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 16);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "定升力系数";
            this.radioButton3.UseVisualStyleBackColor = true;
            
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 21);
            this.textBox2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "马赫数";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(69, 429);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "导入计算状态 ";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(296, 429);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "全部删除";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(194, 429);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 6;
            this.button10.Text = "保存计算状态";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "计算状态总数：5 个";
            // 
            // exListView2
            // 
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(242, 41);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(213, 364);
            this.exListView2.TabIndex = 4;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(195, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "删除";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加";
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
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.button16);
            this.panel7.Controls.Add(this.exListView1);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 465);
            this.panel7.TabIndex = 6;
            this.panel7.TabStop = false;
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
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(73, 426);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(151, 25);
            this.button16.TabIndex = 7;
            this.button16.Text = "显示翼型几何形状";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.show_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "计算状态的线程数";
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
            // Dingchang1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Name = "Dingchang1";
            this.Size = new System.Drawing.Size(800, 593);
            this.Load += new System.EventHandler(this.Dingchang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float mhln;
            if(!float.TryParse(this.textBox1.Text, out mhln))
            {
                MessageBox.Show("马赫雷诺数必须为数字，且必填");
                return;
            }

            //测试代码，VM文件都放置于@"..//..//template"
            foreach(int key in ztDic.Keys)
            {
                DCStatus dcs = ztDic[key];
                DCGaoji gj = gjDic[dcs.gjKey];
                DCZhuannie zn = null;
                if (dcs.znKey != 0)
                {
                    zn = znDic[dcs.znKey];
                }
                List<DCYixing> yxList = dcs.yxList;
                foreach (DCYixing yx in yxList)
                {
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
                    String yxname =yx.name.Substring(0,yx.name.IndexOf("."));
                    String mahe = string.Format("{0:0.000}", dcs.mahe);
                    mahe = mahe.Replace(".","");
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
            }
            
            QidongResult qidongResult = new QidongResult();
            qidongResult.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // this.textBox7.Text = this.selectFile();
        }

        //点击高级
        private void button2_Click(object sender, EventArgs e)
        {
            DingChangGaoji dcgj = new DingChangGaoji();
            dcgj.ShowDialog();
            isgjOpened = true;
            gjkey++;
            DCGaoji gj = new DCGaoji();
            gj.cfl = dcgj.cfl;
            gj.onedd = dcgj.onedd;
            gj.secdd = dcgj.secdd;
            gj.thirdd = dcgj.thirdd;
            gj.xzs = dcgj.xzs;
            gjDic.Add(gjkey, gj);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wanggeshezhi w = new Wanggeshezhi();
            w.ShowDialog();
        }

        private void Dingchang_Load(object sender, EventArgs e)
        {
            this.exListView2.Columns.Add("马赫数");
            this.exListView2.Columns.Add("迎角/升力系数",90);
            this.exListView2.Columns.Add("转捩");
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 25);
            this.exListView2.SmallImageList = iList;

            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.comboBox2.Text = this.comboBox2.Items[0].ToString();
          

            this.exListView1.Columns.Add("文件名",50);
            this.exListView1.Columns.Add("路径",180);
            this.exListView1.Columns.Add("添加状态",60);
            this.exListView1.SmallImageList = iList;
        }

        private void addMethodAndStatus()
        {
            float mahe=0;
            if(!float.TryParse(this.textBox2.Text,out mahe)){
                MessageBox.Show("马赫数不能为空，且必须为数字");
                return;
            }
            mahe.ToString("0:0.0000");

            String dslxs = textBox3.Text;
            String dyj = "";
            float low=0;
            float high=0;
            float step=0;
            //rd3 定升力系数 rd4 定迎角
            //rd5 单个  rd6 范围
            if (!radioButton3.Checked)
            {
                if (radioButton5.Checked)
                {
                    float dyjf;
                    dyj = textBox8.Text;
                    if (!float.TryParse(this.textBox8.Text,out dyjf))
                    {
                        MessageBox.Show("定迎角不能为空，且必须为数字");
                        return;
                    }
                    DCStatus dc = setDcStatus(mahe, dyjf, 0f);
                    ztkey++;
                    ztDic.Add(ztkey, dc);

                    this.addToList(mahe,dyjf, 0f);
                }
                else
                {
                    try
                    {
                        low = float.Parse(this.textBox5.Text);
                        high = float.Parse(this.textBox4.Text);
                        step = float.Parse(this.textBox6.Text);

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("上限，下限，步长请输入数字");
                    }
                    for (float yl = low; yl <= high; yl += step)
                    {
                        DCStatus dc = setDcStatus(mahe, yl, 0f);
                        ztkey++;
                        ztDic.Add(ztkey, dc);
                        
                        this.addToList(mahe, yl, 0f);
                    }
                }
            }
            else
            {
                float slxs;
                if (!float.TryParse(this.textBox3.Text,out slxs))
                {
                    MessageBox.Show("定升力系数不能为空，且必须为数字");
                    return;
                }
                DCStatus dc = setDcStatus(mahe,0f,slxs);
                ztkey++;
                ztDic.Add(ztkey, dc);

                this.addToList(mahe, 0f, slxs);
               
            }

            isznOpened = false;
            isgjOpened = false;
        }
        //添加一跳记录到ListView2
        private void addToList(float mahe, float dyj, float dslxs)
        {
            EXListViewItem item = new EXListViewItem(mahe.ToString());
            if (dyj > 0)
            {
                item.SubItems.Add(dyj.ToString());
            }
            else
            {
                item.SubItems.Add(dslxs.ToString());
            }
            CheckBox c = new CheckBox();
            c.Checked = this.checkBox1.Checked;
            EXControlListViewSubItem clv = new EXControlListViewSubItem();
            item.SubItems.Add(clv);
            //使用tag来保存对应的高级和转涅的配置
            item.Tag = ztkey;
            this.exListView2.AddControlToSubItem(c, clv);
            this.exListView2.Items.Add(item);
        }

        private DCStatus setDcStatus(float mahe,float dyj,float dslxs)
        {
            DCStatus dc = new DCStatus();
            dc.mahe = mahe;
            dc.dslxs = dslxs;
            dc.dyj = dyj;

            String lsgs = this.comboBox1.Text;
            if (lsgs.Equals("Roe"))
            {
                dc.lsgs = 1;
            }
            else
            {
                dc.lsgs = 0;
            }

            //这两个key用于从dic中取属性对象
            //转涅若选中才有这个key
            if (this.checkBox1.Checked && isznOpened)
            {
                dc.znKey = znkey; 
                //如果选择了转涅，这个断流模型只能选择sst 所以值为7
                dc.dlmx = 7;

            }
            else
            {
                dc.znKey = 0;
                String dlmx = this.comboBox2.Text;
                if (dlmx.Equals("SA"))
                {
                    dc.dlmx = 5;
                }
                else
                {
                    dc.dlmx = 7;
                }
            }
            if (!isgjOpened)
            {
                gjkey++;
                DCGaoji gj = new DCGaoji();
                gj.cfl = 1000;
                gj.onedd =1000;
                gj.secdd = 1000;
                gj.thirdd = 1500;
                gj.xzs = 0;
                gjDic.Add(gjkey, gj);
            }
            dc.gjKey = gjkey;
            
            List<DCYixing> yxList = new List<DCYixing>();
            //将选中的翼型读出来
            for (int i = 0; i < this.exListView1.Items.Count; i++)
            {
                //处理Item   
                ListViewItem item = exListView1.Items[i];

                DCYixing yx = new DCYixing();
                yx.name = item.SubItems[0].Text;
                yx.filePath = item.SubItems[1].Text;
                EXControlListViewSubItem sub = (EXControlListViewSubItem)item.SubItems[2];
                CheckBox ck = (CheckBox)sub.MyControl;
                if (ck.Checked)
                {
                    yxList.Add(yx);
                }
            }

            if(yxList.Count>0){
                dc.yxList = yxList;
            }else{
                MessageBox.Show("添加状态时至少选中一个 翼型文件");
            }

            return dc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.exListView1.Items.Count > 0)
            {
                this.addMethodAndStatus();
            }
            else
            {
                MessageBox.Show("请添加翼型");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
               // this.radioButton5.Checked = true;
                this.panel6.Enabled = true;
            }
            else
            {
                this.panel6.Enabled = false; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // this.textBox10.Text = this.selectFile();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                textBox8.Enabled = true;
                this.panel8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = false;
                this.panel8.Enabled = true;
            }
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
        
        //点击转涅
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            //如果不断的选中取消只会导致key增大，而不会对象增多
            if (c.Checked)
            {
                zhuannie z;
                if (isznOpened)
                {
                    DCZhuannie zn = znDic[znkey];
                    z = new zhuannie(zn.fddls,zn.wnxb);
                }
                else
                {
                    z = new zhuannie();
                }
                
                this.comboBox2.Enabled = false;
                z.ShowDialog();
                if (z.sure)
                {
                    //若是打开过并且点了确定，才算
                    isznOpened = true;
                    //先加一次在作为key来存对象
                    znkey++;
                    DCZhuannie zn = new DCZhuannie();
                    zn.fddls = z.fddls;
                    zn.wnxb = z.wnxb;
                    znDic.Add(znkey, zn);
                }
            }else {
                this.comboBox2.Enabled = true;
                //取消的时候不removed，让其存在，影响不大，且有用
                //znDic.Remove(znkey);
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
                    String fileName =CommonUtil.getFileNameByPath(yixing.filePath);
                    EXListViewItem item = new EXListViewItem(fileName);
                    item.SubItems.Add(yixing.filePath);
                    item.Tag = yixing;
                    CheckBox c = new CheckBox();
                    c.Checked = true;
                    EXControlListViewSubItem exc = new EXControlListViewSubItem();
                    item.SubItems.Add(exc);
                    this.exListView1.AddControlToSubItem(c, exc);
                    this.exListView1.Items.Add(item);
                }
            }                     
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach(EXListViewItem item in this.exListView1.Items){
                if (item.Selected)
                {
                    this.exListView1.Items.Remove(item);
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            String filePath = "";
           int index= filePath.LastIndexOf("\\");
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
       
    }
}
