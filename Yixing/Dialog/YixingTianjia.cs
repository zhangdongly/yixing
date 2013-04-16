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
using Yixing.UserTool;

namespace Yixing.Dialog
{
    public partial class YixingTianjia : Form
    {
        public YixingTianjia()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox10.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            this.panel1.Enabled = r.Checked;
            this.panel3.Enabled = !r.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int type;
            String filePath;
            String xyzPath;
            String inpPath;
            if (yixing == null)
            {
                yixing = new DCYixing();
            }
            if (this.radioButton1.Checked)
            {
                type = 1;
                filePath = this.textBox7.Text;
                if (String.IsNullOrWhiteSpace(filePath))
                {
                    MessageBox.Show("请选择文件");
                    return;
                }
                yixing.type = type;
                yixing.filePath = filePath;
            }
            else
            {
                type = 2;
                //filePath = this.textBox10.Text;
                xyzPath = this.textBox10.Text;
                inpPath = this.textBox1.Text;
                if (String.IsNullOrWhiteSpace(xyzPath))
                {
                    MessageBox.Show("请选择翼型风格文件");
                    return;
                }
                if (String.IsNullOrWhiteSpace(inpPath))
                {
                    MessageBox.Show("请选择边界文件");
                    return;
                }
                yixing.type = 2;
                yixing.filePath = inpPath;
                yixing.xyzPath = xyzPath;
                yixing.inpPath = inpPath;
            }                              
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Wanggeshezhi w = new Wanggeshezhi();
            if (w.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void YixingTianjia_Load(object sender, EventArgs e)
        {
            if (this.yixing != null)
            {
                if (yixing.type == 1)
                {
                    this.radioButton1.Checked = true;
                    this.textBox7.Text = yixing.filePath;
                }
                else
                {
                    this.radioButton2.Checked = true;
                    this.textBox10.Text = yixing.xyzPath;
                    this.textBox1.Text = yixing.inpPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yixingjihetu y = new Yixingjihetu();
            y.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Text = FileDialogUtil.getSelectFileName(this.openFileDialog1);

        }
    }
}
