using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Yixing.util
{
   public class RegexUtil
    {
       static Regex SCM_REGEX = new Regex(@"((-?\d+.?\d*)([Ee]{1}([-|+]?\d+))?)", RegexOptions.IgnoreCase);
       //获取科学计数法的正则匹配结果
       public static MatchCollection getSCM  (String info){
        if(String.IsNullOrWhiteSpace(info)){
            return null;
        }
        return  SCM_REGEX.Matches(info.Trim());
   }
    }
}
