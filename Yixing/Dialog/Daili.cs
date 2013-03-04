using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class Daili : Form
    {
        public Daili()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                DailiZhuangtai d = new DailiZhuangtai();
                d.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yangbenjiaoyan y = new Yangbenjiaoyan();
            y.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Daili_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.comboBox2.Text = this.comboBox2.Items[0].ToString();
            this.radioButton1.Checked = true;
            this.radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            this.textBox4.Enabled = r.Checked; 
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                String fileName = FileDialogUtil.getSelectFileName(this.openFileDialog1);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;

            if (c.Text.Equals("交叉校验"))
            {

                this.groupBox3.Visible = false;
            }
            else
            {
                this.groupBox3.Visible = true;
            }
        }

       
    }
}
