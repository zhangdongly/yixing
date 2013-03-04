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
    public partial class DingChangGaoji : Form
    {
        public DingChangGaoji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            this.panel2.Enabled = r.Checked;
        }

        private void DingChangGaoji_Load(object sender, EventArgs e)
        {
            this.radioButton3.Checked = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;

            textBox5.Enabled = r.Checked;
            
        }

       
      
    }
}
