using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yixing.Dialog
{
    public partial class SetFileFolder : Form
    {
        public SetFileFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(this.folderBrowserDialog1.SelectedPath);
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
               // Yixing.Properties.Resources.defaultYixingFolder = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void SetFileFolder_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = Yixing.Properties.Resources.defaultYixingFolder;
        }
    }
}
