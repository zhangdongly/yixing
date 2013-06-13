using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Yixing.UserTool;
using Yixing.util;

namespace Yixing.model
{
    class JiheTexingModel
    {
        private JiheTexingModel()
        {
        }

        public String fileName {set;get;}

        public double MaxThickness { set; get; }

        public double MaxThicknessLocation { set; get; }

        public double Maxcamber { set; get; }

        public double MaxcamberLocation { set; get; }

        public List<double> xList { set; get; }

        public List<double> sourceXList { set; get; }

        public List<double> sourceYList { set; get; }

        public List<double> thicknessList { set; get; }

        public List<double> camberList { set; get; }

        public static JiheTexingModel createByFile(String filePath,String sourcePath)
        {
           
            JiheTexingModel j = new JiheTexingModel();
            j.fileName = sourcePath.Substring(sourcePath.LastIndexOf("\\") + 1);
            List<String> infoList = FileUtil.readFile(filePath);
            toMaxAndLocation(infoList[0],j);
            j.xList = new List<double>();
            j.thicknessList = new List<double>();
            j.camberList = new List<double>();
            j.sourceYList = new List<double>();
            j.sourceXList = new List<double>();
            for (int i = 1; i < infoList.Count; i++)
            {
                List<double> results = getDoubleList(infoList[i]);
               
                j.xList.Add((results[0]));
                j.thicknessList.Add((results[1]));
                j.camberList.Add((results[2]));
            }

            setSourceLocation(sourcePath,j);
            return j;
        }

        private static void setSourceLocation(String sourcePath, JiheTexingModel j)
        {
            try
            {
                List<String> infoList = FileUtil.readFile(sourcePath);
                Regex hr = new Regex(@"(-?[0-9]+.?[0-9]*)", RegexOptions.IgnoreCase);
               for(int i=1;i<infoList.Count;i++)
                {
                    
                    MatchCollection matches = hr.Matches(infoList[i]);
                   j.sourceXList.Add(double.Parse(matches[0].Groups[1].Value));
                   j.sourceYList.Add(double.Parse(matches[1].Groups[1].Value));
                }              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

       static List<double> getDoubleList(String info)
        {
            List<double> dList = new List<double>();         
            String[] results = info.Split(' ');
                foreach (String re in results)
                {
                    if(!String.IsNullOrWhiteSpace(re.Trim()))
                    {
                        dList.Add(Convert.ToDouble(re));
                    }
                }
                return dList;

        }

        private static void toMaxAndLocation(String info, JiheTexingModel j)
        {
            Regex hr = new Regex(@"(-?[0-9]+.?[0-9]*)", RegexOptions.IgnoreCase);
            MatchCollection matches = hr.Matches(info);
            j.MaxThickness=double.Parse(matches[0].Groups[1].Value);
            j.MaxThicknessLocation=double.Parse(matches[1].Groups[1].Value);
            j.Maxcamber = double.Parse(matches[2].Groups[1].Value);
            j.MaxcamberLocation = double.Parse(matches[3].Groups[1].Value);
        }
    }
}
