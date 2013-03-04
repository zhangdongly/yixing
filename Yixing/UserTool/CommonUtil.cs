using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yixing.UserTool
{
    class CommonUtil
    {
        public static String getFileNameByPath(String filePath){
            if (String.IsNullOrWhiteSpace(filePath))
            {
                return null;
            }
            int index = filePath.LastIndexOf("\\");
            if (index < 0 || index >= filePath.Length)
            {
                return null;
            }
           return   filePath.Substring(index+1);
        }
    }
}
