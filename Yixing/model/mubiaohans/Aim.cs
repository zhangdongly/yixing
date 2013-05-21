using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model.mubiaohans
{
    class Aim
    {
        //目标函数的，序数
        public int index { get; set; }

        //1为最小化，2为最大化
        public int upordown{ get; set; }

        //该目标所包含的表达shi
        public List<AimExpression> expressionList { get; set; }
    }
}
