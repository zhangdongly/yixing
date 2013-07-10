using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.util
{
    public class TexingUtil
    {
        public static string  getMaheString(float mahe){
           return  string.Format("{0:0.000}", mahe);
        }

        public static string getDyjString(float dyj)
        {
            return string.Format("{0:00.00}",dyj);
        }

        public static string getDslxs(float dslxs)
        {
            return  string.Format("{0:0.000}", dslxs);
        }
    }
}
