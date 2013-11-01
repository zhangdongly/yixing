using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.model.database;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl.DataSourceOperate
{
    public class ComplexAirfoilDetail : System.Windows.Forms.UserControl
    {
       private Panel panel1;
       private Panel panel5;
       private GroupBox groupBox1;
        private Panel panel6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel7;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox2;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ImageList iList;
        public List<int> airfoilIdList;

       public ComplexAirfoilDetail()
       {
           this.InitializeComponent();
       }
     
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 568);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(6, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 269);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重点翼型详细信息";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(4, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 272);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(867, 550);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(912, 254);
            this.panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 247);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图型显示";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.chart1);
            this.panel7.Location = new System.Drawing.Point(313, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 234);
            this.panel7.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(449, 228);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(6, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 227);
            this.panel6.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "绘图";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y轴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "X轴";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ma";
            // 
            // ComplexAirfoilDetail
            // 
            this.Controls.Add(this.panel1);
            this.Name = "ComplexAirfoilDetail";
            this.Size = new System.Drawing.Size(933, 559);
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.iList = new ImageList();
            this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iList.ImageSize = new System.Drawing.Size(1, 30);
            this.iList.TransparentColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.AutoScroll = true;
            this.panel2.AutoScroll = true;
            Series series1 = new Series();
            //  series1.ChartArea = "ChartArea1";
            // series1.Legend = "Legend1";
            //series1.LabelBorderWidth = 5;
            //series1.BorderWidth = 2;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = 1;
            this.chart1.ChartAreas[0].AxisX.Name = "X";
            this.chart1.ChartAreas[0].AxisY.Name = "Y";
            series1.ChartType = SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Points.Add(new DataPoint(0, 0));

            this.chart1.Series.Add(series1);
            foreach (int airfoilId in this.airfoilIdList)
            {
                DAirfoil d = DAirfoilUtil.getFullDAirfoil(airfoilId);              
                this.initData(d);
            }
            
          

        }

       private void initData(DAirfoil dAirfoil){
           EXListView exListView = new EXListView();
           exListView.Size = new System.Drawing.Size(854, 149);
           exListView.Columns.Add("NO");
           exListView.Columns.Add("Re");
           exListView.Columns.Add("Ma");
           exListView.Columns.Add("Cl");
           exListView.Columns.Add("Cm");
           exListView.Columns.Add("Cd");
           exListView.Columns.Add("K");
           exListView.Columns.Add("空间离散格式");
           exListView.Columns.Add("湍流模型");
           exListView.Columns.Add("计算网格");
           exListView.Columns.Add("压力分布");
           exListView.Columns.Add("创建时间");
           exListView.Columns.Add("维护人");
           int i = 1;
           foreach (DCalResult dc in dAirfoil.dCalResultList)
           {
               EXListViewItem item = new EXListViewItem(""+i++);
              
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.re)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.ma)));
              // item.SubItems.Add(string.Format("{0:00.00}", Convert.ToDouble(dc.alpha)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cl)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cd)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.cm)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.k)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.scheme)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.turble)));
               item.SubItems.Add(string.Format("{0:0.000}", Convert.ToDouble(dc.grid)));
               item.SubItems.Add("压力分布");
               item.SubItems.Add(dc.gmtCreate.ToString("yyyy-MM-dd"));
               item.SubItems.Add(dc.manageUser);
               exListView.Items.Add(item);

           }
           Label l = new Label();
           l.Text = "翼型名称:" + dAirfoil.name+dAirfoil.id;
           l.Size = new System.Drawing.Size(200, 20);       
           this.flowLayoutPanel1.Controls.Add(l);
           this.flowLayoutPanel1.Controls.Add(exListView);
          
       }

       
    }
}
