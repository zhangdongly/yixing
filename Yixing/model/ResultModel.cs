using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yixing.model
{
    class ResultModel
    {

        public String name;
        public string[] varsArray ;
        public Dictionary<string, List<double>> resultMap;




        private ResultModel()
        {
        }

        public static ResultModel createResultModel(String fileName)
        {
            ResultModel rm = new ResultModel();
            StreamReader sr = File.OpenText(fileName);
            String line = null;
            int lineNumber = 0;
            while ((line = sr.ReadLine()) != null)
            {
                if (lineNumber == 0)
                {
                    if (line.StartsWith("variables"))
                    {
                        String vars = line.Split("=".ToCharArray())[1];
                        rm.varsArray = vars.Trim().Replace("\"", "").Split(" ".ToCharArray());
                        if (rm.varsArray != null)
                        {
                            rm.resultMap = new Dictionary<string, List<double>>();
                            foreach (String var in rm.varsArray)
                            {
                                List<double> varList = new List<double>();
                                rm.resultMap.Add(var, varList);
                            }
                        }
                    }
                    else
                    {
                        Regex hr = new Regex(@"([a-zA-Z]+)", RegexOptions.IgnoreCase);
                        MatchCollection matches = hr.Matches(line);
                        rm.varsArray=new String[matches.Count];
                        rm.resultMap = new Dictionary<string, List<double>>();
                        for (int i = 0; i < matches.Count; i++)
                        {
                            String var=matches[i].Groups[1].Value;
                            rm.varsArray[i] = var;
                            List<double> varList = new List<double>();
                            rm.resultMap.Add(var,varList);

                        }
                    }
                }
                else
                {
                    if (rm.resultMap != null)
                    {
                        Regex hr = new Regex(@"(-?[0-9]*[.][0-9]*)", RegexOptions.IgnoreCase);
                        MatchCollection matches = hr.Matches(line);
                        for (int i = 0; i < matches.Count; i++)
                        {
                            rm.resultMap[rm.varsArray[i]].Add(Convert.ToDouble(matches[i].Groups[1].Value));
                        }
                    }
                }
                lineNumber++;
            }
            return rm;
        }

    }
}
