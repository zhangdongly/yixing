using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Yixing.model
{
   public class InitialAirfoilModel
    {
        /**
         * 
         * 初始翼型的model。
         * */

        public String path { set;get; }

        public double[] XList { set; get; }

        public double[] YList { set; get; }       

        public static InitialAirfoilModel createInitialAirFoil(String fileName)
        {
            try
            {
                InitialAirfoilModel ia = new InitialAirfoilModel();
                ia.path = fileName;
                StreamReader sr = File.OpenText(fileName);
                String line = sr.ReadLine();//第一行直接过了
                List<double> xList = new List<double>();
                List<double> yList = new List<double>();
                while ((line = sr.ReadLine()) != null)
                {
                    Regex hr = new Regex(@"(-?[0-9]+.?[0-9]*)", RegexOptions.IgnoreCase);
                    MatchCollection matches = hr.Matches(line);
                    xList.Add(double.Parse(matches[0].Groups[1].Value));
                    yList.Add(double.Parse(matches[1].Groups[1].Value));
                }
                ia.XList = xList.ToArray();
                ia.YList = yList.ToArray();
                return ia;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
         }
                
     }
           
}

    

