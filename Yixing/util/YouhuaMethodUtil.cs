using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yixing.model;

namespace Yixing.util
{
    class YouhuaMethodUtil
    {
        //气动特性编号，升力 cl-1，阻力 cd-2 3表示力矩，4表示升阻比

       
        public static String getQDTXName(double number)
        {
            
            if (number == 1)
            {
                return "Cl";
            }
            if (number == 2)
            {
                return "Cd";
            }
            if (number == 3)
            {
                return "Cm";
            }
            if (number == 4)
            {
                return "k";
            }

            return "error number";
        }

        //代理模型编号  1为RBF，2为Kriging ，3为BP神经网络, 4 为CFD计算，不采用代理模型
        public static String getDLFFName(int number)
        {
            if (number == 1)
            {
                return "RBF代理模型";
            }
            if (number == 2)
            {
                return "Kriging代理模型";
            }
            if (number == 3)
            {
                return "BP神经网络";
            }
            if (number == 4)
            {
                return "CFD";
            }

            return "error num";
        }

        public static int getYouhuaMethodNumber(String text,CheckBox checkBox)
        {         

            if ("直接搜索算法".Equals(text))
            {
                return 1;
            }
            if ("梯度搜索算法".Equals(text))
            {
                return 2;
            }

            if ("多目标遗传算法".Equals(text))
            {
                if (checkBox.Checked)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }

            return 0;
        }

        public static List<String> getQDTXMMList(Dictionary<int, QDTXMethodList> qdtxModelListMap)
        {
            List<String> list = new List<string>();
            foreach (QDTXMethodList ql in qdtxModelListMap.Values)
            {
                foreach (QDTXMethodModel qm in ql.modelList)
                {
                    String value = qm.statusIndex + "\t" + qm.qdtx + "\t" + qm.getPGFF();
                    list.Add(value);
                }
            }
            return list;
        }

        public static int getYHCL(String text)
        {


            if("代理模型不更新".Equals(text)){
                return 1;
            }
            if("紧耦合优化".Equals(text)){return 2;
            }
            if ("松耦合优化".Equals(text))
            {
                return 3;
            }
            return 0;
        }

    }
}
