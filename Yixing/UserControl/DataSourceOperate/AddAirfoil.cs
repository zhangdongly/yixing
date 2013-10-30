using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yixing.model.database;
using Yixing.util;

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

        private void button1_Click(object sender, EventArgs e)
        {
           Inport inn=new Inport();
           inn.ShowDialog();
           
            /**
            DAirfoil daf = new DAirfoil();
            daf.name = "text1";
            daf.type = 1;
            daf.pointsValue = "1:1;2:2;3:3";
            daf.maxThickness = 1;
            daf.maxThicknessLocation = 1.1;
            daf.maxWidth = 2;
            daf.maxWidthLocation = 2.2;
            daf.status = 0;
            daf.gmtCreate =  DateTime.Now;
            daf.gmtUpdate = DateTime.Now;
            daf.createUser = "张三";
            daf.manageUser = "李四";           
            int result = DataBaseUtil.insertAndGetId(CommandType.Text,DAirfoil.getInsertSQL(),daf.getMysqlParameter());
            MessageBox.Show("插入成功 result="+result);
             * **/
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlParameter []cmdParam =new MySqlParameter[1];
            cmdParam[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            cmdParam[0].Value = 2;

            DataSet ds = DataBaseUtil.GetDataSet(CommandType.Text, "select * from airfoil where id=@id", cmdParam);
            List<DAirfoil> daList = DAirfoil.getFromDateSet(ds);
            foreach (DAirfoil da in daList)
            {
                MessageBox.Show(da.ToString()+"\t"+da.id);
            }
        }
    }
}
