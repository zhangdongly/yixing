using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model.mubiaohans
{
    class AimExpression
    {
        //气动特性编号，升力 cl-1，阻力 cd-2 
        public double qdtx { get; set; }

        //气动特性上限
        public double limitup { get; set; }

        //气动特性下限
        public double limitdown { get; set; }

        //气动特性惩罚系数
        public double cfxs { get; set; }

        //状态序号
        public int index { get; set; }

    }
}
