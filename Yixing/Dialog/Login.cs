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
    public partial class Login : Form
    {
        private Form parent;

        public Login(Form form)
        {
            this.parent = form;
            this.InitializeComponent();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = this.textBox1.Text;
            String passwd = this.textBox2.Text;
            if (!String.IsNullOrWhiteSpace(name) && name.Equals("admin") && !String.IsNullOrWhiteSpace(passwd) && passwd.Equals("admin"))
            {
                this.Close();
            }
            else
            {
                this.label4.Text = "帐号或密码错误";
                this.label4.ForeColor = Color.Red;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.parent.Close();
            this.Close();
        }

    }
}
