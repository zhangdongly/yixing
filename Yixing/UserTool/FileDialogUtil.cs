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
           String lastFileFolder=Properties.Settings.Default.lastFileFolder;

           if (!String.IsNullOrWhiteSpace(lastFileFolder))
           {
               openFileDialog.InitialDirectory = lastFileFolder;
           }
            openFileDialog.FileName = null;
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.lastFileFolder = CommonUtil.getFilePathByPath(openFileDialog.FileName);
                Properties.Settings.Default.Save();
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

        public static String getSelectFolder(FolderBrowserDialog folderDlg)
        {
           String lastFileFolder = Properties.Settings.Default.defaultFileFolder;
           String resultStr = "";
           if (!String.IsNullOrWhiteSpace(lastFileFolder))
           {
               folderDlg.SelectedPath = lastFileFolder;
           }
           folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.defaultFileFolder = folderDlg.SelectedPath;
                Properties.Settings.Default.Save();
               resultStr = folderDlg.SelectedPath;
            }
            return resultStr;
        }
    }

}
