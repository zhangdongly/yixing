using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.model;
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class ShowResult1 : Form
    {
        public ShowResult1()
        {
            InitializeComponent();
        }

       

        private void ShowResult_Load(object sender, EventArgs e)
        {
            this.resultModelList = new List<ResultModel>();
            this.exListView1.Columns.Add("数据名",50);
            this.exListView1.Columns.Add("文件路径",245);
            this.exListView1.Columns.Add("是否绘制",70);
            ImageList list = new ImageList();
            list.ImageSize = new Size(1, 25);
            this.exListView1.SmallImageList = list;
            this.radioButton1.Checked = true;
            this.toolStripMenuItem1.Click += new EventHandler(this.delete);
        }

        private void delete(object sender, EventArgs e)
        {
            MessageBox.Show("你选择了删除 ");
        }

        private void addChart(String x,String y)
        {
            if (this.radioButton1.Checked)
            {
                this.flowLayoutPanel1.Controls.Clear();
                Size s = new Size(175, 350);
                Panel p = new Panel();
                p.Size = s;
                this.flowLayoutPanel1.Controls.Add(p);
            }
               int count = this.flowLayoutPanel1.Controls.Count;
                //绘制在一张图中
                Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
                System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
                chartArea1.Name = "ChartArea1";
                chartArea1.AxisX.Title = x;
                chartArea1.AxisY.Title = y;
                chartArea1.CursorX.IsUserEnabled = true;
                chartArea1.CursorX.IsUserSelectionEnabled = true;
                chartArea1.CursorY.IsUserEnabled = true;
                chartArea1.CursorY.IsUserSelectionEnabled = true;
                chartArea1.BorderColor = Color.Red;
                chart1.ChartAreas.Add(chartArea1);
                legend1.Name = "Legend1";
                chart1.Legends.Add(legend1);
               
                chart1.Name = "chart1";
                chart1.Size = new System.Drawing.Size(350, 300);
                chart1.TabIndex = 0;
                chart1.Text = x+"_"+y;
                chart1.DoubleClick += new EventHandler(this.chartDoubleClick);
                foreach (EXListViewItem item in this.exListView1.Items)
                {
                    CheckBox c = (CheckBox)item.SubItems[2].Tag;
                    if (!c.Checked)
                    {
                        continue;
                    }
                    System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                    series1.ChartArea = "ChartArea1";
                    series1.Legend = "Legend1";
                    series1.Name = "翼型" + (item.Index + 1);
                    series1.ChartType = SeriesChartType.Line;
                  
                    chart1.Series.Add(series1);
                    List<double> xList = ((ResultModel)item.Tag).resultMap[x];
                    List<double> yList = ((ResultModel)item.Tag).resultMap[y];
                    for (int j = 0; j < xList.Count; j++)
                    {
                        count=item.Index;
                        DataPoint point = new DataPoint(xList[j], yList[j]);
                        point.MarkerStyle = MarkerStyle.Circle;
                        point.BorderWidth = 4;
                        point.MarkerSize = 10;
                        if (count % 5 == 0)
                        {
                             point.BorderColor = Color.Black;
                             series1.Color = Color.Black;
                        }
                        else if (count % 5 == 1)
                        {
                             point.BorderColor = Color.Red;
                             series1.Color = Color.Red;
                        }
                        else if (count % 5 == 2)
                        {
                             point.BorderColor = Color.Green;
                             series1.Color = Color.Green;
                        }
                        else if (count % 5 == 3)
                        {
                             point.BorderColor = Color.Blue;
                             series1.Color = Color.Blue;
                        }
                        else
                        {
                             point.BorderColor= Color.Purple;
                             series1.Color = Color.Purple;
                        }
                        series1.Points.Add(point);
                    }
                }
               
                this.flowLayoutPanel1.Controls.Add(chart1);
            
                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String x = comboBox4.Text;
            String y = comboBox3.Text;
            // MessageBox.Show(x+"\t"+y);
            this.addChart(x, y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            this.openFileDialog1.FileName = null;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String fileName = this.openFileDialog1.FileName;
              
                ResultModel rm = ResultModel.createResultModel(fileName);
                if (rm != null)
                {                   
                    this.resultModelList.Add(rm);
                    if (this.comboBox3.Items.Count <= 0)
                    {
                        this.comboBox3.Items.AddRange(resultModelList[0].varsArray);
                        this.comboBox4.Items.AddRange(resultModelList[0].varsArray);
                    }
                    this.addItems();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.exListView1.Items.Clear();
            for (int i = 0; i < this.resultModelList.Count; i++)
            {
                EXListViewItem item = new EXListViewItem("翼型"+(i+1));
                CheckBox c = new CheckBox();
                c.Checked = true;
                EXControlListViewSubItem ec = new EXControlListViewSubItem();
                item.SubItems.Add(ec);
                this.exListView1.AddControlToSubItem(c, ec);
                this.exListView1.Items.Add(item);
            }
        }

        public void addItems()
        {
            this.exListView1.Items.Clear();
            for (int i = 0; i < this.resultModelList.Count; i++)
            {
                EXListViewItem item = new EXListViewItem("翼型" + (i + 1));
                item.Tag = this.resultModelList[i];
               item.SubItems.Add(this.resultModelList[i].path);
                CheckBox c = new CheckBox();
                c.Checked = true;
                EXControlListViewSubItem ec = new EXControlListViewSubItem();
                ec.Tag = c;
                item.SubItems.Add(ec);            
                this.exListView1.AddControlToSubItem(c, ec);
                this.exListView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
        }

        private void chartDoubleClick(Object sender, EventArgs e)
        {
            Chart chart = (Chart)sender;
            if (chart.Tag == null)
            {
                chart.Size = new Size(700, 500);
                chart.Tag = "big";
            }
            else
            {
                chart.Size = new Size(350, 300);
                chart.Tag = null;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
