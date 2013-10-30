using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Yixing.util;

namespace Yixing.model.database
{
   public class DAirfoil
    {
       public int id { set;get; }
       public string name { set; get; }
       public int type { set; get; }
       public string pointsValue { set; get; }
       public double maxThickness { set; get; }
       public double maxThicknessLocation { set; get; }
       public double maxWidth { set; get; }
       public double maxWidthLocation { set; get; }
       public int status;
       public DateTime gmtCreate { set; get; }
       public DateTime gmtUpdate { set; get; }
       public String createUser { set; get; }
       public String manageUser { set; get; }
       public List<DCalResult> dCalResultList { set; get; }

       public MySqlParameter[] getMysqlParameter()
       {
           MySqlParameter[] cmdParms = new MySqlParameter[13];
           cmdParms[0] = new MySqlParameter("@name", MySqlDbType.VarChar);
           cmdParms[0].Value = name;
           cmdParms[1] = new MySqlParameter("@type", MySqlDbType.Int16);
           cmdParms[1].Value = type;
           cmdParms[2] = new MySqlParameter("@pointsValue", MySqlDbType.Text);
           cmdParms[2].Value = pointsValue;
           cmdParms[3] = new MySqlParameter("@maxThickness", MySqlDbType.Double);
           cmdParms[3].Value = maxThickness;
           cmdParms[4] = new MySqlParameter("@maxThicknessLocation", MySqlDbType.Double);
           cmdParms[4].Value = maxThicknessLocation;
           cmdParms[5] = new MySqlParameter("@maxWidth", MySqlDbType.Double);
           cmdParms[5].Value = maxWidth;
           cmdParms[6] = new MySqlParameter("@maxWidthLocation", MySqlDbType.Double);
           cmdParms[6].Value = maxWidthLocation;
           cmdParms[7] = new MySqlParameter("@status", MySqlDbType.Int16);
           cmdParms[7].Value = this.type;
           cmdParms[8] = new MySqlParameter("@gmtCreate", MySqlDbType.DateTime);
           cmdParms[8].Value = this.gmtCreate;
           cmdParms[9] = new MySqlParameter("@gmtUpdate", MySqlDbType.DateTime);
           cmdParms[9].Value = this.gmtUpdate;
           cmdParms[10] = new MySqlParameter("@createUser",MySqlDbType.VarChar);
           cmdParms[10].Value = this.createUser;
           cmdParms[11] = new MySqlParameter("@manageUser", MySqlDbType.VarChar);
           cmdParms[11].Value = this.manageUser;
           cmdParms[12] = new MySqlParameter("@id", MySqlDbType.Int32);
           cmdParms[12].Value = id;

           return cmdParms;
       }
       public static List<DAirfoil> getFromDateSet(DataSet ds)
       {
           List<DAirfoil> dAList = new List<DAirfoil>();
           foreach (DataRow mDr in ds.Tables[0].Rows)
           {
               DAirfoil d = new DAirfoil();
               d.id =Convert.ToInt32(mDr["id"].ToString());
               d.name = mDr["name"].ToString();
               d.type = Convert.ToInt32(mDr["type"].ToString());
               String maxThicknessStr = mDr["max_thickness"].ToString();
               if (String.IsNullOrWhiteSpace(maxThicknessStr))
               {
                   d.maxThickness = double.NaN;
               }
               else
               {
                   d.maxThickness = Convert.ToDouble(maxThicknessStr);
               }

               String maxThicknessLocationStr = mDr["max_thickness_location"].ToString();
               if (String.IsNullOrWhiteSpace(maxThicknessLocationStr))
               {
                   d.maxThicknessLocation = double.NaN;
               }
               else
               {
                   d.maxThicknessLocation = Convert.ToDouble(maxThicknessLocationStr);
               }

               String maxWidthStr = mDr["max_width"].ToString();
               if (String.IsNullOrWhiteSpace(maxWidthStr))
               {
                   d.maxWidth = double.NaN;
               }
               else
               {
                   d.maxWidth = Convert.ToDouble(maxWidthStr);
               }

               String maxWidthLocationStr = mDr["max_width_location"].ToString();
               if (String.IsNullOrWhiteSpace(maxWidthLocationStr))
               {
                   d.maxWidthLocation = double.NaN;
               }
               else
               {
                   d.maxWidthLocation = Convert.ToDouble(maxWidthLocationStr);
               }

               d.gmtCreate = Convert.ToDateTime(mDr["gmt_create"]);
               d.gmtUpdate = Convert.ToDateTime(mDr["gmt_update"]);
               d.status = Convert.ToInt32(mDr["status"]);
               d.createUser = mDr["create_user"].ToString();
               d.manageUser = mDr["manage_user"].ToString();
               d.pointsValue = mDr["points_value"].ToString();
               if (d.id != 0)
               {
                   d.dCalResultList = getDCalResult(d.id);
               }
               dAList.Add(d);
               

           }
           return dAList;
       }

       private static List<DCalResult> getDCalResult(int id)
       {
           MySqlParameter[] cmdParam = new MySqlParameter[1];
           cmdParam[0] = new MySqlParameter("@id", MySqlDbType.Int32);
           cmdParam[0].Value = 2;

           DataSet ds = DataBaseUtil.GetDataSet(CommandType.Text, "select * from cal_result where airfoil_id=@id", cmdParam);
           List<DCalResult> dc = DCalResult.getFromDateSet(ds);
           
           return dc;
       }

       public static String getInsertSQL()
       {
           return "insert into airfoil(name,type,points_value," +
                  "max_thickness,max_thickness_location,max_width,max_width_location,status,gmt_create," +
                  "gmt_update,create_user,manage_user) values(@name,@type,@pointsValue,@maxThickness,"
                  + "@maxThicknessLocation,@maxWidth,@maxWidthLocation,@status,@gmtCreate,@gmtUpdate,@createUser," +
              "@manageUser);";
       }


    }

  
}
