using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yixing.UserControl.DataSourceOperate;

namespace Yixing
{
    public partial class DataSourceOperate : Form
    {
        public DataSourceOperate()
        {
            InitializeComponent();
        }

        private void DataSourceOperate_Load(object sender, EventArgs e)
        {
            Search search = new Search();
            this.panel1.Controls.Add(search);
        }
    }
}
