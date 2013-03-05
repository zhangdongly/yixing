using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.model
{
    class DCGaoji
    {
        //CFL
        public int cfl { get; set; }
        //第一重迭代
        public int onedd { get; set; }
        //第二重迭代
        public int secdd { get; set; }
        //第三重迭代
        public int thirdd { get; set; }
        //修正熵
        public float xzs { get; set; }
    }
}
