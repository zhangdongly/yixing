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
    public partial class SanweiStatus : Form
    {
        public SanweiStatus()
        {
            InitializeComponent();
        }

        private void addChart(String name,String y)
        {

            //绘制在一张图中
            Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.Title = "iter";
            chartArea1.AxisY.Title = y;
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
            chart1.Size = new System.Drawing.Size(340, 300);
            chart1.TabIndex = 0;
            chart1.Text = name;
            chart1.BorderlineWidth = 2;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "数据";
            series1.ChartType = SeriesChartType.Line;

            chart1.DoubleClick += new EventHandler(this.chart_DoubleClick);

            chart1.Series.Add(series1);
            Thread th = new Thread(new ParameterizedThreadStart(addRandomPoint));
            th.IsBackground = true;
            th.Start(series1);

            this.flowLayoutPanel1.Controls.Add(chart1);
           chartList.Add(chart1);
        }

        private void BuDingchangShow_Load(object sender, EventArgs e)
        {
            this.chartList = new List<Chart>();
            String[] names = { "升力系数", "阻力系数", "力矩系数随迭代次数的变化", "升力系数", "阻力系数" };
            String[] ys = { "Cl", "Cd", "Cm", "K", "Res" };
            for (int i = 0; i < 5; i++)
            {
                this.addChart(names[i],ys[i]);
            }

            this.exListView1.Columns.Add("iter");
            this.exListView1.Columns.Add("t");
            this.exListView1.Columns.Add("cl");
            this.exListView1.Columns.Add("cd");
            this.exListView1.Columns.Add("cm");
            this.exListView1.Columns.Add("k");


            Thread th = new Thread(new ParameterizedThreadStart(this.addValue));
            th.IsBackground = true;
            th.Start(this.exListView1);

        }

        private void chart_DoubleClick(object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (chart.Tag == null)
            {
                chart.Size = new Size(680, 500);
                chart.Tag = "big";
            }
            else
            {
                chart.Tag = null;
                chart.Size = new Size(340, 300);
            }

        }

        private void addRandomPoint(Object o)
        {
            Random rd=new Random();
            Series series = (Series)o;
            for (int i = 0; i < 100; i++)
            {
                DataPoint point = new DataPoint(i + 1, Math.Sin(((double)i+1)/5)*0.4);
              //  DataPoint point = new DataPoint(i + 1,rd.Next(100));
                point.MarkerStyle = MarkerStyle.Circle;
                point.BorderWidth = 4;
                point.MarkerSize = 10;
                series.Points.Add(point);
                Thread.Sleep(1000);
            }
        }

        private void addValue(Object o)
        {
            for (int i = 0; i < 100; i++)
            {
                EXListViewItem item = new EXListViewItem((this.exListView1.Items.Count + 1).ToString());
                item.SubItems.Add("0.1");
                item.SubItems.Add("0.1");
                item.SubItems.Add("0.01");
                item.SubItems.Add("0.01");
                item.SubItems.Add("10");
                this.exListView1.Items.Add(item);
                Thread.Sleep(1000);
            }
        }

    }
}
