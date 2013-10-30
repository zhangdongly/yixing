using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yixing.UserControl.DataSourceOperate
{
    public partial class Mixture2Airfoil : Form
    {
        public Mixture2Airfoil()
        {
            InitializeComponent();
            this.initPic();
        }

        private void initPic()
        {
            Series series1 = new Series();
            //  series1.ChartArea = "ChartArea1";
            // series1.Legend = "Legend1";
            //series1.LabelBorderWidth = 5;
            //series1.BorderWidth = 2;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            this.chart1.ChartAreas[0].AxisX.Maximum = 1;
            series1.ChartType = SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Points.Add(new DataPoint(0, 0));
            
            this.chart1.Series.Add(series1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectAirfoil sa = new SelectAirfoil();
            sa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectAirfoil sa = new SelectAirfoil();
            sa.ShowDialog();
        }
    }
}
