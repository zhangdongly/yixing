using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model.mubiaohans
{
    class AimExpression
    {
        //气动特性编号，升力 cl-1，阻力 cd-2 
        public int qdtx { get; set; }

        //气动特性上限
        public int limitup { get; set; }

        //气动特性下限
        public int limitdown { get; set; }

        //气动特性惩罚系数
        public int cfxs { get; set; }

        //状态序号
        public int index { get; set; }

    }
}
