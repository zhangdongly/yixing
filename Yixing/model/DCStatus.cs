using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.model
{
    public class DCStatus
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
        public int znKey { get; set; }

        //高级相关
        public int gjKey { get; set; }

        //该状态所对应的翼型文件数据
        public DCYixing yx { get; set; }

        //在dic中的key
        public int key { get; set; }

        //用于判断是选中了迎角还是定升力系数
        public Boolean isyj { get; set; }
    }
}
