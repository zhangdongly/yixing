using NVelocity.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Yixing.model;
using Yixing.UserTool;
using Yixing.util;

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
               List<String> infoList=new List<String>();
               infoList.Add(fileName);
               FileUtil.write2File(path + "foilfilename.dat", infoList);
               this.processCommand("foilanalysis", path);
               JiheTexingModel j = JiheTexingModel.createByFile(path + "charcteristic.dat",fileName);           
               //读完了之后就可以删除了
               File.Delete(path + "foilfilename.dat");
               File.Delete(path + "charcteristic.dat");
               this.addFile(fileName, j);
           }
           this.reAddItem();
        }

        private void Jihetexing_Load(object sender, EventArgs e)
        {
            this.exListView1.Columns.Add("",0);
            this.exListView1.Columns.Add("数据名",100);
            this.exListView1.Columns.Add("最大厚度", 100);
            this.exListView1.Columns.Add("最大厚度位置", 150);
            this.exListView1.Columns.Add("最大弯度", 100);
            this.exListView1.Columns.Add("最大弯度位置", 150);

            this.exListView2.Columns.Add("文件路径",550);
            this.exListView2.Columns.Add("", 50);
            this.exListView2.Columns.Add("",50);

            ImageList iList = new ImageList();
            iList.ImageSize = new Size(1, 30);
            this.exListView1.SmallImageList = iList;
            this.exListView2.SmallImageList = iList;
            this.reAddItem();
          //  this.addItem("数据1");
            //this.addItem("数据2");
                     
        }

        private void reAddItem()
        {
            String[] names = { "几何外形比较", "厚度分布", "弯度分布" };
            String[] ys = { "Y","厚度", "弯度" };

            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                this.addChart(names[i], ys[i]);
            }
        }

        private void addItem(String name, JiheTexingModel j)
        {

            EXListViewItem item = new EXListViewItem();
            item.Tag = j;
            TextBox t = new TextBox();
            t.Text = name;
            EXControlListViewSubItem exc = new EXControlListViewSubItem();
            item.SubItems.Add(exc);
            this.exListView1.AddControlToSubItem(t, exc);
            item.SubItems.Add(String.Format("{0:0.0000}",j.MaxThickness));
            item.SubItems.Add(String.Format("{0:0.0000}",j.MaxThicknessLocation));
            item.SubItems.Add(String.Format("{0:0.0000}",j.Maxcamber));
            item.SubItems.Add(String.Format("{0:0.0000}",j.MaxcamberLocation));
            this.exListView1.Items.Add(item);

        }

        private void addFile(String filePath,JiheTexingModel j)
        {
            EXListViewItem item = new EXListViewItem(filePath);
            item.Tag = j;
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
            String fileName = filePath.Substring(filePath.LastIndexOf("\\")+1);
            this.addItem(fileName,j);

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
                    this.reAddItem();
                
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
            this.reAddItem();
        }

        private void addChart(String name,String y)
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
            
            chart1.Size = new System.Drawing.Size(700, 280);
            chart1.TabIndex = 0;

            chart1.Titles.Add(new Title(name));
            
            chart1.BorderlineWidth = 2;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            try
            {
                this.getSeries(y, chart1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("重复的newfoil名："+ex.Message);
            }
            this.flowLayoutPanel1.Controls.Add(chart1);
          
        }

        public void getSeries(String y,Chart c)
        {

           // List<Series> sList = new List<Series>();
            if (this.exListView2.Items.Count > 0)
            {
                foreach (EXListViewItem item in this.exListView2.Items)
                {
                    JiheTexingModel j = (JiheTexingModel)item.Tag;
                    Series series1 = new Series();
                    series1.ChartArea = "ChartArea1";
                    series1.Legend = "Legend1";
                    series1.LabelBorderWidth = 5;
                    series1.BorderWidth = 2;
                    String name = j.fileName;
                    if (item.Index < 5)
                    {
                        series1.Color = colors[item.Index];
                    }
                    int number = 1;
                    while (c.Series.IndexOf(name) >= 0)
                    {
                        name = j.fileName + number++;
                    }
                    series1.Name = name;
                    series1.ChartType = SeriesChartType.Line;
                    if ("厚度".Equals(y))
                    {
                        for (int i = 0; i < j.xList.Count; i++)
                        {
                            series1.Points.Add(new DataPoint(j.xList[i], j.thicknessList[i]));
                        }
                    }
                    else if ("弯度".Equals(y))
                    {
                        for (int i = 0; i < j.xList.Count; i++)
                        {
                            series1.Points.Add(new DataPoint(j.xList[i], j.camberList[i]));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < j.sourceXList.Count; i++)
                        {
                            series1.Points.Add(new DataPoint(j.sourceXList[i], j.sourceYList[i]));
                        }
                    }

                    c.Series.Add(series1);
                }
            }
            else
            {
                Series series1 = new Series();
              //  series1.ChartArea = "ChartArea1";
               // series1.Legend = "Legend1";
                //series1.LabelBorderWidth = 5;
                //series1.BorderWidth = 2;
                c.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                c.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                series1.ChartType = SeriesChartType.Point;
                series1.IsVisibleInLegend = false;
                series1.Points.Add(new DataPoint(0,0));
                c.Series.Add(series1);

            }

        }

        private void processCommand(String command,String path)
        {
            Process cmd = new Process();
            try
            {
                cmd.StartInfo.FileName = path+"foilanalysis.exe";
                cmd.StartInfo.Arguments = command;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.WorkingDirectory = path;
                cmd.EnableRaisingEvents = true;
                cmd.Start();              
                String info = cmd.StandardOutput.ReadToEnd();
                cmd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            foreach (EXListViewItem item in this.exListView2.Items)
            {
                if (item.Selected)
                {
                    int index = item.Index;
                    this.exListView1.Items.RemoveAt(index);
                    this.exListView2.Items.RemoveAt(index);
                }
            }
            this.reAddItem();
        }

       
    }
}
