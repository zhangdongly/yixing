using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Yixing.model.database
{
    public class DCalResult
    {
        public int id { set; get; }
        public int airfoilId {set;get;}
        public double ma {set;get;}
        public double re {set;get;}
        public double alpha {set;get;}
        public double cl {set;get;}
        public double cd {set;get;}
        public double cm {set;get;}
        public double k {set;get;}
        public int scheme { set; get; }
        public int turble { set; get; }
        public int grid { set; get; }
        public DateTime gmtCreate { set; get; }
        public DateTime gmtUpdate { set; get; }
        public String createUser { set; get; }
        public String manageUser { set; get; }

        public MySqlParameter[] getMysqlParameter()
        {
            MySqlParameter[] cmdParms = new MySqlParameter[16];
            cmdParms[0] = new MySqlParameter("@airfoilId", MySqlDbType.Int32);
            cmdParms[0].Value = this.airfoilId;
            cmdParms[1] = new MySqlParameter("@ma", MySqlDbType.Double);
            cmdParms[1].Value = ma;
            cmdParms[2] = new MySqlParameter("@re", MySqlDbType.Double);
            cmdParms[2].Value = re;
            cmdParms[3] = new MySqlParameter("@alpha", MySqlDbType.Double);
            cmdParms[3].Value = alpha;
            cmdParms[4] = new MySqlParameter("@cl", MySqlDbType.Double);
            cmdParms[4].Value = cl;
            cmdParms[5] = new MySqlParameter("@cd", MySqlDbType.Double);
            cmdParms[5].Value = cd;
            cmdParms[6] = new MySqlParameter("@cm", MySqlDbType.Double);
            cmdParms[6].Value = cm;
            cmdParms[7] = new MySqlParameter("@k", MySqlDbType.Double);
            cmdParms[7].Value = this.k;
            cmdParms[8] = new MySqlParameter("@gmtCreate", MySqlDbType.DateTime);
            cmdParms[8].Value = this.gmtCreate;
            cmdParms[9] = new MySqlParameter("@gmtUpdate", MySqlDbType.DateTime);
            cmdParms[9].Value = this.gmtUpdate;
            cmdParms[10] = new MySqlParameter("@createUser", MySqlDbType.VarChar);
            cmdParms[10].Value = this.createUser;
            cmdParms[11] = new MySqlParameter("@manageUser", MySqlDbType.VarChar);
            cmdParms[11].Value = this.manageUser;
            cmdParms[12] = new MySqlParameter("@id", MySqlDbType.Int32);
            cmdParms[12].Value = id;
            cmdParms[13] = new MySqlParameter("@scheme", MySqlDbType.Int32);
            cmdParms[13].Value = this.scheme;
            cmdParms[14] = new MySqlParameter("@turble", MySqlDbType.Int32);
            cmdParms[14].Value = this.turble;
            cmdParms[15] = new MySqlParameter("@grid", MySqlDbType.Int32);
            cmdParms[15].Value = this.grid;

            return cmdParms;
        }

        public static String getInsertSQL()
        {
            return "insert into cal_result(airfoil_id,ma,re,alpha,cl,cd,cm,k,gmt_create,gmt_update,"
            + " user_create,user_manager,scheme,turble,grid) values(@airfoilId,@ma,@re,@alpha,@cl,@cd,@cm,@k,@gmtCreate"
             +", @gmtUpdate,@createUser,@manageUser,@scheme,@turble,@grid)";
        }

        public static List<DCalResult> getFromDateSet(DataSet ds)
        {
            List<DCalResult> dAList = new List<DCalResult>();
            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                DCalResult d = new DCalResult();
                d.id = Convert.ToInt32(mDr["id"].ToString());
                d.airfoilId=Convert.ToInt32(mDr["airfoil_id"].ToString());
               d.ma=Convert.ToDouble(mDr["ma"].ToString());
                d.re=Convert.ToDouble(mDr["re"].ToString());
                d.alpha=Convert.ToDouble(mDr["alpha"].ToString());
                d.cl=Convert.ToDouble(mDr["cl"].ToString());
                d.cd=Convert.ToDouble(mDr["cd"].ToString());
                d.cm=Convert.ToDouble(mDr["cm"].ToString());
                d.k=Convert.ToDouble(mDr["k"].ToString());
                d.gmtCreate = Convert.ToDateTime(mDr["gmt_create"]);
                d.gmtUpdate = Convert.ToDateTime(mDr["gmt_update"]);               
                d.createUser = mDr["user_create"].ToString();
                d.manageUser = mDr["user_manager"].ToString();
                dAList.Add(d);
            }
            return dAList;
        }
    
            
    }

}
