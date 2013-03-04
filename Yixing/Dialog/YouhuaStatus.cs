using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class YouhuaStatus : Form
    {
        public YouhuaStatus()
        {
            InitializeComponent();
        }

        private void YouhuaStatus_Load(object sender, EventArgs e)
        {
            this.addBiao();
            this.chartList = new List<Chart>();
            for (int i = 0; i < 5; i++)
            {
                this.addChart("Chart:"+i);
            }
           
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
            iList.ImageSize = new Size(1, 32);
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

        private void addChart(String name)
        {
           
                //绘制在一张图中
                Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
                System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
                chartArea1.Name = "ChartArea1";
                chartArea1.AxisX.Title = "RunCounter";
                chartArea1.AxisY.Title = "Y";
                chartArea1.CursorX.IsUserEnabled = true;
                chartArea1.CursorX.IsUserSelectionEnabled = true;
                chartArea1.CursorY.IsUserEnabled = true;
                chartArea1.CursorY.IsUserSelectionEnabled = true;
                chart1.ChartAreas.Add(chartArea1);
                legend1.Name = "Legend1";
                //legend1.IsDockedInsideChartArea = true;
                //legend1.Alignment = System.Drawing.StringAlignment.Near;
                legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                legend1.Alignment = StringAlignment.Center;
                chart1.Legends.Add(legend1);
            //chart1.Legends.
                chart1.Location = new System.Drawing.Point(3, 3);
                chart1.Name = "chart1";
                chart1.Size = new System.Drawing.Size(330, 280);
                chart1.TabIndex = 0;
                chart1.Text =name;
                chart1.BorderlineWidth = 2;
                chart1.BorderlineColor = Color.Gray;
                chart1.BorderlineDashStyle = ChartDashStyle.Solid;

                System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                series1.ChartArea = "ChartArea1";
                series1.Legend = "Legend1";
                series1.Name = "数据" ;
                series1.ChartType = SeriesChartType.Line;

                chart1.DoubleClick += new EventHandler(this.chart_DoubleClick);

                chart1.Series.Add(series1);
                Thread th = new Thread(new ParameterizedThreadStart(addRandomPoint));
                th.IsBackground = true;
                th.Start(series1);

                this.flowLayoutPanel1.Controls.Add(chart1);
                chartList.Add(chart1);
            }

        private void chart_DoubleClick(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (chart.Tag == null)
            {
                chart.Size = new Size(500, 500);
                chart.Tag = "big";
            }
            else
            {
                chart.Tag = null;
                chart.Size = new Size(330, 280);
            }

        }

        private void addRandomPoint(Object o)
        {
            Series series=(Series)o;
            for (int i = 0; i < 100; i++)
            {
                DataPoint point = new DataPoint(i + 1, rd.Next(100));
                point.MarkerStyle = MarkerStyle.Circle;
                point.BorderWidth = 4;
                point.MarkerSize = 10;
                series.Points.Add(point);
                Thread.Sleep(1000);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Chart chart in chartList)
            {
                Size oldSize = chart.Size;
                int newWidth=(int)(oldSize.Width*1.2);
                int newHeight=(int)(oldSize.Height*1.2);
               chart.Size=new Size(newWidth,newHeight);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Chart chart in chartList)
            {
                Size oldSize = chart.Size;
                int newWidth = (int)(oldSize.Width * 0.8);
                int newHeight = (int)(oldSize.Height * 0.8);
                chart.Size = new Size(newWidth, newHeight);
            }

        }

        

       
    }
}
