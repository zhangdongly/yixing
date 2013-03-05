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
        //用于确认是否点击确认完成的
        //public Boolean sure = false;

        public int cfl  =1000;
        public int onedd = 1000;
        public int secdd = 1000;
        public int thirdd = 5000;
        public float xzs;

        public DingChangGaoji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.textBox1.Text, out cfl))
            {
                MessageBox.Show("CFL必须为数字");
                return;
            }
            if (!int.TryParse(this.textBox2.Text, out onedd))
            {
                MessageBox.Show("第一重迭代步数必须为数字");
                return;
            }
            if (!int.TryParse(this.textBox3.Text, out secdd))
            {
                MessageBox.Show("第二重迭代步数必须为数字");
                return;
            }
            if (!int.TryParse(this.textBox4.Text, out thirdd))
            {
                MessageBox.Show("第三重迭代步数必须为数字");
                return;
            }
            if (radioButton4.Checked)
            {
                if (!float.TryParse(this.textBox5.Text, out xzs))
                {
                    MessageBox.Show("熵修正必须为数字");
                    return;
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
