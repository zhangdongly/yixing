using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.UserControl.DataSourceOperate
{
    public partial class UpdateCamberAndThickness : Form
    {
        public UpdateCamberAndThickness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String info = FileDialogUtil.getSelectFileName(this.openFileDialog1);
            if (!String.IsNullOrWhiteSpace(info)) {
                List<String> resultList = FileUtil.readFile(info);
                xList = new List<double>();
                camberList = new List<double>();
                thicknessList = new List<double>();
                foreach(String result in resultList ){
                    //Regex hr = new Regex(@"(-?[0-9]+.?[0-9]*[Ee]{1}-[0-9]*)", RegexOptions.IgnoreCase);
                    Regex hr = new Regex(@"((-?\d+.?\d*)([Ee]{1}(-?\d+))?)", RegexOptions.IgnoreCase);
                    MatchCollection matches = hr.Matches(result.Trim());
                    if (matches.Count > 0)
                    {
                        xList.Add(Convert.ToDouble(matches[0].Groups[1].Value));
                        camberList.Add(Convert.ToDouble(matches[1].Groups[1].Value));
                        thicknessList.Add(Convert.ToDouble(matches[2].Groups[1].Value));
                    }

                }
             
                this.addChart("弯度图","camber",xList,camberList);
                this.addChart("厚度图", "thickness", xList, thicknessList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String info = FileDialogUtil.getSelectFileName(this.openFileDialog1);
            if (!String.IsNullOrWhiteSpace(info))
            {
                List<String> resultList = FileUtil.readFile(info);
                xList = new List<double>();
                yList = new List<double>();
                foreach (String result in resultList)
                {
                    //Regex hr = new Regex(@"(-?[0-9]+.?[0-9]*[Ee]{1}-[0-9]*)", RegexOptions.IgnoreCase);
                    Regex hr = new Regex(@"((-?\d+.?\d*)([Ee]{1}(-?\d+))?)", RegexOptions.IgnoreCase);
                    MatchCollection matches = hr.Matches(result.Trim());
                    if (matches.Count > 0)
                    {
                        xList.Add(Convert.ToDouble(matches[0].Groups[1].Value));
                        yList.Add(Convert.ToDouble(matches[1].Groups[1].Value));
                       
                    }

                }
           
                this.addChart("翼型图", "y", xList, yList);
               
            }
        }

        private void addChart(String name, String y,List<double> xList,List<double> yList)
        {

            //绘制在一张图中
            Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.LabelStyle.Format = "{0.0000}";
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.Maximum = 1;
            chartArea1.AxisX.Minimum = 0;
            chartArea1.AxisY.Title = y;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;

            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Alignment = StringAlignment.Center;
            chart1.Legends.Add(legend1);
            //chart1.Legends.
            chart1.Location = new System.Drawing.Point(30, 3);

            chart1.Name = name;

            chart1.Size = new System.Drawing.Size(700, 200);
            chart1.TabIndex = 0;

            chart1.Titles.Add(new Title(name));

            chart1.BorderlineWidth = 2;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;       
            this.getSeries(y, chart1,xList,yList);                     
            this.flowLayoutPanel1.Controls.Add(chart1);

        }

        public void getSeries(String y, Chart c, List<double> xList, List<double> yList)
        {
                    Series series1 = new Series();
                    series1.ChartArea = "ChartArea1";
                    series1.Legend = "Legend1";
                    series1.LabelBorderWidth = 5;
                    series1.BorderWidth = 2;    
                    series1.Name = y;
                    series1.ChartType = SeriesChartType.Line;
                  
                    for (int i = 0; i < xList.Count; i++)
                     {
                        series1.Points.Add(new DataPoint(xList[i], yList[i]));
                     }
                   c.Series.Add(series1);
            

        }
    }
}
