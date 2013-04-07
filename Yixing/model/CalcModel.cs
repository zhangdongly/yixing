using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class CalcModel
    {
        //CFL
        public String inpPath { get; set; }
        //第一重迭代
        public Boolean isZn { get; set; }
        //第一重迭代
        public float mahe { get; set; }
        //第一重迭代
        public Boolean isyj { get; set; }
        //第一重迭代
        public float yj { get; set; }
        //线程数
        public int xc { get; set; }
    }
}
