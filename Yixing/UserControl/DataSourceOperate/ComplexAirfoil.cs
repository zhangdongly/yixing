using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl.DataSourceOperate
{
   public class ComplexAirfoil: System.Windows.Forms.UserControl
    {
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel4;
        private EXListView exListView1;
        private Panel panel3;
        private TextBox textBox1;
        private Label label5;
        private Label label1;
        private Button button1;
        private ImageList iList;
        private String SQL_PRE = "select name,remark,points_value,max_thickness,max_thickness_location,max_width,max_width_location from airfoil where ";


       public ComplexAirfoil()
       {
           this.InitializeComponent();
       }
     
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(511, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "翼型几何外形";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(532, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "最大厚度为 15% 位于 0.13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(532, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "最大厚度为 15% 位于 0.13";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chart1);
            this.panel5.Location = new System.Drawing.Point(511, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(404, 322);
            this.panel5.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
                        chartArea1.AxisX.LabelStyle.Format = "{0.00}";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(378, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 562);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查看详情";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(278, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "翼型数量：100";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按名称排序",
            "按时间排序"});
            this.comboBox1.Location = new System.Drawing.Point(6, 522);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "按名称排序";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exListView1);
            this.panel4.Location = new System.Drawing.Point(3, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(499, 442);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 47);
            this.panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "翼型名称";
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.Location = new System.Drawing.Point(3, 3);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(493, 436);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // ComplexAirfoil
            // 
            this.Controls.Add(this.panel1);
            this.Name = "ComplexAirfoil";
            this.Size = new System.Drawing.Size(924, 574);
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.iList = new ImageList();
            this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iList.ImageSize = new System.Drawing.Size(1, 30);
            this.iList.TransparentColor = System.Drawing.Color.Transparent;
            this.exListView1.SmallImageList = iList;
            this.exListView1.Columns.Add("翼型名",150);
            this.exListView1.Columns.Add("备注",250);
            this.exListView1.Columns.Add("选择",100);
            
            this.initData();

        }

       private void initData(){

           for(int i=0;i<15;i++){
               EXListViewItem item = new EXListViewItem("NASA_NIF_"+i);
               if (i % 6 == 0)
               {
                   item.SubItems.Add("NASA_NIF备注");
               }
               else
               {
                   item.SubItems.Add("");
               }

               CheckBox c = new CheckBox();
               c.Tag = item;
               EXControlListViewSubItem check = new EXControlListViewSubItem();
               item.SubItems.Add(check);
               this.exListView1.AddControlToSubItem(c, check);
               this.exListView1.Items.Add(item);
           }
       }

       private void panel1_Paint(object sender, PaintEventArgs e)
       {
                  }

       private void button1_Click(object sender, EventArgs e)
       {
           ComplexAirfoilDetail cad = new ComplexAirfoilDetail();
           cad.Show();
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
           String namePre = this.textBox1.Text;
           String SQL = SQL_PRE + " name like \"" + namePre + "%\" ;";
           DataSet ds = DataBaseUtil.GetDataSet(CommandType.Text, SQL, null);
           addData2Table(ds);
       }

       public void addData2Table(DataSet ds)
       {
           this.exListView1.Items.Clear();
           foreach (DataRow mDr in ds.Tables[0].Rows)
           {
               String name = mDr[0].ToString();
               if (String.IsNullOrWhiteSpace(name))
               {
                   name = "" + (this.exListView1.Items.Count + 1);
               }
               EXListViewItem item = new EXListViewItem(name);
               item.Tag = mDr;
               item.SubItems.Add(mDr[1].ToString());           
               CheckBox checkBox = new CheckBox();
               checkBox.Tag = item;
               checkBox.Click += new EventHandler(this.select_Click);              
               EXControlListViewSubItem check = new EXControlListViewSubItem();
               item.SubItems.Add(check);
               this.exListView1.AddControlToSubItem(checkBox, check);
               this.exListView1.Items.Add(item);

           }
       }

       private void select_Click(object sender, EventArgs e)
       {
           CheckBox c = (CheckBox)sender;
           EXListViewItem item = (EXListViewItem)c.Tag;
           DataRow mDr = (DataRow)item.Tag;
           this.label3.Text = "最大厚度为：" + mDr[5].ToString() + ",位于" + mDr[6].ToString();
           this.label4.Text = "最大弯度为：" + mDr[3].ToString() + ",位于" + mDr[4].ToString();
           String points = mDr[2].ToString();
           addPoint(points,mDr[0].ToString());
       }

       private void addPoint(String points,String name)
       {
           this.chart1.Series.Clear();
           Series s = new Series();           
           s.Name = name;
           s.ChartType = SeriesChartType.Line;
           String[] pointArray = points.Split(';');
           foreach (String pointXY in pointArray)
           {
               String []pointDeailArray = pointXY.Split(':');
               DataPoint d = new DataPoint(Convert.ToDouble(pointDeailArray[0]), Convert.ToDouble(pointDeailArray[1]));
               s.Points.Add(d);
           }
           this.chart1.Series.Add(s);
       }

       
    }
}
