using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Yixing.model.database;

namespace Yixing.util
{
    public class DAirfoilUtil
    {
        
        /**
         * 需要四个文件 ，分别是
         * 翼型异性文件，
         * 翼型几何数据点文件
         * 翼型计算条件结果文件 
         * 翼型最大弯度，最大宽度文件
          **/

        public static List<DAirfoil> readDAirfoil(String nameFile, String pointFile, String calResultFile, String foilticFile)
        {
            List<DAirfoil> dAirFoilList = new List<DAirfoil>();
            List<String> nameStringList = FileUtil.readFile(nameFile);
            List<String> pointsStringList = FileUtil.readFile(pointFile);
            List<String> calResultStringList = FileUtil.readFile(calResultFile);
            List<String> foilticStringList = FileUtil.readFile(foilticFile);
            initNameFile(nameStringList, dAirFoilList);
            initPointsFile(pointsStringList, dAirFoilList);
            for (int i = 0; i < 300; i++)
            {
                if (i % 100 == 0)
                {
                    MessageBox.Show(i+"\t"+dAirFoilList[i].pointsValue.Length);
                }
            }
            initFoilticFile(foilticStringList, dAirFoilList);
            for (int i = 0; i < 300; i++)
            {
                if (i % 100 == 0)
                {
                    MessageBox.Show(i + "\t" + dAirFoilList[i].maxThickness);
                }
            }
            initCalResultFile(calResultStringList, dAirFoilList);
            for (int i = 0; i < 300; i++)
            {
                if (i % 100 == 0)
                {
                    MessageBox.Show(i + "\t" + dAirFoilList[i].dCalResultList.Count);
                }
            }
            addToDb(dAirFoilList);
            MessageBox.Show("add to db success");
            return dAirFoilList;
        }

        private static void addToDb(List<DAirfoil> daList)
        {
            foreach (DAirfoil da in daList)
            {
                da.createUser = "admin";
                da.manageUser = "admin";
                int result = DataBaseUtil.insertAndGetId(CommandType.Text, DAirfoil.getInsertSQL(), da.getMysqlParameter());
                if (result > 0)
                {
                    foreach (DCalResult dc in da.dCalResultList)
                    {
                        dc.airfoilId = result;
                        dc.gmtCreate = DateTime.Now;
                        dc.gmtUpdate = DateTime.Now;
                        dc.createUser = "admin";
                        dc.manageUser = "admin";
                        DataBaseUtil.insertAndGetId(CommandType.Text, DCalResult.getInsertSQL(), dc.getMysqlParameter());
                    }
                }
            }
        }

        private static void initCalResultFile(List<String> calResultStringList, List<DAirfoil> dAirFoilList)
        {
            int count = dAirFoilList.Count;
            int[] calResultCount = new int[count];
            int airfoilIndex = 0;
            int index = 3;//从第三行开始
            int end = index + count;
            for (; index < end; index++)
            {
                calResultCount[index - 3] = Convert.ToInt32(calResultStringList[index]);
            }
            index += 2;             //正常情况下，这两行是提示。没有什么 实际意义
           
            while (airfoilIndex < count)
            {
                int resultCount = calResultCount[airfoilIndex];
                List<DCalResult> dcList = new List<DCalResult>();
                for (int i = 0; i < resultCount; i++, index++)
                {
                    MatchCollection mc = RegexUtil.getSCM(calResultStringList[index]);
                    int k = 0;
                    if (i == 0)
                    {
                        k = 1;
                    }
                    DCalResult dc = new DCalResult();

                    dc.ma =Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.re = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.alpha = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.cl = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.cd = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.cm = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.k  = Convert.ToDouble(mc[k++].Groups[1].Value);
                    dc.scheme = Convert.ToInt32(mc[k++].Groups[1].Value);
                    dc.turble = Convert.ToInt32(mc[k++].Groups[1].Value);
                    dc.grid = Convert.ToInt32(mc[k++].Groups[1].Value);
                    dcList.Add(dc);
                }
                dAirFoilList[airfoilIndex].dCalResultList = dcList;
                airfoilIndex++;

            }
            
        }

        private static void initFoilticFile(List<String> foilticStringList, List<DAirfoil> dAirFoilList)
        {
            //第0行为"foil num"，第一行为count，第二行为当前翼型需要
            int index = 2;
            int airFoilCount = 0;
            int airFoilIndex = 0;
            int.TryParse(foilticStringList[1], out airFoilCount);
            if (airFoilCount != dAirFoilList.Count)
            {
                //如果个数不等，似乎就有问题了
                MessageBox.Show("厚度弯度个数("+airFoilCount+")和翼型数不匹配("+dAirFoilList.Count+")");
            }
            for (; index < foilticStringList.Count; index++)
            {
                MatchCollection mc = RegexUtil.getSCM(foilticStringList[index]);
                if (mc.Count != 4)
                {
                    MessageBox.Show("error");
                }
                dAirFoilList[airFoilIndex].maxThickness = Convert.ToDouble(mc[0].Groups[1].Value);
                dAirFoilList[airFoilIndex].maxThicknessLocation = Convert.ToDouble(mc[1].Groups[1].Value);
                dAirFoilList[airFoilIndex].maxWidth = Convert.ToDouble(mc[2].Groups[1].Value);
                dAirFoilList[airFoilIndex].maxWidthLocation = Convert.ToDouble(mc[3].Groups[1].Value);
                airFoilIndex++;
            }
        }

        private static void initPointsFile(List<String> pointsStringList, List<DAirfoil> dAirFoilList)
        {
            int count = dAirFoilList.Count;
            int airFoilIndex = 0;
            int index = 2; //第0行为"foil num"，第一行为count，第二行为当前翼型个数
            while (true)
            {
                int airFoilNum = 0;
                int.TryParse(pointsStringList[index], out airFoilNum);
                if (airFoilNum <= 0)
                {
                    MessageBox.Show(airFoilNum + "break\t" + pointsStringList[index]+"\t"+index);
                    break;
                }
                index++;
                int pointsCount = 0;
               
                int.TryParse(pointsStringList[index], out pointsCount);
              
                if (pointsCount == 0)
                {
                    MessageBox.Show(pointsCount + "break\t" + pointsStringList[index] + "\t" + index);
                    break;
                }
                index++;
                int pointsEnd=index+pointsCount;
                StringBuilder pointsValue = new StringBuilder();
                for (; index < pointsEnd; index++)
                {
                    MatchCollection mc=RegexUtil.getSCM(pointsStringList[index]);
                    //此为正则点，正常情况下是两个，如果多了或者少了，此点不加入
                    if (mc.Count != 2)
                    {
                        for (int i = 0; i < mc.Count; i++)
                        {
                            MessageBox.Show("bad regex " + mc[i].Groups[1].Value);
                        }
                        break;
                    }
                    pointsValue.Append(mc[0].Groups[1].Value + ":" + mc[1].Groups[1].Value + ";");
                }          
                //删除最后一个";",并赋值             
                dAirFoilList[airFoilIndex].pointsValue = pointsValue.Remove(pointsValue.Length - 1, 1).ToString();
                airFoilIndex++;
                if (index >= pointsStringList.Count)
                {
                    break;
                }
            }
           

        }

        private static void initNameFile(List<String> nameStringList, List<DAirfoil> dAirFoilList)
        {
            int count = 0;
            int.TryParse(nameStringList[1], out count);
            if (count == 0)
            {
                return;
            }
            for (int i = 0; i < count; i++)
            {
                DAirfoil da = new DAirfoil();
                if (i < nameStringList.Count - 2)
                {
                    da.name = nameStringList[i + 2];
                    da.type = 1;
                }
                dAirFoilList.Add(da);
            }
        }
    }
}
