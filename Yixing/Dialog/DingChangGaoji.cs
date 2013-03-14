using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yixing.model;

namespace Yixing.Dialog
{
    public partial class DingChangGaoji : Form
    {
        //用于确认是否点击确认完成的
        //public Boolean sure = false;

        public int cfl  =1000;
        public int onedd = 1000;
        public int secdd = 1000;
        public int thirdd = 1500;
        public float xzs;

        public DingChangGaoji()
        {
            InitializeComponent();
        }

        public DingChangGaoji(DCGaoji gj,StatusEditAble editAble)
        {
            InitializeComponent();
            if (gj == null)
                 return;

            if (editAble.cfl)
            {
                this.textBox1.Text = gj.cfl.ToString();
            }
            else
            {
                this.textBox1.Enabled = false;
            }

            if (editAble.onedd)
            {
                this.textBox2.Text = gj.onedd.ToString();
            }
            else
            {
                this.textBox2.Enabled = false;
            }

            if (editAble.secdd)
            {
                this.textBox3.Text = gj.secdd.ToString();
            }
            else
            {
                this.textBox3.Enabled = false;

            }

            if (editAble.thirdd)
            {
                this.textBox4.Text = gj.thirdd.ToString();
            }
            else
            {
                this.textBox4.Enabled = false;

            }

            if (editAble.xzs)
            {
                this.textBox5.Text = gj.xzs.ToString();
            }
            else
            {
                this.panel3.Enabled = false;

            }

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
            this.DialogResult = DialogResult.OK;
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
