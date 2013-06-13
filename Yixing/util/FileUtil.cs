using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Yixing.util
{
    class FileUtil
    {
        public static void write2File(String filePath,List<String> infoList)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.ASCII);           
            foreach (String info  in infoList)
            {
                sw.WriteLine(info);
            }          
            sw.Flush();
            sw.Close();
            fs.Close();
            return;
        }

        public static List<String> readFile(String fileName)
        {
            List<String> infoList = new List<String>();
            StreamReader sr = File.OpenText(fileName);
            String line = null;
            while ((line = sr.ReadLine()) != null)
            {
                infoList.Add(line);
            }
            sr.Close();

            return infoList;
        }
    }
}
