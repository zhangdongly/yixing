using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    class QDTXMethodList
    {
        public QDTXMethodList()
        {
            this.modelList = new List<QDTXMethodModel>();
        }

        //气动特性评估方法类的model
        public int statusId {set;get;}

        public List<QDTXMethodModel> modelList { set; get; }
       
    }
}
