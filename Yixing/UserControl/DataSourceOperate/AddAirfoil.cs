using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yixing.UserControl.DataSourceOperate
{
    public partial class AddAirfoil : Form
    {
        public AddAirfoil()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                this.panel2.Visible = false;
                this.panel3.Visible = true;
            }
            else
            {
                this.panel2.Visible = true;
                this.panel3.Visible = false;
            }
        }
    }
}
