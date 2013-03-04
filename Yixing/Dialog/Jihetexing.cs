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

namespace Yixing.UserControl
{
    public partial class Jihetexing : Form
    {
        public Jihetexing()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           String fileName = FileDialogUtil.getSelectFileName(this.openFileDialog1);
           if (!String.IsNullOrWhiteSpace(fileName))
           {
               this.addFile(fileName);
           }
        }

        private void Jihetexing_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("",0);
            this.exListView1.Columns.Add("数据名",100);
            this.exListView1.Columns.Add("最大厚度", 100);
            this.exListView1.Columns.Add("最大厚度位置", 150);
            this.exListView1.Columns.Add("最大宽度", 100);
            this.exListView1.Columns.Add("最大宽度位置", 150);

            this.exListView2.Columns.Add("文件路径",550);
            this.exListView2.Columns.Add("", 50);
            this.exListView2.Columns.Add("",50);

            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 30);
            this.exListView1.SmallImageList = iList;
            this.exListView2.SmallImageList = iList;

          //  this.addItem("数据1");
            //this.addItem("数据2");
            
            String[] names = { "几何外形","厚度分布","弯度分布"};
            String[] ys = { "Y", "厚度", "弯度" };
            for (int i=0;i<3;i++) 
            {
                this.addChart(names[i],ys[i]);
            }
        }

        private void addItem(String name){

            EXListViewItem item = new EXListViewItem();
            TextBox t = new TextBox();
            t.Text = name;
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(t, exc);
            item.SubItems.Add(0.09+"");
            item.SubItems.Add(0.20+"");
            item.SubItems.Add("0.01");
            item.SubItems.Add("0.25");
            this.exListView1.Items.Add(item);

        }

        private void addFile(String filePath)
        {
            EXListViewItem item = new EXListViewItem(filePath);
            Button up = new Button();
            up.Text = "上移";
            up.Tag = item;
            EXControlListViewSubItem upExc = new EXControlListViewSubItem();
            item.SubItems.Add(upExc);
            up.Click += new EventHandler(this.up);

            this.exListView2.AddControlToSubItem(up, upExc);

            Button down = new Button();
            down.Text = "下移";
            down.Tag = item;
            down.Click += new EventHandler(this.down);

            EXControlListViewSubItem downExc = new EXControlListViewSubItem();
            item.SubItems.Add(downExc);
            this.exListView2.AddControlToSubItem(down, downExc);
            this.exListView2.Items.Add(item);
            String fileName = filePath.Substring(filePath.LastIndexOf("\\"));
            this.addItem(fileName);


        }

        private void up(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            EXListViewItem item = (EXListViewItem)b.Tag;
                    int index = item.Index;
                    if (index > 0)
                    {
                        EXListViewItem tmp = item;
                        this.exListView2.Items.RemoveAt(index);
                        this.exListView2.Items.Insert(index - 1, tmp);

                        EXListViewItem tmp1 = (EXListViewItem)this.exListView1.Items[index];
                        this.exListView1.Items.RemoveAt(index);
                        this.exListView1.Items.Insert(index-1, tmp1);

                    }
                
        }

        private void down(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            EXListViewItem item = (EXListViewItem)b.Tag;
            int index = item.Index;
            if (index < this.exListView2.Items.Count-1)
            {
                EXListViewItem tmp = item;
                this.exListView2.Items.RemoveAt(index);
                this.exListView2.Items.Insert(index+1 , tmp);

                EXListViewItem tmp1 = (EXListViewItem)this.exListView1.Items[index];
                this.exListView1.Items.RemoveAt(index);
                this.exListView1.Items.Insert(index+1 , tmp1);

            }

        }

        private void addChart(String name,String y)
        {

            //绘制在一张图中
            Chart chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chartArea1.Name = "ChartArea1";

            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.Title = y;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            //legend1.IsDockedInsideChartArea = true;
            //legend1.Alignment = System.Drawing.StringAlignment.Near;
            //legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Alignment = StringAlignment.Center;
            chart1.Legends.Add(legend1);
            //chart1.Legends.
            chart1.Location = new System.Drawing.Point(3, 3);
            chart1.Name = name;
            
            chart1.Size = new System.Drawing.Size(630, 280);
            chart1.TabIndex = 0;

            chart1.Titles.Add(new Title(name));
            
            chart1.BorderlineWidth = 2;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;

            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "数据";
            series1.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 10; i++)
            {
                series1.Points.Add(new DataPoint(rd.Next(100),rd.Next(100)));
            }

            //chart1.DoubleClick += new EventHandler(this.chart_DoubleClick);

            chart1.Series.Add(series1);
           

            this.flowLayoutPanel1.Controls.Add(chart1);
          
        }
    }
}
