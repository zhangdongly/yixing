using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    public class Status
    {
        //马赫数
        public float mahe { get; set; }

        //定升力系数
        public float dslxs { get; set; }

        public Boolean isyj { get; set; }

        //空间离散格式
        public float lsgs { get; set; }

        //端流模型
        public float dlmx { get; set; }

        //转涅相关
        public Boolean iszn { get; set; }

        //高级相关
        public int gjKey { get; set; }

        public String getZtName()
        {
            String mahe = string.Format("{0:0.000}", this.mahe);
            mahe = "m" + mahe.Replace(".", "");

            String yj = null;
           
           
            if (isyj)
            {
                yj = "a" + string.Format("{0:00.00}", dslxs); ;
            }
            else
            {
                yj = "cl" + string.Format("{0:0.000}", dslxs); ;
            }
            yj = yj.Replace(".", "");
            return mahe + "_" + yj;
        }
    }
}
