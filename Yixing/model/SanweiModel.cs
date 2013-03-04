using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.model
{
    class SanweiModel
    {
        //马赫雷诺数
        public String mahell;
        //计算线程数
        public String xiancheng;
        //翼型网格文件地址
        public String yixing;
        //计算状态的list
        public List<SanweiStatusModel> statusList;
    }
}
