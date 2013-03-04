using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using System.IO;
using NVelocity.Runtime;

namespace Yixing.util
{
    public class TemplateHelper
    {
        private VelocityEngine velocity = null;
        private IContext context = null;

        public TemplateHelper()
        {
           string templatePath =  @"..//..//template";
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
        public string BuildString(string templatFileName)
        {
            //从文件中读取模板
            Template template = velocity.GetTemplate(templatFileName);

            //合并模板
            StringWriter writer = new StringWriter();
            template.Merge(context, writer);
            return writer.ToString();
        }
    }
}
