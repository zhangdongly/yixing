using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    public class JiankongModel
    { 
        //监控类型（图或者表，1为图，2为表）
        public int type { set; get; }

        public Boolean isShowPareto { set; get; }

        public Boolean isShowQingying { set; get; }

        public Boolean isShowIn { set; get; }

        public Boolean isShowOut { set; get; }

        public int numbersOfEachRow { set; get; }

        public List<JiankongParamModel> showJiankongList { set; get; }

    }
}
