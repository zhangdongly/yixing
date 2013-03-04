using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Yixing.Dialog
{
    public partial class Yangbenjiaoyan : Form
    {
        public Yangbenjiaoyan()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yangbenjiaoyan_Load(object sender, EventArgs e)
        {
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            for (int i = 0; i < 100; i++)
            {
                this.chart1.Series[0].Points.Add(new DataPoint(i, i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
