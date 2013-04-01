using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    [Serializable]
    class StautsSerializeObj
    {
        //马赫数
        public float mahe { get; set; }
        //定迎角
        public float dyj { get; set; }
        //定升力系数
        public float dslxs { get; set; }

        //空间离散格式
        public float lsgs { get; set; }
        //端流模型
        public float dlmx { get; set; }
        //转涅相关
        public Boolean iszn { get; set; }
        //高级相关
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

        //用于判断是选中了迎角还是定升力系数
        public Boolean isyj { get; set; }
    }
}
