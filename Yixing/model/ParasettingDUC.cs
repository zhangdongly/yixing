using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class ParasettingDUC
    {
        /**
         * 参数化的上限，下限和当前值
         * 
         * */
        public string name { get; set; }

        public double down { get; set; }

        public double up { get; set; }

        public double current { get; set; }

        public ParasettingDUC(double down, double current, double up,string name)
        {
            this.down = down;
            this.up = up;
            this.current = current;
            this.name = name;
        }
    }
}
