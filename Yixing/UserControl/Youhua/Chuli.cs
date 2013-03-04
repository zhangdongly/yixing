using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.Dialog;
using Yixing.UserTool;

namespace Yixing.UserControl.Youhua
{
    class Chuli:System.Windows.Forms.UserControl
    {
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label5;
        private Panel panel6;
        private Label label7;
        private UserTool.EXListView listView2;
        private Panel panel5;
        private Label label6;
        private UserTool.EXListView listView1;
        private UserTool.EXListView exListView1;
        private List<DataPoint> selectedDataPointList = null;
       private  Series selected;
       private Label label1;
       private Label label2;
       private  Series unSelected ;

    
        public Chuli()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.listView2 = new Yixing.UserTool.EXListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new Yixing.UserTool.EXListView();
            this.exListView1 = new Yixing.UserTool.EXListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 597);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "精英个体表";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 317);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(691, 229);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.exListView1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(688, 222);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(602, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "厚度";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.listView2);
            this.panel6.Location = new System.Drawing.Point(328, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(244, 63);
            this.panel6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ma 0.84 CL=0.0";
            // 
            // listView2
            // 
            this.listView2.AutoArrange = false;
            this.listView2.ControlPadding = 4;
            this.listView2.Enabled = false;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView2.Location = new System.Drawing.Point(-1, 31);
            this.listView2.Name = "listView2";
            this.listView2.OwnerDraw = true;
            this.listView2.Scrollable = false;
            this.listView2.Size = new System.Drawing.Size(244, 31);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Location = new System.Drawing.Point(113, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 63);
            this.panel5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ma 0.6 CL=0.6";
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.ControlPadding = 4;
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(-1, 31);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(215, 31);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // exListView1
            // 
            this.exListView1.ControlPadding = 4;
            this.exListView1.FullRowSelect = true;
            this.exListView1.GridLines = true;
            this.exListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.exListView1.Location = new System.Drawing.Point(3, 64);
            this.exListView1.Name = "exListView1";
            this.exListView1.OwnerDraw = true;
            this.exListView1.Size = new System.Drawing.Size(680, 153);
            this.exListView1.TabIndex = 0;
            this.exListView1.UseCompatibleStateImageBehavior = false;
            this.exListView1.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 308);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pareto图";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "翼型几何数据保存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "CFD评估";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "全部删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加校验点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.AllowDrop = true;
            this.chart1.BorderlineColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(238, 2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(470, 254);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // Chuli
            // 
            this.Controls.Add(this.panel1);
            this.Name = "Chuli";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Chuli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Chuli_Load(object sender, EventArgs e)
        {
             selected = new Series();
             unSelected = new Series();
            selected.ChartType = SeriesChartType.Bubble;
            unSelected.ChartType = SeriesChartType.Bubble;
            selected.MarkerStyle = MarkerStyle.Square;
           // selected.M = 2;
            unSelected.MarkerStyle = MarkerStyle.Square;

            selected.Color = System.Drawing.Color.Black ;

            unSelected.Color = System.Drawing.Color.Red;

            Random rd = new Random();
           
            unSelected.Points.Add(new DataPoint(1, 90));
            unSelected.Points.Add(new DataPoint(10, 60));
            unSelected.Points.Add(new DataPoint(20, 40));
            unSelected.Points.Add(new DataPoint(35, 20));
            unSelected.Points.Add(new DataPoint(55, 10));
            

            selected.Name = "已校验";
            unSelected.Name = "未校验";

            this.chart1.Series.Add(selected);
            this.chart1.Series.Add(unSelected);

            this.addBiao();



        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.chart1.Cursor == Cursors.Default)
            {
                return;
            }
            HitTestResult hitResult = chart1.HitTest(e.X, e.Y);
            // Initialize currently selected data point
            if (selectedDataPointList == null)
            {
                selectedDataPointList = new List<DataPoint>();
            }
            if (hitResult.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint selectedDataPoint = (DataPoint)hitResult.Object;

                if (selectedDataPoint.BorderColor == Color.Blue)
                {
                    selectedDataPoint.IsValueShownAsLabel = false;
                    selectedDataPoint.Label = null;
                    selectedDataPoint.BorderColor = Color.White;
                    selectedDataPoint.BorderWidth = 0;
                    this.selectedDataPointList.Remove(selectedDataPoint);
                }
                else
                {
                    // Show point value as label
                    selectedDataPoint.IsValueShownAsLabel = true;
                    selectedDataPoint.Label = "(" + e.X + "," + e.Y + ")";
                    selectedDataPoint.BorderColor = Color.Blue;
                    selectedDataPoint.BorderWidth = 2;
                    this.selectedDataPointList.Add(selectedDataPoint);
                }
            }


        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
          //  chart1.Cursor = Cursors.Hand;

        }

        private void addBiao()
        {
            this.listView1.Columns.Add("CL", 72);
            this.listView1.Columns.Add("Cd", 72);
            this.listView1.Columns.Add("K", 70);
            ListViewItem i1 = new ListViewItem("CL");
            i1.SubItems.Add("Cd");
            i1.SubItems.Add("K");
            this.listView1.Items.Add(i1);

            this.listView2.Columns.Add("CL", 77);
            this.listView2.Columns.Add("Cd", 77);
            this.listView2.Columns.Add("K", 88);
            ListViewItem i2 = new ListViewItem("CL");
            i2.SubItems.Add("Cd");
            i2.SubItems.Add("K");
            this.listView2.Items.Add(i2);

            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1,32);
            this.listView1.SmallImageList = iList;
            this.listView2.SmallImageList = iList;

            this.exListView1.Columns.Add("", 112, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 70, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 70, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 74, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 77, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 77, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 90, HorizontalAlignment.Center);
            this.exListView1.Columns.Add("", 110, HorizontalAlignment.Center);

            for (int i = 0; i < 10; i++)
            {
                EXListViewItem item = new EXListViewItem("第" + (i + 1) + "代");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                item.SubItems.Add(i + 1 + "");
                this.exListView1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Tag == null)
            {
                this.chart1.Cursor = Cursors.Hand;
                b.Text = "校验点选择中…";
                b.Tag = "已选择";
            }
            else
            {
                b.Tag = null;
                b.Text = "添加校验点";
                this.chart1.Cursor = Cursors.Default;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.update();
           // WanggeJiaoyan w = new WanggeJiaoyan();
           // w.ShowDialog();
            
        }

        private void update()
        {
            if (selectedDataPointList == null || selectedDataPointList.Count == 0)
            {
                return;
            }

            foreach (DataPoint dataPoint in selectedDataPointList)
            {
                dataPoint.IsValueShownAsLabel = false;
                dataPoint.Label = null;
                dataPoint.BorderColor = Color.Black;
                this.unSelected.Points.Remove(dataPoint);
                this.selected.Points.Add(dataPoint);
            }
            selectedDataPointList = null;
            this.chart1.Invalidate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataPoint selectedDataPoint in this.selectedDataPointList)
            {
                selectedDataPoint.IsValueShownAsLabel = false;
                selectedDataPoint.Label = null;
                selectedDataPoint.BorderColor = Color.White;
                selectedDataPoint.BorderWidth = 0;
               
            }
            this.selectedDataPointList = null;
        }
    }
}
