using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using System.IO;
using NVelocity.Runtime;
using System.Text;
using System;

namespace Yixing.util
{
    public class TemplateHelper
    {
        private VelocityEngine velocity = null;
        private IContext context = null;

        public TemplateHelper()
        {
            string templatePath = Yixing.Properties.Settings.Default.vmFolder;
            velocity = new VelocityEngine();

            velocity.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, templatePath);
            velocity.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");

            //   props.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "gb2312");
            //    props.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");

            //  props.SetProperty(RuntimeConstants.RESOURCE_MANAGER_CLASS, "NVelocity.Runtime.Resource.ResourceManagerImpl\\,NVelocity");

            velocity.Init();
            //RuntimeConstants.RESOURCE_MANAGER_CLASS 
            //为模板变量赋值
            context = new VelocityContext();

        }

        /// <summary>
        /// 给模板变量赋值
        /// </summary>
        /// <param name="key">模板变量</param>
        /// <param name="value">模板变量值</param>
        public void Put(string key, object value)
        {
            //if (context == null)
            //    context = new VelocityContext();
            context.Put(key, value);
        }

        /// <summary>
        /// 生成字符
        /// </summary>
        /// <param name="templatFileName">模板文件名</param>
        public string BuildString(string templatFileName,string yxName,string mahe,string zhuangtai)
        {
            //从文件中读取模板
            Template template = velocity.GetTemplate(templatFileName);

            //合并模板
            StringWriter writer = new StringWriter();
            template.Merge(context, writer);
            string outpath = Yixing.Properties.Settings.Default.defaultFileFolder + "/" + yxName + "/m" + mahe + "/" + zhuangtai;
            if (!Directory.Exists(outpath))
            {
                Directory.CreateDirectory(outpath);
            }
            using (StreamWriter writer2 = new StreamWriter(outpath + "/cfl3d.inp", false, Encoding.Default, 200))
            {
                writer2.Write(writer);
                writer2.Flush();
                writer2.Close();
            }
            return writer.ToString();
        }

        internal string BuildString(string p, string yxname, string mahe)
        {
            throw new System.NotImplementedException();
        }
    }
}
