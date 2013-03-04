using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json; 

namespace Yixing
{
    public static class  JSONUtil
    {
        

            public static T fromJson<T>(string jsonString)
            {
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
                {
                    return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(ms);
                }
            }

            public static string toString(object jsonObject)
            {
                using (var ms = new MemoryStream())
                {
                    new DataContractJsonSerializer(jsonObject.GetType()).WriteObject(ms, jsonObject);
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
        } 
    
}
