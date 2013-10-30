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

        private void 重点翼型数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplexAirfoil c = new ComplexAirfoil();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(c);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ComplexAirfoilDetail cad = new ComplexAirfoilDetail();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(cad);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddAirfoil aaf = new AddAirfoil();
            aaf.ShowDialog();
        }

        private void 修改翼型宽度与厚度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCamberAndThickness uct = new UpdateCamberAndThickness();
            uct.ShowDialog();
        }

        private void 混何两个翼型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mixture2Airfoil ma = new Mixture2Airfoil();
            ma.ShowDialog();
        }

        private void 不同翼型上下表面混合ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MixtureUpAndDownAirfoil muda = new MixtureUpAndDownAirfoil();
            muda.ShowDialog();
        }

        private void 采用不同翼型厚度与弯度分布构靠翼型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MixtureCamberAndThicknessAirfoil mcta = new MixtureCamberAndThicknessAirfoil();
            mcta.ShowDialog();
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inport inport = new Inport();
            inport.ShowDialog();
        }
    }
}
