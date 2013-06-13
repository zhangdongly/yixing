using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.Dialog;
using Yixing.model;
using Yixing.model.mubiaohans;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl.Youhua
{
    class YouhuaMethod:System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserTool.EXListView exListView1;
        private Panel zhijiehetidu;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel yichuan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private GroupBox groupBox3;
        private Panel panel8;
        private Label label9;
        private Label label8;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label10;
        private Button button2;
        private Button button1;
        private EXListView exListView2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox comboBox4;
        private CheckBox checkBox1;
        private TabPage dailiModule;
        private GroupBox groupBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button4;
        private Button button3;
        private Label label16;
        private TextBox textBox11;
        private TextBox textBox10;
        private Button button5;
        private GroupBox groupBox5;
        private Label label19;
        private Label label18;
        private Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private Label label22;
        private TextBox textBox13;
        private Label label21;
        private TextBox textBox12;
        private Label label20;
        private RadioButton radioButton3;
        private ComboBox comboBox8;
        private RadioButton radioButton4;
        private EXListView exListView4;
        private EXListView exListView3;
        private EXListView exListView5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private Dictionary<int, QDTXMethodList> qdtxmethodMap;
        private Button button6;
        public Dictionary<int, Status> ztDic;
        private String yangbenPath;

        public YouhuaMethodModel youhuaMethodModel;
    
        public YouhuaMethod()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "RBF代理模型",
            "RBF代理模型",
            " a"}, -1, System.Drawing.SystemColors.MenuHighlight, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Kriging代理模型",
            "Kriging代理模型",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "BP神经网络",
            "BP神经网络",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "状态1",
            "0.02",
            "2",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "状态2",
            "0.02",
            "3",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "状态3",
            "0.04",
            "0.65"}, -1);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yichuan = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zhijiehetidu = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.dailiModule = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.exListView5 = new Yixing.UserTool.EXListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exListView4 = new Yixing.UserTool.EXListView();
            this.exListView3 = new Yixing.UserTool.EXListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.yichuan.SuspendLayout();
            this.zhijiehetidu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dailiModule.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 571);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(373, 539);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "保存";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.dailiModule);
            this.tabControl1.Location = new System.Drawing.Point(12, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "选择优化算法";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "你选择的算法：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(91, 454);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 424);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(375, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 418);
            this.panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yichuan);
            this.groupBox2.Controls.Add(this.zhijiehetidu);
            this.groupBox2.Location = new System.Drawing.Point(23, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 389);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "相关参数设置";
            // 
            // yichuan
            // 
            this.yichuan.Controls.Add(this.checkBox1);
            this.yichuan.Controls.Add(this.comboBox3);
            this.yichuan.Controls.Add(this.comboBox2);
            this.yichuan.Controls.Add(this.comboBox1);
            this.yichuan.Controls.Add(this.label12);
            this.yichuan.Controls.Add(this.label11);
            this.yichuan.Controls.Add(this.label7);
            this.yichuan.Controls.Add(this.textBox6);
            this.yichuan.Controls.Add(this.textBox5);
            this.yichuan.Controls.Add(this.textBox4);
            this.yichuan.Controls.Add(this.textBox3);
            this.yichuan.Controls.Add(this.label6);
            this.yichuan.Controls.Add(this.label5);
            this.yichuan.Controls.Add(this.label4);
            this.yichuan.Controls.Add(this.label3);
            this.yichuan.Location = new System.Drawing.Point(6, 20);
            this.yichuan.Name = "yichuan";
            this.yichuan.Size = new System.Drawing.Size(340, 363);
            this.yichuan.TabIndex = 4;
            this.yichuan.Visible = false;
            this.yichuan.Paint += new System.Windows.Forms.PaintEventHandler(this.yichuan_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(98, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "是否使用代理模型";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox3.Location = new System.Drawing.Point(113, 240);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(113, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(113, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "变异方法";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "选择策略";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "交叉方法 ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(113, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "变异概率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "交叉概率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "遗传代数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "种群规模";
            // 
            // zhijiehetidu
            // 
            this.zhijiehetidu.Controls.Add(this.textBox2);
            this.zhijiehetidu.Controls.Add(this.textBox1);
            this.zhijiehetidu.Controls.Add(this.label2);
            this.zhijiehetidu.Controls.Add(this.label1);
            this.zhijiehetidu.Location = new System.Drawing.Point(6, 20);
            this.zhijiehetidu.Name = "zhijiehetidu";
            this.zhijiehetidu.Size = new System.Drawing.Size(340, 363);
            this.zhijiehetidu.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标2权重";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标1权重";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 418);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.exListView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "算法选择";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "直接搜索算法",
            "梯度搜索算法",
            "多目标遗传算法"});
            this.comboBox4.Location = new System.Drawing.Point(97, 138);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(228, 22);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.exListView1_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "算法选择：";
            // 
            // exListView1
            // 
            this.exListView1.AutoArrange = false;
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.Location = new System.Drawing.Point(20, 20);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(334, 363);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            this.exListView1.Visible = false;
            this.exListView1.Click += new System.EventHandler(this.exListView1_DoubleClick);
            this.exListView1.DoubleClick += new System.EventHandler(this.exListView1_DoubleClick);
            // 
            // dailiModule
            // 
            this.dailiModule.Controls.Add(this.groupBox4);
            this.dailiModule.Location = new System.Drawing.Point(4, 22);
            this.dailiModule.Name = "dailiModule";
            this.dailiModule.Padding = new System.Windows.Forms.Padding(3);
            this.dailiModule.Size = new System.Drawing.Size(777, 496);
            this.dailiModule.TabIndex = 1;
            this.dailiModule.Text = "代理模型";
            this.dailiModule.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(9, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(762, 484);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "初始样本生成方法";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.comboBox8);
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Location = new System.Drawing.Point(16, 235);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 243);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.textBox13);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.textBox12);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(6, 124);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(221, 111);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "紧耦合优化参数";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 16;
            this.label22.Text = "校核比例：";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(93, 71);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(111, 21);
            this.textBox13.TabIndex = 15;
            this.textBox13.Text = "0.3";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 12);
            this.label21.TabIndex = 14;
            this.label21.Text = "更新间隔代数：";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(93, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(111, 21);
            this.textBox12.TabIndex = 13;
            this.textBox12.Text = "1";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 16;
            this.label20.Text = "优化策略：";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 16);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.Text = "自选代理模型";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "代理模型不更新",
            "紧耦合优化",
            "松耦合优化"});
            this.comboBox8.Location = new System.Drawing.Point(6, 93);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 20);
            this.comboBox8.TabIndex = 15;
            this.comboBox8.Text = "代理模型不更新";
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 16);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "默认代理模型";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "CFD计算结果";
            chartArea1.AxisY.Title = "代理模型计算结果";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(350, 248);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(406, 236);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(616, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "代理模型评估";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.exListView5);
            this.groupBox5.Controls.Add(this.exListView4);
            this.groupBox5.Controls.Add(this.exListView3);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(6, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(750, 127);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "气动特性评估方法";
            // 
            // exListView5
            // 
            this.exListView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.exListView5.ControlPadding = 4;
            this.exListView5.FullRowSelect = true;
            this.exListView5.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.exListView5.Location = new System.Drawing.Point(556, 15);
            this.exListView5.Name = "exListView5";
            this.exListView5.OwnerDraw = true;
            this.exListView5.Size = new System.Drawing.Size(149, 97);
            this.exListView5.TabIndex = 12;
            this.exListView5.UseCompatibleStateImageBehavior = false;
            this.exListView5.View = System.Windows.Forms.View.Details;
            this.exListView5.SelectedIndexChanged += new System.EventHandler(this.exListView5_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "0";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "评估方法";
            this.columnHeader7.Width = 113;
            // 
            // exListView4
            // 
            this.exListView4.ControlPadding = 4;
            this.exListView4.FullRowSelect = true;
            this.exListView4.Location = new System.Drawing.Point(355, 15);
            this.exListView4.Name = "exListView4";
            this.exListView4.OwnerDraw = true;
            this.exListView4.Size = new System.Drawing.Size(109, 97);
            this.exListView4.TabIndex = 11;
            this.exListView4.UseCompatibleStateImageBehavior = false;
            this.exListView4.View = System.Windows.Forms.View.Details;
            this.exListView4.SelectedIndexChanged += new System.EventHandler(this.exListView4_SelectedIndexChanged);
            // 
            // exListView3
            // 
            this.exListView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.exListView3.ControlPadding = 4;
            this.exListView3.FullRowSelect = true;
            this.exListView3.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.exListView3.Location = new System.Drawing.Point(76, 20);
            this.exListView3.Name = "exListView3";
            this.exListView3.OwnerDraw = true;
            this.exListView3.Size = new System.Drawing.Size(200, 97);
            this.exListView3.TabIndex = 10;
            this.exListView3.UseCompatibleStateImageBehavior = false;
            this.exListView3.View = System.Windows.Forms.View.Details;
            this.exListView3.SelectedIndexChanged += new System.EventHandler(this.exListView3_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "状态";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ma";
            this.columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "a/cl";
            this.columnHeader3.Width = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(488, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 9;
            this.label19.Text = "评估方法：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 7;
            this.label18.Text = "气动特性：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "计算状态：";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(432, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "浏览...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "样本计算";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(171, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "样本数量：";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(197, 75);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(215, 21);
            this.textBox11.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(242, 30);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(170, 21);
            this.textBox10.TabIndex = 2;
            this.textBox10.Text = "800";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "从文件中读取";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "随机生成";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "气动特性";
            this.columnHeader4.Width = 87;
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage2.CausesValidation = false;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "代理模型";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(765, 484);
            this.panel5.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Location = new System.Drawing.Point(357, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(385, 452);
            this.panel7.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Location = new System.Drawing.Point(29, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 366);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本参数";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBox9);
            this.panel8.Controls.Add(this.textBox8);
            this.panel8.Controls.Add(this.textBox7);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(19, 20);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(274, 242);
            this.panel8.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(140, 117);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(140, 77);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(140, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(22, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "每轮GA优化后的CFD校核次数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "收敛误差";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "外循环次数";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.exListView2);
            this.panel6.Location = new System.Drawing.Point(17, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 452);
            this.panel6.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "编辑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exListView2
            // 
            this.exListView2.AutoArrange = false;
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.GridLines = true;
            this.exListView2.Location = new System.Drawing.Point(20, 20);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(237, 348);
            this.exListView2.TabIndex = 1;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // YouhuaMethod
            // 
            this.Controls.Add(this.panel1);
            this.Name = "YouhuaMethod";
            this.Size = new System.Drawing.Size(800, 560);
            this.Load += new System.EventHandler(this.control_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.yichuan.ResumeLayout(false);
            this.yichuan.PerformLayout();
            this.zhijiehetidu.ResumeLayout(false);
            this.zhijiehetidu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dailiModule.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void control_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("优化算法", 100);          
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 45);
            this.exListView1.SmallImageList = iList;

            EXListViewItem item = new EXListViewItem("直接搜索算法");
            this.exListView1.Items.Add(item);
            this.exListView1.Items.Add(new EXListViewItem("梯度搜索算法"));
            this.exListView1.Items.Add(new EXListViewItem("多目标遗传算法"));
            this.exListView1.Items.Add(new EXListViewItem("代理模型方法"));

            this.exListView2.Columns.Add("",20);
            this.exListView2.Columns.Add("代理模型",150);
            this.exListView2.Columns.Add("是否使用");
            iList = new ImageList();
            iList.ImageSize = new Size(1,25);
            this.exListView2.SmallImageList = iList;
                for (int i = 1; i <= 1; i++)
                {
                    EXListViewItem elvi = new EXListViewItem(""+i);
                    if (i == 1)
                    {
                        elvi.SubItems.Add("代理模型" + i);
                        CheckBox cb = new CheckBox();
                        cb.Checked = true;
                        EXControlListViewSubItem elvs = new EXControlListViewSubItem();
                        elvi.SubItems.Add(elvs);
                        this.exListView2.AddControlToSubItem(cb, elvs);
                    }
                    this.exListView2.Items.Add(elvi);
                }
                this.comboBox4.Text = this.comboBox4.Items[0].ToString();
                this.tabControl1.Controls.Remove(this.dailiModule);
                this.exListView4.Columns.Add("",0);
                this.exListView4.Columns.Add("评估方法",100);
        }

        private void exListView1_DoubleClick(object sender, EventArgs e)
        {
           // this.tabControl1.Controls.Remove(this.tabPage2);
            // MessageBox.Show("begin");
            //EXListView item = (EXListView)sender;
           // MessageBox.Show(item.SelectedItems.Count + "");
            ComboBox c = (ComboBox)sender;
            String selectedText = c.Text;
            if (selectedText.Equals("直接搜索算法") || selectedText.Equals("梯度搜索算法"))
            {
               // MessageBox.Show("zhijietidu");
                 this.zhijiehetidu.Visible = true;
                 this.yichuan.Visible = false;
            }
           // else if (selectedText.Equals("多目标遗传算法"))
            else
            {
              //  MessageBox.Show("yichuan");
                this.zhijiehetidu.Visible = false;
                 this.yichuan.Visible = true;
             //    this.tabControl1.Controls.Add(this.tabPage2);
            }

            this.label14.Text = "你选择的算法是：" + selectedText;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daili daili = new Daili();
            daili.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daili daili = new Daili();
            daili.ShowDialog();
        }

        private void yichuan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;

            this.tabControl1.Controls.Remove(this.dailiModule);
            if (c.Checked)
            {
                if (this.qdtxmethodMap == null || this.qdtxmethodMap.Count <= 0)
                {
                    MessageBox.Show("请先进行目标函数定义");
                    c.Checked = false;
                    return;
                }
                this.addStatus();
                this.tabControl1.Controls.Add(this.dailiModule);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                this.textBox11.Enabled = true;
                this.button4.Enabled = true;
                this.textBox10.Enabled = false;
                this.button3.Enabled = false;
            }
            else
            {
                this.textBox11.Enabled = false;
                this.button4.Enabled =false;
                this.textBox10.Enabled = true;
                this.button3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox11.Text = FileDialogUtil.getSelectFileName(new OpenFileDialog());
            this.yangbenPath = this.textBox11.Text;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            String text = t.Text;
            double ds;
            if (double.TryParse(text, out ds))
            {
                if (ds < 1 || ds > 20)
                {
                    MessageBox.Show("间隔代数大于1，且小于20！");
                }
            }
            else
            {
                MessageBox.Show("间隔代数必须为数字！");
            }
           
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
            TextBox t = (TextBox)sender;
            String text = t.Text;
            double ds;
            if (double.TryParse(text, out ds))
            {
                if (ds < 0 || ds > 1)
                {
                    MessageBox.Show("校核比例大于0，且小于1！");
                }
            }
            else
            {
                MessageBox.Show("校核比例必须为数字！");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            

            if (c.Text.Equals("紧耦合优化"))
            {
                this.groupBox7.Enabled = true;
            }
            else
            {
                this.groupBox7.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = (RadioButton)sender;
            if (c.Checked)
            {
                this.comboBox8.Enabled = true;

            }
            else
            {
                this.comboBox8.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i=i+10)
            {
                this.chart1.Series[0].Points.Add(new DataPoint(i/10, i));
            }

            ListViewItem item = (ListViewItem)this.exListView5.Items[1];
            item.SubItems[0].ForeColor =  Color.Red;
        }

        public void aim2qdtx(List<Aim> aimList)
        {
            this.qdtxmethodMap = new Dictionary<int, QDTXMethodList>();
            foreach (Aim aim in aimList)
            {
                foreach (AimExpression ae in aim.expressionList)
                {
                    QDTXMethodList ql;
                    if (qdtxmethodMap.ContainsKey(ae.index))
                    {
                        ql = this.qdtxmethodMap[ae.index];
                    }
                    else
                    {
                        ql = new QDTXMethodList();
                        this.qdtxmethodMap.Add(ae.index,ql);
                    }
                    ql.statusId = ae.index;
                    QDTXMethodModel qm = new QDTXMethodModel();
                    qm.statusIndex = ae.index;
                    qm.qdtx = ae.qdtx;
                    qm.recommendpgff = 2;
                    int flag=0;
                    foreach (QDTXMethodModel tmpQM in ql.modelList)
                    {
                        if (tmpQM.qdtx == qm.qdtx)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        ql.modelList.Add(qm);
                    }

                }
            }
        }

        private void addStatus()
        {
            this.exListView3.Items.Clear();
            foreach (int key in this.qdtxmethodMap.Keys)
            {
                StatusUtil.addStatus2EXListView(this.ztDic[key], this.exListView3,key);
            }
        }

        private void exListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.exListView4.Items.Clear();
            this.exListView5.Items.Clear();
            foreach (EXListViewItem item in this.exListView3.Items)
            {
                if (item.Selected)
                {
                    int statusIndex = (int)item.Tag;
                    QDTXMethodList ql = this.qdtxmethodMap[statusIndex];
         
                    foreach (QDTXMethodModel qm in ql.modelList)
                    {
                        EXListViewItem i = new EXListViewItem(YouhuaMethodUtil.getQDTXName(qm.qdtx));
                        i.Tag = qm;
                        exListView4.Items.Add(i);
                    }
                    item.BackColor = Color.DodgerBlue;
                }
                else
                {
                    item.BackColor = Color.White; 
                }

            }
        }

        private void exListView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.exListView5.Items.Clear();
            foreach (EXListViewItem item in this.exListView4.Items)
            {
                if (item.Selected)
                {
                    item.BackColor = Color.DodgerBlue;
                    QDTXMethodModel qm = (QDTXMethodModel)item.Tag;
                    for (int i = 1; i <= 4; i++)
                    {
                        EXListViewItem it = new EXListViewItem("");
                        it.Tag = qm;
                        if (qm.pgff != 0 && qm.pgff == i)
                        {
                            EXListViewSubItem sub = new EXListViewSubItem(YouhuaMethodUtil.getDLFFName(i), Color.DodgerBlue, Color.White);
                            it.SubItems.Add(sub);
                        }
                        else if (qm.recommendpgff == i)
                        {
                            EXListViewSubItem sub = new EXListViewSubItem(YouhuaMethodUtil.getDLFFName(i), Color.Red, Color.White);
                            it.SubItems.Add(sub);
                        }
                        else 
                        {
                            it.SubItems.Add(YouhuaMethodUtil.getDLFFName(i));
                        }
                        this.exListView5.Items.Add(it);
                    }
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void exListView5_SelectedIndexChanged(object sender, EventArgs e)
        {            
            foreach (EXListViewItem item in this.exListView5.Items)
            {
                if (item.Selected)
                {
                    item.SubItems[1].BackColor = Color.DodgerBlue;
                    QDTXMethodModel qm = (QDTXMethodModel)item.Tag;
                    qm.pgff = this.exListView5.Items.IndexOf(item) + 1;
                }
                else
                {
                    item.SubItems[1].BackColor = Color.White;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String path = Yixing.Properties.Settings.Default.currentProjectFolder;
            FileStream fs = new FileStream(path + "optsetting.dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            try
            {
                sw.WriteLine("优化算法1为直接搜索算法  2为梯度搜索算法  3 为遗传算法  4为使用代理");
                int algorithmNumber = YouhuaMethodUtil.getYouhuaMethodNumber(this.comboBox4.Text, this.checkBox1);
                sw.WriteLine(algorithmNumber);
                if (algorithmNumber == 1 || algorithmNumber == 2)
                {
                    sw.WriteLine("目标1权重\t目标2权重 ");
                    sw.WriteLine(this.textBox1.Text + "\t" + this.textBox2.Text);

                }
                else
                {
                    sw.WriteLine("种群规模\t遗传代数\t交叉方法\t选择策略\t交叉概率\t变异方法\t变异概率");
                    sw.WriteLine(this.textBox3.Text + "\t" + this.textBox4.Text + "\t" + this.comboBox1.Text + "\t" + this.comboBox2.Text + "\t" +
                        this.textBox5.Text + "\t" + this.comboBox3.Text + "\t" + this.textBox6.Text);
                }

                //第四行默认为1
                sw.WriteLine("1");
                #region 代理模型的设置
                if (algorithmNumber == 4)
                {
                    sw.WriteLine("样本文件名");
                    sw.WriteLine(this.yangbenPath);
                    sw.WriteLine("代理模型设置");
                    sw.WriteLine("优化用到的气动特性参数个数");
                    List<String> qdtxmmList = YouhuaMethodUtil.getQDTXMMList(this.qdtxmethodMap);
                    sw.WriteLine(qdtxmmList.Count); //"//这个参数具体怎么算起来了，暂时还不能确定"
                    sw.WriteLine("状态\t气动特性\t代理模型");
                    foreach (String s in qdtxmmList)
                    {
                        sw.WriteLine(s);
                    }
                    if (this.radioButton3.Checked)
                    {
                        sw.WriteLine("优化策略");
                        sw.WriteLine(YouhuaMethodUtil.getYHCL(this.comboBox8.Text));
                        sw.WriteLine("代理模型间隔代数   更新比率");
                        int dai = 0;
                        int.TryParse(textBox12.Text, out dai);
                        if (dai < 1 || dai > 20)
                        {
                            throw new Exception("间隔代数为整数,且在[1,20]之间");
                        }
                        float jiaohe = 0;
                        float.TryParse(textBox13.Text, out jiaohe);
                        if (jiaohe <= 0 || jiaohe >= 1)
                        {
                            throw new Exception("校核比例为实数 (0,1) 之间");
                        }
                        sw.WriteLine(dai + "\t" + jiaohe);
                    }

                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Flush();
                sw.Flush();
                sw.Close();
                fs.Close();
            }
           MessageBox.Show("保存成功");
        }

        public YouhuaMethodModel getYouhuaMethodModel()
        {
            if (this.youhuaMethodModel == null)
            {
                this.youhuaMethodModel = new YouhuaMethodModel();
            }
            youhuaMethodModel.algorithm = this.comboBox4.Text;
            youhuaMethodModel.isUseDaili = this.checkBox1.Checked;
            youhuaMethodModel.isDefaultDailiModel = this.radioButton4.Checked;
            youhuaMethodModel.optimizingStrategy = this.comboBox8.Text;
            return this.youhuaMethodModel;
        }
      
    }

    
}
