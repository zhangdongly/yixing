using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yixing.UserTool
{
    class FileDialogUtil
    {
        public static String getSelectFileName(OpenFileDialog openFileDialog){
             openFileDialog.InitialDirectory = @"D:\";
            openFileDialog.FileName = null;
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   return  openFileDialog.FileName;
                }
                catch
                {
                }
            }
            return null;
        }
    }
}
