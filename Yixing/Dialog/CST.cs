using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yixing.Dialog
{
    public partial class CST : Form
    {
        public CST()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int all = 0, up = 0,down=0 ;
                
                if (!String.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    up = Convert.ToInt32(textBox1.Text);
                }
                if (!String.IsNullOrWhiteSpace(this.textBox2.Text))
                {
                    down = Convert.ToInt32(textBox2.Text);
                }
                all = up + down;
                this.label3.Text = "设计变量个数："+all;
            }
            catch (Exception exception)
            {
                MessageBox.Show("设计变量请输入数字");
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.addChart("");

        }

        private void addChart(String name)
        {

            //绘制在一张图中
            Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.Title = name;
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
            chart1.Size = new System.Drawing.Size(578, 389);
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
            double[] XList = { 1.00000, 0.97780, 0.95111, 0.93869, 0.91913, 0.89958, 0.88002, 0.87024, 0.85069, 0.83113, 0.80668, 0.78224, 0.75779, 0.73335, 0.70890, 0.68445, 0.66001, 0.63556, 0.61112, 0.58667, 0.56223, 0.53778, 0.51334, 0.48889, 0.46445, 0.44000, 0.41556, 0.39111, 0.36666, 0.34222, 0.31777, 0.29333, 0.26888, 0.24444, 0.21999, 0.19555, 0.17110, 0.14666, 0.12221, 0.09288, 0.08310, 0.07333, 0.06355, 0.05377, 0.04497, 0.03911, 0.03519, 0.02933, 0.02248, 0.01564, 0.00977, 0.00704, 0.00489, 0.00176, 0.00078, 0.00029, 0.00000, 0.00029, 0.00078, 0.00176, 0.00489, 0.00704, 0.00978, 0.01565, 0.02249, 0.02934, 0.03520, 0.03912, 0.04498, 0.05378, 0.06356, 0.07334, 0.08312, 0.09290, 0.12223, 0.14667, 0.17112, 0.19557, 0.22001, 0.24446, 0.26890, 0.29335, 0.31779, 0.34224, 0.36668, 0.39113, 0.41557, 0.44002, 0.46446, 0.48891, 0.51335, 0.53780, 0.56224, 0.58669, 0.61113, 0.63558, 0.66002, 0.68447, 0.70891, 0.73336, 0.75780, 0.78225, 0.80669, 0.83114, 0.85069, 0.87025, 0.88003, 0.89958, 0.91914, 0.93869, 0.95111, 0.97780, 1.00000 };
            double[] YList = { 0.00252, 0.00198, 0.00358, 0.00491, 0.00747, 0.01036, 0.01336, 0.01484, 0.01771, 0.02044, 0.02367, 0.02673, 0.02964, 0.03241, 0.03504, 0.03754, 0.03988, 0.04208, 0.04413, 0.04604, 0.04781, 0.04943, 0.05092, 0.05225, 0.05343, 0.05445, 0.05533, 0.05610, 0.05679, 0.05742, 0.05800, 0.05851, 0.05889, 0.05906, 0.05893, 0.05841, 0.05739, 0.05571, 0.05322, 0.04880, 0.04687, 0.04467, 0.04213, 0.03919, 0.03614, 0.03384, 0.03217, 0.02944, 0.02585, 0.02162, 0.01715, 0.01458, 0.01216, 0.00722, 0.00475, 0.00286, 0.00000, -0.00260, -0.00408, -0.00579, -0.00862, -0.00979, -0.01091, -0.01261, -0.01401, -0.01509, -0.01587, -0.01633, -0.01696, -0.01780, -0.01864, -0.01942, -0.02016, -0.02089, -0.02299, -0.02467, -0.02626, -0.02772, -0.02900, -0.03007, -0.03092, -0.03158, -0.03208, -0.03249, -0.03284, -0.03312, -0.03333, -0.03342, -0.03337, -0.03316, -0.03279, -0.03227, -0.03161, -0.03081, -0.02988, -0.02879, -0.02757, -0.02619, -0.02467, -0.02301, -0.02122, -0.01928, -0.01718, -0.01490, -0.01292, -0.01080, -0.00971, -0.00755, -0.00555, -0.00393, -0.00318, -0.00243, -0.00251 };

            for (int i = 0; i < XList.Length; i++)
            {
                series1.Points.Add(new DataPoint(XList[i],YList[i]));
            }
            chart1.DoubleClick += new EventHandler(this.chart_DoubleClick);
            chart1.Series.Add(series1);

            this.flowLayoutPanel1.Controls.Add(chart1);
           
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
                chart.Size = new Size(578, 389);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int all = 0, up = 0, down = 0;

                if (!String.IsNullOrWhiteSpace(this.textBox1.Text))
                {
                    up = Convert.ToInt32(textBox1.Text);
                }
                if (!String.IsNullOrWhiteSpace(this.textBox2.Text))
                {
                    down = Convert.ToInt32(textBox2.Text);
                }
                all = up + down;
                
                this.count = all;
            }
            catch (Exception exception)
            {
                MessageBox.Show("设计变量请输入数字");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CST_Load(object sender, EventArgs e)
        {
            double[] XList = { 1.00000, 0.97780, 0.95111, 0.93869, 0.91913, 0.89958, 0.88002, 0.87024, 0.85069, 0.83113, 0.80668, 0.78224, 0.75779, 0.73335, 0.70890, 0.68445, 0.66001, 0.63556, 0.61112, 0.58667, 0.56223, 0.53778, 0.51334, 0.48889, 0.46445, 0.44000, 0.41556, 0.39111, 0.36666, 0.34222, 0.31777, 0.29333, 0.26888, 0.24444, 0.21999, 0.19555, 0.17110, 0.14666, 0.12221, 0.09288, 0.08310, 0.07333, 0.06355, 0.05377, 0.04497, 0.03911, 0.03519, 0.02933, 0.02248, 0.01564, 0.00977, 0.00704, 0.00489, 0.00176, 0.00078, 0.00029, 0.00000, 0.00029, 0.00078, 0.00176, 0.00489, 0.00704, 0.00978, 0.01565, 0.02249, 0.02934, 0.03520, 0.03912, 0.04498, 0.05378, 0.06356, 0.07334, 0.08312, 0.09290, 0.12223, 0.14667, 0.17112, 0.19557, 0.22001, 0.24446, 0.26890, 0.29335, 0.31779, 0.34224, 0.36668, 0.39113, 0.41557, 0.44002, 0.46446, 0.48891, 0.51335, 0.53780, 0.56224, 0.58669, 0.61113, 0.63558, 0.66002, 0.68447, 0.70891, 0.73336, 0.75780, 0.78225, 0.80669, 0.83114, 0.85069, 0.87025, 0.88003, 0.89958, 0.91914, 0.93869, 0.95111, 0.97780, 1.00000 };
            double[] YList = { 0.00252, 0.00198, 0.00358, 0.00491, 0.00747, 0.01036, 0.01336, 0.01484, 0.01771, 0.02044, 0.02367, 0.02673, 0.02964, 0.03241, 0.03504, 0.03754, 0.03988, 0.04208, 0.04413, 0.04604, 0.04781, 0.04943, 0.05092, 0.05225, 0.05343, 0.05445, 0.05533, 0.05610, 0.05679, 0.05742, 0.05800, 0.05851, 0.05889, 0.05906, 0.05893, 0.05841, 0.05739, 0.05571, 0.05322, 0.04880, 0.04687, 0.04467, 0.04213, 0.03919, 0.03614, 0.03384, 0.03217, 0.02944, 0.02585, 0.02162, 0.01715, 0.01458, 0.01216, 0.00722, 0.00475, 0.00286, 0.00000, -0.00260, -0.00408, -0.00579, -0.00862, -0.00979, -0.01091, -0.01261, -0.01401, -0.01509, -0.01587, -0.01633, -0.01696, -0.01780, -0.01864, -0.01942, -0.02016, -0.02089, -0.02299, -0.02467, -0.02626, -0.02772, -0.02900, -0.03007, -0.03092, -0.03158, -0.03208, -0.03249, -0.03284, -0.03312, -0.03333, -0.03342, -0.03337, -0.03316, -0.03279, -0.03227, -0.03161, -0.03081, -0.02988, -0.02879, -0.02757, -0.02619, -0.02467, -0.02301, -0.02122, -0.01928, -0.01718, -0.01490, -0.01292, -0.01080, -0.00971, -0.00755, -0.00555, -0.00393, -0.00318, -0.00243, -0.00251 };
        }

       
    }
}
