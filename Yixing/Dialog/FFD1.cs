using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.UserTool;
using Yixing.model;

namespace Yixing.Dialog
{
    public partial class FFD1 : Form
    {
        public FFD1()
        {
            InitializeComponent();
        }

        public FFD1(InitialAirfoilModel i)
        {
            this.initialAirforlModel = i;
            InitializeComponent();
        }

        private void FFD_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("序号",100);
            this.exListView1.Columns.Add("X", 100);

            this.exListView2.Columns.Add("序号", 100);
            this.exListView2.Columns.Add("X", 100);

            Series lineSeries = new Series();
            lineSeries.ChartType = SeriesChartType.Line;
            lineSeries.Name = "line";
            double[] XList = this.initialAirforlModel.XList;
            double[] YList = this.initialAirforlModel.YList;
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
            //this.addPoint(series);
            this.addItem(this.exListView1, this.textBox2, upMax + 0.005);

            this.addItem(this.exListView2, this.textBox3, downMax - 0.005);

            this.chart1.Series.Add(series);
        }

        private void addPoint(Series series)
        {
            series.Points.Clear();
            try
            {
                int count = 12;
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

        private DataPoint addPoint(double x, double y, Series series)
        {
            x = double.Parse(String.Format("{0:#0.000}", x));
            y = double.Parse(String.Format("{0:#0.000}", y));
            if (x == 0 || x == 1)
            {
                DataPoint point = new DataPoint(x, y);
                point.MarkerColor = Color.Red;
                series.Points.Add(point);
                return point;
            }
       
            DataPoint point1 = new DataPoint(x, y);
            //point1.Tag = this.addItem(x, y); 
            point1.MarkerColor = Color.Red;
            series.Points.Add(point1);
            return point1;
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
                this.chart1.Cursor = Cursors.Hand;
            }
        }

        private void clean()
        {
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
                this.chart1.Cursor = Cursors.Hand;
            }
        }

        private void addItem(EXListView ex, TextBox text,double y)
        {
            String upNumberStr = text.Text;
            for (int i = 0; i < ex.Items.Count; i++)
            {
                ListViewItem item = ex.Items[i];
                this.series.Points.Remove((DataPoint)item.Tag);
            }

            ex.Items.Clear();
            try
            {
                int upNumber = Int32.Parse(upNumberStr);
                for (int i = 0; i < upNumber; i++)
                {
                    EXListViewItem item = new EXListViewItem((ex.Items.Count + 1).ToString());
                    TextBox t = new TextBox();
                    EXControlListViewSubItem exc = new EXControlListViewSubItem();
                    double value = 1.0 / (upNumber + 1) * (i + 1);
                    t.Text = string.Format("{0:#0.0000}", value);
                    exc.Tag = t;
                    item.SubItems.Add(exc);
                    ex.AddControlToSubItem(t, exc);
                    item.Tag = this.addPoint(value, y, this.series);
                    ex.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("请输入数字." + exception.Message);
            }
        }

        private EXListViewItem addItem(double x,double y)
        {
            EXListViewItem item;
            //CheckBox c = new CheckBox();
            //EXControlListViewSubItem exc = new EXControlListViewSubItem();
            //item.SubItems.Add(exc);
            //this.exListView1.AddControlToSubItem(c, exc);  if (y >= 0.02)
            if(y>=0.02)
            {
                item = new EXListViewItem((this.exListView1.Items.Count + 1).ToString());
                TextBox c = new TextBox();
                c.Text = x+"";
                EXControlListViewSubItem exc = new EXControlListViewSubItem();
                item.SubItems.Add(exc);
                this.exListView1.AddControlToSubItem(c, exc); 
                item.SubItems.Add(y + "");
                this.exListView1.Items.Add(item);
            }
            else
            {
                item = new EXListViewItem((this.exListView2.Items.Count + 1).ToString());
                item.SubItems.Add(x + "");
                item.SubItems.Add(y + "");
                this.exListView2.Items.Add(item);
            }
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
            count = this.exListView1.Items.Count + this.exListView2.Items.Count;
            upCount = this.exListView1.Items.Count;
            downCount = this.exListView2.Items.Count;
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
            //this.addPoint(this.chart1.Series["Default"], this.textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.addItem(this.exListView1, this.textBox2, upMax + 0.005);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.addItem(this.exListView2, this.textBox3, downMax - 0.005);
        }
    }
}
