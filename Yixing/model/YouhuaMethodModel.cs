using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    public class YouhuaMethodModel
    {
        //优化方法的相关数据 

        public String algorithm { set; get; }

        public Boolean isUseDaili { set; get; }

        public Boolean isDefaultDailiModel { set; get; }


        public String optimizingStrategy;

    }
}
