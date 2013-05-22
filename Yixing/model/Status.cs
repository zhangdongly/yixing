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
