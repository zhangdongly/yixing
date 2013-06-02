using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class QDTXMethodModel
    {
        //气动特性评估方法类的model
        public int statusIndex {set;get;}

        //气动特性编号，升力 cl-1，阻力 cd-2 3表示力矩，4表示升阻比
        public double qdtx { get; set; }
        
        //代理模型编号  1为RBF，2为Kriging ，3为BP神经网络, 4 为CFD计算，不采用代理模型
        public int pgff { get; set; }

        public int getPGFF()
        {
            if (pgff == 0)
            {
                return this.recommendpgff;
            }
            else
            {
                return pgff;
            }
        }
       
        //系统推荐的代理模型
        public int recommendpgff { get; set; }
    }
}
