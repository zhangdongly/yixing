﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yixing.UserControl.DataSourceOperate
{
    public partial class MixtureCamberAndThicknessAirfoil : Form
    {
        public MixtureCamberAndThicknessAirfoil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectAirfoil sa = new SelectAirfoil();
            sa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectAirfoil sa = new SelectAirfoil();
            sa.ShowDialog();
        }
    }
}
