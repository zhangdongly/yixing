using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.model
{
    public class DCYixing
    {
        //翼型文件名
        public String name { get; set; }
        //翼型文件所在位置
        public String filePath { get; set; }
        //翼型所包含的状态List
        public List<DCStatus> dcList { get; set; }
        //翼型所包含的状态List
        public int key { get; set; }
    }
}
