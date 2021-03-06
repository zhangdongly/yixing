﻿using System;
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
    public partial class zhuannie : Form
    {
        public float fddls;

        public float wnxb;

        //用于确认是否点击确认完成的
        public Boolean sure = false;

        public zhuannie()
        {
            InitializeComponent();
        }

        public zhuannie(DCZhuannie zn ,StatusEditAble editAble)
        {
            InitializeComponent();
            if (editAble.fddld )
            {
                if (zn != null) { this.textBox1.Text = zn.fddls.ToString(); }
                
            }
            else { this.textBox1.Enabled = false; }

            if (editAble.wnxb)
            {
                if (zn != null) { this.textBox2.Text = zn.wnxb.ToString(); }
            }
            else { this.textBox2.Enabled = false; }
        }

        public zhuannie(float fddls,float wnxb)
        {
            InitializeComponent();
            this.textBox1.Text = ""+fddls;
            this.textBox2.Text = "" + wnxb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(this.textBox1.Text, out fddls))
            {
                MessageBox.Show("风洞湍流度必须为数字");
                return;
            }
            if (!float.TryParse(this.textBox2.Text, out wnxb))
            {
                MessageBox.Show("涡粘性比必须为数字");
                return;
            }
            sure = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
