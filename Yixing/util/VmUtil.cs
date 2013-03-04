using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;
using System;
using System.IO;

namespace Yixing.util
{
    class VmUtil
    {
        public static void genFile()
        {
            VelocityEngine vltEngine = new VelocityEngine();
            vltEngine.SetProperty(RuntimeConstants_Fields.RESOURCE_LOADER, "file");
            vltEngine.SetProperty(RuntimeConstants_Fields.FILE_RESOURCE_LOADER_PATH, "../template/");
            vltEngine.Init();

            Template vltTemplate = vltEngine.GetTemplate("cfl3d.vm");
            VelocityContext vltContext = new VelocityContext();

            vltContext.Put("tu", "Unmi");
            // vltContext.Put("bill", "1000");
            //vltContext.Put("type", "报销单");
            // vltContext.Put("date", DateTime.Now.ToLongDateString());

            StringWriter vltWriter = new StringWriter();
            vltTemplate.Merge(vltContext, vltWriter);
            Console.WriteLine(vltWriter.GetStringBuilder().ToString());
           
        }
    }
}
