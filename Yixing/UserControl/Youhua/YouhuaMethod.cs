﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.Dialog;
using Yixing.UserTool;

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
        private System.Windows.Forms.Panel panel1;
    
        public YouhuaMethod()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yichuan = new System.Windows.Forms.Panel();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 560);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(113, 240);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 20);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
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
            this.comboBox4.Location = new System.Drawing.Point(85, 138);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(228, 22);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.exListView1_DoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 141);
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
          
            this.tabControl1.Controls.Remove(this.tabPage2);
            if (c.Checked)
            {
                this.tabControl1.Controls.Add(this.tabPage2);
            }
        }

       
       
    }
}
