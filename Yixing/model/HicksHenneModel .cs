using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class HicksHenneModel:Parasetting
    {
        public List<double> upValueList { set; get; }

        public List<double> downValueList { set; get; }

        public override void write2File(String filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            sw.WriteLine("参数化方法");
            sw.WriteLine(this.type);
            sw.WriteLine("上下表面设计变量的个数");
            sw.WriteLine(this.upCount + "\t" + this.downCount);
            sw.WriteLine("设计变量下限，上限，初值");
            foreach (ParasettingDUC duc in this.ducList)
            {
                sw.WriteLine(duc.down + "\t" + duc.up + "\t" + duc.current);
            }

            foreach (double d in this.upValueList)
            {
                sw.WriteLine(d);
            }

            foreach (double d in this.downValueList)
            {
                sw.WriteLine(d);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            return;
           
        }


    }
}
