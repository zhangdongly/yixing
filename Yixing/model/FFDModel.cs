using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yixing.model
{
    class FFDModel:Parasetting
    {

        public List<DataPoint> upPoint { set; get; }

        public List<DataPoint> downPoint { set; get; }


        public override void write2File(String filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            sw.WriteLine("参数化方法(编号说明该：1-FFD方法，2-CST，3-HicksHenne）");
            sw.WriteLine(this.type);
            sw.WriteLine("上下表面设计变量的个数");
            sw.WriteLine(this.upCount + "\t" + this.downCount);
            sw.WriteLine("设计变量下限，上限，初值");
            foreach (ParasettingDUC duc in this.ducList)
            {
                sw.WriteLine(duc.down+"\t"+duc.up+"\t"+duc.current);
            }
            sw.WriteLine("上下表面控制点XY坐标");

            foreach (DataPoint d in this.upPoint)
            {
                sw.WriteLine(d.XValue + "\t" + d.YValues[0]);
            }

            foreach (DataPoint d in this.downPoint)
            {
                sw.WriteLine(d.XValue + "\t" + d.YValues[0]);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            return;
        }

    }
}
