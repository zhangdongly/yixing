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
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class FFD : Form
    {
        public FFD()
        {
            InitializeComponent();
        }

        private void FFD_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("序号",40);
            this.exListView1.Columns.Add("X", 60);
            this.exListView1.Columns.Add("Y",60);
            this.exListView1.Columns.Add("是否为设计变量",100);
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 25);
            this.exListView1.SmallImageList = iList;

            Series lineSeries = new Series();
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Name = "line";
            double[] XList = { 1.00000, 0.97780, 0.95111, 0.93869, 0.91913, 0.89958, 0.88002, 0.87024, 0.85069, 0.83113, 0.80668, 0.78224, 0.75779, 0.73335, 0.70890, 0.68445, 0.66001, 0.63556, 0.61112, 0.58667, 0.56223, 0.53778, 0.51334, 0.48889, 0.46445, 0.44000, 0.41556, 0.39111, 0.36666, 0.34222, 0.31777, 0.29333, 0.26888, 0.24444, 0.21999, 0.19555, 0.17110, 0.14666, 0.12221, 0.09288, 0.08310, 0.07333, 0.06355, 0.05377, 0.04497, 0.03911, 0.03519, 0.02933, 0.02248, 0.01564, 0.00977, 0.00704, 0.00489, 0.00176, 0.00078, 0.00029, 0.00000, 0.00029, 0.00078, 0.00176, 0.00489, 0.00704, 0.00978, 0.01565, 0.02249, 0.02934, 0.03520, 0.03912, 0.04498, 0.05378, 0.06356, 0.07334, 0.08312, 0.09290, 0.12223, 0.14667, 0.17112, 0.19557, 0.22001, 0.24446, 0.26890, 0.29335, 0.31779, 0.34224, 0.36668, 0.39113, 0.41557, 0.44002, 0.46446, 0.48891, 0.51335, 0.53780, 0.56224, 0.58669, 0.61113, 0.63558, 0.66002, 0.68447, 0.70891, 0.73336, 0.75780, 0.78225, 0.80669, 0.83114, 0.85069, 0.87025, 0.88003, 0.89958, 0.91914, 0.93869, 0.95111, 0.97780, 1.00000 };
            double[] YList = { 0.00252, 0.00198, 0.00358, 0.00491, 0.00747, 0.01036, 0.01336, 0.01484, 0.01771, 0.02044, 0.02367, 0.02673, 0.02964, 0.03241, 0.03504, 0.03754, 0.03988, 0.04208, 0.04413, 0.04604, 0.04781, 0.04943, 0.05092, 0.05225, 0.05343, 0.05445, 0.05533, 0.05610, 0.05679, 0.05742, 0.05800, 0.05851, 0.05889, 0.05906, 0.05893, 0.05841, 0.05739, 0.05571, 0.05322, 0.04880, 0.04687, 0.04467, 0.04213, 0.03919, 0.03614, 0.03384, 0.03217, 0.02944, 0.02585, 0.02162, 0.01715, 0.01458, 0.01216, 0.00722, 0.00475, 0.00286, 0.00000, -0.00260, -0.00408, -0.00579, -0.00862, -0.00979, -0.01091, -0.01261, -0.01401, -0.01509, -0.01587, -0.01633, -0.01696, -0.01780, -0.01864, -0.01942, -0.02016, -0.02089, -0.02299, -0.02467, -0.02626, -0.02772, -0.02900, -0.03007, -0.03092, -0.03158, -0.03208, -0.03249, -0.03284, -0.03312, -0.03333, -0.03342, -0.03337, -0.03316, -0.03279, -0.03227, -0.03161, -0.03081, -0.02988, -0.02879, -0.02757, -0.02619, -0.02467, -0.02301, -0.02122, -0.01928, -0.01718, -0.01490, -0.01292, -0.01080, -0.00971, -0.00755, -0.00555, -0.00393, -0.00318, -0.00243, -0.00251 };
            for (int i = 0; i < XList.Length; i++)
            {
                lineSeries.Points.Add(new DataPoint(XList[i],YList[i]));
                if (upMax < YList[i])
                {
                    upMax = YList[i];
                }

                if (downMax > YList[i])
                {
                    downMax = YList[i];
                }
            }
            this.chart1.Series.Add(lineSeries);
            this.addMaxPoint();
            this.addDefaultPoint();
        }

        private void addDefaultPoint()
        {
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Square;
            series.MarkerSize = 10;
            series.Color = System.Drawing.Color.Red;
            series.Name = "Default";
            this.addPoint(series, this.textBox1);
            this.chart1.Series.Add(series);
        }

        private void addPoint(Series series, TextBox t)
        {
            series.Points.Clear();
            String countStr = this.textBox1.Text;
            try
            {
                int count = Int32.Parse(countStr)/2;
                for (int i = 1; i <= count; i++)
                {

                    this.addPoint(1.0 / (count + 1) * i, upMax+0.005, series);
                    this.addPoint(1.0 / (count + 1) * i, downMax-0.005, series);
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("变量个数必须为数字. "+exception.Message);
            }
        }

        private void addMaxPoint()
        {
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.MarkerStyle = MarkerStyle.Square;
            series.MarkerSize = 10;
            series.Color = System.Drawing.Color.Red;
            series.Name = "Max";
            this.addPoint(0, upMax + 0.005, series);
            this.addPoint(1, upMax + 0.005, series);
            this.addPoint(0, downMax - 0.005, series);
            this.addPoint(1, downMax - 0.005, series);
            this.chart1.Series.Add(series);
        }

        private void addPoint(double x, double y,Series series)
        {
            x = double.Parse(String.Format("{0:#0.000}", x));
            y = double.Parse(String.Format("{0:#0.000}", y));
            EXListViewItem item = new EXListViewItem((this.exListView1.Items.Count+1).ToString());
            item.SubItems.Add(x + "");
            item.SubItems.Add(y + "");
            CheckBox c = new CheckBox();
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(c, exc);
            this.exListView1.Items.Add(item);
            DataPoint point = new DataPoint(x, y);
            point.Tag = item;
            point.MarkerColor = Color.Red;
            series.Points.Add(point);
        }

        private void addPoint(object sender, EventArgs e)
        {
           
            if (operatorType == 1)
            {
                this.clean();
                operatorType = 0;
            }
            else
            {
                this.clean();
                this.operatorType = 1;
                this.label1.Text = "当然状态：添加点...";
                this.chart1.Cursor = Cursors.Hand;

            }
        }

        private void clean()
        {
            this.label1.Text = "当前状态 ：";
            this.chart1.Cursor = Cursors.Default;          
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            if (operatorType == 2)
            {
                this.clean();
                operatorType = 0;
            }
            else
            {
                this.clean();
                operatorType = 2;
                this.chart1.Cursor = Cursors.Hand;
            }
        }

        private void deletePoint(object sender, EventArgs e)
        {
           
            if (operatorType == 3)
            {
                this.clean();
                operatorType = 0;
            }
            else
            {
                this.clean();
                operatorType = 3;
                this.label1.Text = "当前状态:删除点...";
                this.chart1.Cursor = Cursors.Hand;
            }
        }

        private void deletePointByRightMouse(object sender, EventArgs e)
        {
            DataPoint dataPoint =(DataPoint)this.delete.Tag;
            this.series.Points.Remove(dataPoint);
            // this.series.Points.RemoveAt((int)dataPoint.Tag);
            this.exListView1.Items.Remove((EXListViewItem)dataPoint.Tag);
           
        }

        private void chart1_MouseDown(object sender, MouseEventArgs e)
       {
           if (e.Button == MouseButtons.Right)
           {
               HitTestResult hitResult = chart1.HitTest(e.X, e.Y);
               if (hitResult.ChartElementType == ChartElementType.DataPoint)
               {
                   DataPoint dataPoint = (DataPoint)hitResult.Object;
                   this.delete.Tag = dataPoint;
                   this.delete.Show(this.chart1, e.X, e.Y);
               }              
           }
           else
           {

               HitTestResult hitResult = chart1.HitTest(e.X, e.Y);
               // 增加点
               if (operatorType == 1)
               {
                   double yValue = this.chart1.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
                   double xValue = this.chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                   yValue = double.Parse(String.Format("{0:#0.000}", yValue));
                   xValue = double.Parse(String.Format("{0:#0.000}", xValue));
                   //增加点
                   DataPoint point = new DataPoint(xValue, yValue);
                   point.Tag = this.addItem(xValue, yValue);
                   point.MarkerColor = Color.Red;
                   this.series.Points.Add(point);
               }
               else
               {
                   if (hitResult.ChartElementType == ChartElementType.DataPoint)
                   {
                       DataPoint dataPoint = (DataPoint)hitResult.Object;
                       if (operatorType == 3)
                       {
                           this.series.Points.Remove(dataPoint);
                           // this.series.Points.RemoveAt((int)dataPoint.Tag);
                           this.exListView1.Items.Remove((EXListViewItem)dataPoint.Tag);
                       }
                       else if (operatorType == 4)
                       {
                           if (this.selectedPointList == null)
                           {
                               selectedPointList = new List<DataPoint>();
                           }
                           if (dataPoint.MarkerColor == Color.Black)
                           {
                               dataPoint.MarkerColor = Color.Red;
                               this.selectedPointList.Remove(dataPoint);
                               EXListViewItem item = (EXListViewItem)dataPoint.Tag;
                               EXControlListViewSubItem exc = (EXControlListViewSubItem)item.SubItems[3];
                               CheckBox c = exc.MyControl as CheckBox;
                               c.Checked = false;
                           }
                           else if (dataPoint.MarkerColor == Color.Red)
                           {
                               dataPoint.MarkerColor = Color.Black;
                               this.selectedPointList.Add(dataPoint);
                               EXListViewItem item = (EXListViewItem)dataPoint.Tag;
                               EXControlListViewSubItem exc = (EXControlListViewSubItem)item.SubItems[3];
                               CheckBox c = exc.MyControl as CheckBox;
                               c.Checked = true;
                           }
                       }
                       else
                       {
                           if (!this.chart1.Series["Max"].Points.Contains(dataPoint))
                           {
                               this.selectedPoint = dataPoint;
                           }
                       }
                   }
               }
           }
        

        }

        private EXListViewItem addItem(double x,double y)
        {
            EXListViewItem item = new EXListViewItem((this.exListView1.Items.Count+1).ToString());
            item.SubItems.Add(x + "");
            item.SubItems.Add(y + "");
            CheckBox c = new CheckBox();
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(c, exc);
            this.exListView1.Items.Add(item);
            return item;
            
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedPoint == null)
            {
                return;
            }
            int coordinate = e.Y;
            if (coordinate < 0)
                coordinate = 0;
            if (coordinate > this.chart1.Size.Height - 1)
                coordinate = this.chart1.Size.Height - 1;

            // Calculate new Y value from current cursor position
            double yValue = this.chart1.ChartAreas["Default"].AxisY.PixelPositionToValue(coordinate);
            yValue = Math.Min(yValue, this.chart1.ChartAreas["Default"].AxisY.Maximum);
            yValue = Math.Max(yValue, this.chart1.ChartAreas["Default"].AxisY.Minimum);
            coordinate = Math.Max(e.X,0);
            coordinate = Math.Min(coordinate, this.chart1.Size.Width - 1);
            double xValue = this.chart1.ChartAreas["Default"].AxisX.PixelPositionToValue(coordinate);
            xValue = Math.Min(xValue, this.chart1.ChartAreas["Default"].AxisX.Maximum);
            xValue = Math.Max(xValue, this.chart1.ChartAreas["Default"].AxisX.Minimum);
            yValue = double.Parse(String.Format("{0:#0.000}", yValue));
            xValue = double.Parse(String.Format("{0:#0.000}", xValue));

            this.movePoint(this.selectedPoint, xValue, yValue);

        }
        private void movePoint(DataPoint point, double xValue, double yValue)
        {
            point.XValue = xValue;
            //现要求只动x值，y值不动，所以暂时去掉
            //this.selectedPoint.YValues[0] = yValue;
            EXListViewItem item = (EXListViewItem)point.Tag;
            item.SubItems[1].Text = xValue + "";
            // item.SubItems[2].Text = yValue+"";
            int index=this.chart1.Series["Default"].Points.IndexOf(point);
            int otherPointIndex = index % 2 == 0 ? index + 1 : index - 1;
            DataPoint otherPoint = this.chart1.Series["Default"].Points[otherPointIndex];
            otherPoint.XValue = xValue;
            item = (EXListViewItem)otherPoint.Tag;
            item.SubItems[1].Text = xValue + "";

        }

        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            this.selectedPoint = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           count= this.exListView1.Items.Count;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectPoint(object sender, EventArgs e)
        {
           
            if (operatorType == 4)
            {
                this.clean();
                operatorType = 0;
            }
            else
            {
                this.clean();
                operatorType = 4;
                this.label1.Text = "当前状态：选择点...";
                this.chart1.Cursor = Cursors.Hand;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.addPoint(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.deletePoint(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.selectPoint(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.addPoint(this.chart1.Series["Default"], this.textBox1);
        }
    }
}
