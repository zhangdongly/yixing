using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;
using Yixing.Dialog;
using Yixing.model;
using Yixing.model.mubiaohans;
using Yixing.util;
using System.IO;

namespace Yixing.UserControl.Youhua
{
    class Model:System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserTool.EXListView exListView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private UserTool.EXListView exListView2;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label7;
        private Label label6;
        private Button button3;
        private TextBox textBox5;
        private Label label8;
        private Button button4;
        private Label label1;
        private TextBox textBox6;
        private Label label9;
        private TextBox textBox8;
        private Label label11;
        private TextBox textBox7;
        private Label label10;
        private Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.IContainer components;
        private Button button5;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private ImageList iList ;
        public Model()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.exListView2 = new Yixing.UserTool.EXListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.iList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.exListView2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 587);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(260, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 29);
            this.panel7.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(299, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "导出优化参数";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(15, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 122);
            this.panel3.TabIndex = 3;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(387, 78);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "并行计算的翼型数量:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(108, 82);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "并行计算核数：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 66);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "翼型几何约束条件";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(384, 24);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 21);
            this.textBox5.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "最大相对厚度上限";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(638, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 21);
            this.textBox3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "惩罚系数";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "最大相对厚度下限";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "添加目标";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exListView2
            // 
            this.exListView2.ControlPadding = 4;
            this.exListView2.FullRowSelect = true;
            this.exListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView2.Location = new System.Drawing.Point(15, 186);
            this.exListView2.Name = "exListView2";
            this.exListView2.OwnerDraw = true;
            this.exListView2.Size = new System.Drawing.Size(762, 241);
            this.exListView2.TabIndex = 1;
            this.exListView2.UseCompatibleStateImageBehavior = false;
            this.exListView2.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.exListView1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 177);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(677, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(94, 28);
            this.panel6.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "升力系数";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(571, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(105, 28);
            this.panel5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "阻力系数";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(473, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 28);
            this.panel4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "力矩系数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "万";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "删除";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.exListView1.Location = new System.Drawing.Point(257, 32);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(517, 136);
            this.exListView1.SmallImageList = this.iList;
            this.exListView1.TabIndex = 1;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // iList
            // 
            this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iList.ImageSize = new System.Drawing.Size(1, 35);
            this.iList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设计状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "单位马赫雷诺数";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(101, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 21);
            this.textBox6.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "万";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "气动特性评估方法";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 21);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 12;
            this.comboBox1.Items.AddRange(new object[] {
            "定迎角",
            "定升力系数"});
            this.comboBox1.Location = new System.Drawing.Point(13, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "马赫数";
            // 
            // Model
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Model";
            this.Size = new System.Drawing.Size(800, 593);
            this.Load += new System.EventHandler(this.control_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        //用于记录添加的状态数
        Dictionary<int, Status> ztDic = new Dictionary<int, Status>();
        int ztkey = 0;

        private void control_Load(object sender, EventArgs e)
        {
            
            this.exListView1.Columns.Add("状态",115);
            this.exListView1.Columns.Add("March",50);
            this.exListView1.Columns.Add("a/cl",50);
            this.exListView1.Columns.Add("下限", 50);
            this.exListView1.Columns.Add("上限", 50);
            this.exListView1.Columns.Add("下限", 50);
            this.exListView1.Columns.Add("上限", 50);
            this.exListView1.Columns.Add("下限", 50);
            this.exListView1.Columns.Add("上限", 50);
             
          //  this.exListView1.Columns.Add("转捩");

            this.comboBox1.Text = this.comboBox1.Items[0].ToString();

            this.exListView2.Columns.Add("目标",100);
            this.exListView2.Columns.Add("", 100);
            this.exListView2.Columns.Add("表达式", 435);
            this.exListView2.Columns.Add("", 50);
            this.exListView2.Columns.Add("", 70);
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 150);
            this.exListView2.SmallImageList = iList;
            //this.addTarget();
        }

        private void addTarget()
        {
            EXListViewItem item = new EXListViewItem("目标" + (this.exListView2.Items.Count+1));
            #region
            Button up = new Button();
            up.BackgroundImage = Yixing.Properties.Resources.up;
            up.BackgroundImageLayout = ImageLayout.Center;
            up.Tag = "up";
            up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            up.FlatAppearance.BorderSize = 0;
            up.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            up.Click += new EventHandler(this.up_click);
            EXControlListViewSubItem exc2 = new EXControlListViewSubItem();
            item.SubItems.Add(exc2);
            this.exListView2.AddControlToSubItem(up, exc2);
            #endregion

            EXListView listView = new EXListView();
            listView.Tag = item;
            listView.Columns.Add("",20);
            listView.Columns.Add("状态",150);
            listView.Columns.Add("",70);
            listView.Columns.Add("", 20);
            listView.Columns.Add("",80);
           // listView.Columns.Add("约束条件",140);
            listView.Columns.Add("",20);
            listView.Columns.Add("删除");
            listView.Tag = item;
           
            listView.SmallImageList = iList;
            listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            

            EXControlListViewSubItem listViewEXC = new EXControlListViewSubItem();
            item.SubItems.Add(listViewEXC);
            this.exListView2.AddControlToSubItem(listView, listViewEXC);
            
            this.addExpression(listView, item, true);
            #region 
            Button b = new Button();
            b.Text = "增加";
            b.Tag = listView;
            b.FlatAppearance.BorderColor = System.Drawing.Color.White;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;  
            b.Click += new EventHandler(this.add_Click);
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView2.AddControlToSubItem(b, exc);
            #endregion

            
            
            
            this.exListView2.Items.Add(item);
        }

        private void addExpression(EXListView inner, EXListViewItem outer, Boolean isFirst)
        {
            if (this.ztDic.Count == 0)
            {
                MessageBox.Show("添加目标时，必须有已定义的状态！");
                return;
            }
             EXListViewItem item ;
             if (isFirst)
             {
                 item = new EXListViewItem("=");
             }
             else
             {
                 item = new EXListViewItem(" ");
             }
             item.Tag = inner;
            
            ComboBox c = new ComboBox();
            object[] obj = orzZtNmae();
            if (obj.Length > 0)
            {
                c.Items.AddRange(obj);
                c.Text = (String)obj[0];
            }
            
             EXControlListViewSubItem status = new EXControlListViewSubItem();

             item.SubItems.Add(status);
             inner.AddControlToSubItem(c, status);

             TextBox text =new TextBox();

             EXControlListViewSubItem textBox = new EXControlListViewSubItem();

             item.SubItems.Add(textBox);

             inner.AddControlToSubItem(text, textBox);

             item.SubItems.Add("X");

             ComboBox m = new ComboBox();

             m.Items.AddRange(new object[] { "cl", "cd","cm","k" });

             EXControlListViewSubItem mc = new EXControlListViewSubItem();
             item.SubItems.Add(mc);
             inner.AddControlToSubItem(m, mc);
/**
             ComboBox y = new ComboBox();
             y.Items.AddRange(new object[]{
            "无约束",
           
            "约束上限和下限",
          
            "约束上限",
            
            "约束下限"});
             y.SelectedIndexChanged += new EventHandler(this.selectChanged);
             y.Text = y.Items[0].ToString();

             EXControlListViewSubItem yueshu = new EXControlListViewSubItem();
             item.SubItems.Add(yueshu);
             inner.AddControlToSubItem(y, yueshu);
            **/
             item.SubItems.Add("");
             Button b = new Button();
             b.Text = "删除";
             b.Tag = item;
             b.Click += new EventHandler(this.del_Click);
             b.Size = new System.Drawing.Size(123, 23);
             
             EXControlListViewSubItem delete = new EXControlListViewSubItem();
             item.SubItems.Add(delete);
             inner.AddControlToSubItem(b, delete);
             inner.Items.Add(item);
             if (inner.Items.Count > 1)
             {
                 inner.Items[inner.Items.Count - 2].SubItems[6].Text = "+";
             }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.addTarget();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Texingpingu t = new Texingpingu(ztDic);
            t.ShowDialog();

        }

        private void add_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            EXListView listView =(EXListView) b.Tag;
            this.addExpression(listView, null, false);
        }

        private void up_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String tag =(String)b.Tag;
            if (tag.Equals("up"))
            {
                b.BackgroundImage = Yixing.Properties.Resources.down;
                b.Tag = "down";
            }
            else
            {
                b.Tag = "up";
                b.BackgroundImage = Yixing.Properties.Resources.up;
            }
        }

        private void selectChanged(object sender,EventArgs e){
            ComboBox com = (ComboBox)sender;
           // MessageBox.Show(com.SelectedIndex+"");
            if(String.IsNullOrWhiteSpace(com.SelectedItem.ToString())){
                com.Text=com.Items[com.SelectedIndex+1].ToString();
            }
          //  if(com.
        }

        private void del_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            EXListViewItem item = (EXListViewItem)b.Tag;
            EXListView listView = (EXListView)item.Tag;
            if (listView.Items.Count == 1)
            {
                //只有一行就直接删除这个目标吧。
                EXListViewItem outerItem = (EXListViewItem)listView.Tag;
                this.exListView2.Items.Remove(outerItem);
            }
            else if (item.SubItems[0].Text.Equals("="))
            {
                //如果是删除第一行
                listView.Items.Remove(item);
                listView.Items[0].SubItems[0].Text = "=";
            }
            else
            {
                listView.Items.Remove(item);
            }

            if (listView.Items.Count == 1)
            {
                listView.Items[0].SubItems[6].Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ma = this.textBox1.Text;
            String al = this.textBox2.Text;
            if (String.IsNullOrWhiteSpace(ma) || String.IsNullOrWhiteSpace(al))
            {
                MessageBox.Show("请输入相应值");
                return;
            }
           

            ztkey++;
            Status st = new Status();
            st.mahe =(float)Convert.ToDouble(ma);
            st.dslxs = (float)Convert.ToDouble(al);
            st.isyj = this.comboBox1.Text.Equals("定迎角"); ;
            EXListViewItem item = new EXListViewItem(st.getZtName());
            item.SubItems.Add(ma);
            if (st.isyj)
            {
                st.isyj = true;
                item.SubItems.Add(al);             
            }
            else
            {
                EXListViewSubItem sub = new EXListViewSubItem(al, Color.Red, Color.White);
                item.SubItems.Add(sub);
            }
            this.ztDic.Add(ztkey, st);
            item.Tag = ztkey;
            for (int i = 0; i < 6; i++)
            {
                TextBox t = new TextBox();
                EXControlListViewSubItem exc = new EXControlListViewSubItem();
                item.SubItems.Add(exc);
                this.exListView1.AddControlToSubItem(t,exc);
            }
            CheckBox check = new CheckBox();
            check.Checked = true;
            check.ImageAlign = ContentAlignment.MiddleCenter;
            EXControlListViewSubItem checkE = new EXControlListViewSubItem();
            //item.SubItems.Add(checkE);
            //this.exListView1.AddControlToSubItem(check, checkE);
            this.exListView1.Items.Add(item);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = this.exListView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = this.exListView2.SelectedItems[i];
                String ztKeyStr = item.Tag.ToString();
                ztDic.Remove(Convert.ToInt32(ztKeyStr));
                this.exListView2.Items.Remove(item);
            }
        }

        private object[] orzZtNmae()
        {
            object[] obj = new object[ztDic.Count];
            int i = 0;
            foreach (int ztkey in ztDic.Keys)
            {
                Status st = ztDic[ztkey];
                obj[i] = st.getZtName();
                i++;
            }
            return obj;
        }

        //获取选中的状态的序数,这个序数是zt的key 用于反查listview中 取那个上限的
        private int getindex(String exp)
        {
            object[] objs = this.orzZtNmae();
            foreach (int ztkey in ztDic.Keys)
            {
                Status st = ztDic[ztkey];
                String res = st.getZtName();
                if (res.Equals(exp))
                {
                    return ztkey;
                }
            }
            return 0;
        }
/**
        private String getZtName(Status st)
        {
            String mahe = string.Format("{0:0.000}", st.mahe);
            mahe = "m" + mahe.Replace(".", "");

            String yj = string.Format("{0:0.000}", st.dslxs);
            yj = yj.Replace(".", "");
            if (st.isyj)
            {
                yj = "a" + yj;
            }
            else
            {
                yj = "cl" + yj;
            }
           return mahe + "_" + yj;
        }
 * */

        private String getZtoutPath(Status st)
        {
            String mahe = string.Format("{0:0.000}", st.mahe);
            mahe = "m" + mahe.Replace(".", "");
/**
            String yj = string.Format("{0:0.000}", st.dslxs);
            yj = yj.Replace(".", "");
            if (st.isyj)
            {
                yj = "a" + yj;
            }
            else
            {
                yj = "cl" + yj;
            }

 * */
            String yj = null;
            if (st.isyj)
            {
                yj = "a" + string.Format("{0:00.00}", st.dslxs); ;
            }
            else
            {
                yj = "cl" + string.Format("{0:0.000}", st.dslxs); ;
            }
            yj = yj.Replace(".", "");
            return mahe + "\\" + yj;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Aim> aimList = this.getAimList();
            //根据aimList 组织templte           
            gentemplate(aimList,Yixing.Properties.Settings.Default.currentProjectFolder);
            MessageBox.Show("导出完成");

        }

        public List<Aim> getAimList()
        {
            List<Aim> aimList = new List<Aim>();
            int aimcount = this.exListView2.Items.Count;
            for (int i = 0; i < aimcount; i++)
            {
                Aim aim = new Aim();
                aim.index = i + 1;
                ListViewItem item = this.exListView2.Items[i];
                EXControlListViewSubItem subitem = (EXControlListViewSubItem)item.SubItems[1];
                Button b = (Button)subitem.MyControl;
                aim.upordown = 2;
                if (b.Tag.Equals("up"))
                {
                    aim.upordown = 2;
                }
                //表达式的listview
                EXControlListViewSubItem subitemLv = (EXControlListViewSubItem)item.SubItems[2];
                EXListView expression = (EXListView)subitemLv.MyControl;
                List<AimExpression> expressList = new List<AimExpression>();
                int expressioncount = expression.Items.Count;
                for (int j = 0; j < expressioncount; j++)
                {
                    AimExpression exp = new AimExpression();
                    ListViewItem expitem = expression.Items[j];
                    EXControlListViewSubItem subitemindex = (EXControlListViewSubItem)expitem.SubItems[1];
                    ComboBox indexc = (ComboBox)subitemindex.MyControl;
                    String ztstr = indexc.Text;
                    int index = this.getindex(ztstr);
                    exp.index = index;
                    int listview1Count = this.exListView1.Items.Count;
                    //这个是选中状态的，在lv1 中的item
                    ListViewItem lv1item = null;
                    for (int k = 0; k < listview1Count; k++)
                    {
                        lv1item = this.exListView1.Items[k];
                        int tag = (int)lv1item.Tag;
                        if (tag == index)
                            break;
                    }
                    EXControlListViewSubItem subitemqdtx = (EXControlListViewSubItem)expitem.SubItems[4];
                    ComboBox qdtxc = (ComboBox)subitemqdtx.MyControl;
                    // MessageBox.Show(qdtxc.Text);
                    EXControlListViewSubItem cldown = null;
                    EXControlListViewSubItem clup = null;
                    if (qdtxc.Text.Equals("cl")) //升力系数
                    {
                        exp.qdtx = 1;
                        if (lv1item != null)
                        {
                            cldown = (EXControlListViewSubItem)lv1item.SubItems[7];
                            clup = (EXControlListViewSubItem)lv1item.SubItems[8];
                        }
                    }
                    else if (qdtxc.Text.Equals("cd"))
                    {
                        exp.qdtx = 2;
                        if (lv1item != null)
                        {
                            cldown = (EXControlListViewSubItem)lv1item.SubItems[5];
                            clup = (EXControlListViewSubItem)lv1item.SubItems[6];
                        }
                    }
                    else if (qdtxc.Text.Equals("cm"))
                    {
                        exp.qdtx = 3;
                        if (lv1item != null)
                        {
                            cldown = (EXControlListViewSubItem)lv1item.SubItems[3];
                            clup = (EXControlListViewSubItem)lv1item.SubItems[4];
                        }
                    }
                    else
                    {
                        exp.qdtx = 4;
                        // 这个时候只能是k。但是k是没有上下限的。所以暂时没有clup和cldown
                    }
                    TextBox downtxt = cldown != null ? (TextBox)cldown.MyControl : null;
                    TextBox uptxt = clup != null ? (TextBox)clup.MyControl : null;
                    //MessageBox.Show(downtxt+"\t"+uptxt);
                    if (downtxt == null || downtxt.Text.Trim().Equals(""))
                    {
                        exp.limitdown = -10000;
                    }
                    else
                    {
                        double dowlimit = -10000;
                        double.TryParse(downtxt.Text, out dowlimit);
                        exp.limitdown = dowlimit;
                    }
                    if (uptxt == null || uptxt.Text.Trim().Equals(""))
                    {
                        exp.limitup = 10000;
                    }
                    else
                    {
                        double uplimit = 10000;
                        double.TryParse(uptxt.Text, out uplimit);
                        exp.limitup = uplimit;
                    }

                    //获取"惩罚系数"  就是X前面的那个值 
                    if (exp.limitdown == -10000 && exp.limitup == 10000)
                    {
                        exp.cfxs = 0;
                    }
                    else
                    {
                        EXControlListViewSubItem subitemcfxs = (EXControlListViewSubItem)expitem.SubItems[2];
                        TextBox cfsxTextBox = (TextBox)subitemcfxs.MyControl;
                        double cfxs;
                        double.TryParse(cfsxTextBox.Text, out cfxs);
                        exp.cfxs = cfxs;
                    }
                    expressList.Add(exp);
                }
                aim.expressionList = expressList;

                aimList.Add(aim);
            }
            return aimList;
           
        }

        private void gentemplate(List<Aim> aimList,String path){
            FileStream fs = new FileStream(path+"Objsetting.dat", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            //TemplateHelper tp = new TemplateHelper(@"./template");
            //tp.Put("ztc",this.ztDic.Count);
            sw.WriteLine("计算状态个数");
            sw.WriteLine(this.ztDic.Count);
           // tp.Put("aimc", aimList.Count);
            sw.WriteLine("目标函数个数");
            sw.WriteLine(aimList.Count);
            int ysc=0;
            //目标函数最大最小化的定义
            String upordown = "";
            //表达式定义，段
            String exp ="";
            foreach (Aim aim in aimList)
            {
                ysc += aim.expressionList.Count;
                upordown += aim.index + "\t" + aim.upordown + "\r\n";
                List<AimExpression> explist = aim.expressionList;
                if (explist != null && explist.Count > 0)
                {
                    foreach (AimExpression expression in explist)
                    {
                        exp += aim.index + "\t" + expression.index + "\t" + expression.qdtx + "\t"
                                + String.Format("{0:0.000000}", expression.limitdown) + "\t" + String.Format("{0:0.000000}", expression.limitup) + "\t" +  String.Format("{0:0.000000}",expression.cfxs) + "\r\n";
                    }
                }
            }
           
           // tp.Put("upordown",upordown);
           // tp.Put("ysc",ysc);

            String ouptlj="";
            //这个本来应该是前缀从配置中来的
            String prefix = Yixing.Properties.Settings.Default.currentProjectFolder;
            foreach (int ztkey in ztDic.Keys)
            {
                Status st = ztDic[ztkey];
                String outPath = getZtoutPath(st);
              //  MessageBox.Show(prefix);
                ouptlj += prefix + outPath + "\r\n";
            }
            //tp.Put("ouptlj", ouptlj);
            sw.WriteLine("元素个数");
            sw.WriteLine(ysc);
            sw.WriteLine("计算路径");
            sw.Write(ouptlj);
            sw.WriteLine("目标函数最大化最小化定义");
            sw.Write(upordown);
            sw.WriteLine("目标函数表达式定义，顺序为：目标序号，计算状态序号，气动特性编号，范围下限，范围上限，惩罚系数 ");
            sw.Write(exp);

            String s = this.textBox3.Text + "\t" + this.textBox5.Text+"\t"+this.textBox4.Text;
            sw.WriteLine(s);
            sw.WriteLine("计算一个状态的线程数，并行计算的状态数");
            String strxc = this.textBox7.Text + "\t" + this.textBox8.Text;
            sw.WriteLine(strxc);
            //清空缓冲区、关闭流
            fs.Flush();
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
