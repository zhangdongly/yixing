using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class CalcResult
    {
        public String inpPath { get; set; }

        public double ma { get; set; }
        
        public double alpha { get; set; }

        public double cl { get; set; }

        public double cd { get; set; }

        public double cm { get; set; }

        public double k { get; set; }

        //0-转捩 1-非转捩
        public int transe { get; set; }

        //0-成功 1-失败
        public int sucess { get; set; }

        public void setValue( double ma , double alpha,double cl , double cd  ,double cm  ,float k  , int transe  , int sucess){
            this.ma = ma;
            this.alpha = alpha;
            this.cl = cl;
            this.cd = cd;
            this.cm = cm;
            this.k = k;
            this.transe = transe;
            this.sucess = sucess;
        }
    }
}
