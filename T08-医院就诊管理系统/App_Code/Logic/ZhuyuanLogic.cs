using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Hospital.DB;
using Hospital.Model;

namespace Hospital.Logic
{
    /// <summary>
    /// ZhuyuanLogic 的摘要说明：关于住院管理的业务逻辑
    /// </summary>
    public class ZhuyuanLogic
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }
        public ZhuyuanLogic()
        {
            this.errMessage = "";
        }
        public bool AddZhuyuanInfo(ZhuyuanModel zhuyuanModel)
        {
            string sqlString = "insert into [t_zhuyuan] (name,sex,age,roomNo,arriveTime,isLeave,leaveTime,money,checkinOperator,checkoutOperator) values (";
            sqlString += SqlString.GetQuotedString(zhuyuanModel.getName()) + ",";
            sqlString += SqlString.GetQuotedString(zhuyuanModel.getSex()) + ",";
            sqlString += zhuyuanModel.getAge() + ",";
            sqlString += SqlString.GetQuotedString(zhuyuanModel.getRoomNo()) + ",";
            sqlString += "'" + zhuyuanModel.getArriveTime() + "',";
            sqlString += zhuyuanModel.getIsLeave() + ",";
            sqlString += "'" + zhuyuanModel.getLeaveTime() + "',";
            sqlString += zhuyuanModel.getMoney() + ",";
            sqlString += SqlString.GetQuotedString(zhuyuanModel.getCheckinOperator()) + ",";
            sqlString += SqlString.GetQuotedString(zhuyuanModel.getCheckoutOperator()) + ")";

            DataBase db = new DataBase();
            if (db.InsertOrUpdate(sqlString) < 0)
            {
                this.errMessage = "登记病人住院信息发生了错误！";
                return false;
            }
            return true;
        }
        public static int QueryIsLeaveById(int t_zhuyuan_id)
        {
            int isLeave = 0;
            string sqlString = "select isLeave from [t_zhuyuan] where t_zhuyuan_id=" + t_zhuyuan_id;
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                isLeave = Convert.ToInt32(ds.Tables[0].Rows[0]["isLeave"]);
            return isLeave;
        }
        public static DataSet QueryZhuyuanInfo(string name, string roomNo, int isLeave)
        {
            string sqlString = "select * from [t_zhuyuan] where 1=1";
            if (!name.Equals(""))
                sqlString += " and name like '%" + name + "%'";
            if (!roomNo.Equals(""))
                sqlString += " and roomNo like '%" + roomNo + "%'";
            if(isLeave != 2)
                sqlString += " and isLeave=" + isLeave;

            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);

        }
        public static ZhuyuanModel GetZhuyuanInfoById(int t_zhuyuan_id)
        {
            string sqlString = "select * from [t_zhuyuan] where t_zhuyuan_id=" + t_zhuyuan_id;
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            ZhuyuanModel zhuyuanModel = null;
            if(ds.Tables[0].Rows.Count > 0)
            {
                zhuyuanModel = new ZhuyuanModel();
                DataRow dr = ds.Tables[0].Rows[0];
                zhuyuanModel.setT_zhuyuan_id(t_zhuyuan_id);
                zhuyuanModel.setName(dr["name"].ToString());
                zhuyuanModel.setSex(dr["sex"].ToString());
                zhuyuanModel.setAge(Convert.ToInt32(dr["age"]));
                zhuyuanModel.setRoomNo(dr["roomNo"].ToString());
                zhuyuanModel.setArriveTime(Convert.ToDateTime(dr["arriveTime"]));
                zhuyuanModel.setIsLeave(Convert.ToInt32(dr["isLeave"]));
                zhuyuanModel.setLeaveTime(Convert.ToDateTime(dr["leaveTime"]));
                zhuyuanModel.setMoney(Convert.ToSingle(dr["money"]));
                zhuyuanModel.setCheckinOperator(dr["checkinOperator"].ToString());
                zhuyuanModel.setCheckoutOperator(dr["checkoutOperator"].ToString());
            }
            return zhuyuanModel;
        }
        public bool UpdateZhuyuanInfo(int t_zhuyuan_id,float money)
        {
            string sqlString = "update [t_zhuyuan] set isLeave=1,leaveTime='" + DateTime.Now + "',money=" + money + " where t_zhuyuan_id=" + t_zhuyuan_id;
            DataBase db = new DataBase();
            if(db.InsertOrUpdate(sqlString) < 0)
            {
                this.errMessage = "办理出院时发生了错误！";
                return false;
            }
            return true;
        }
    }

}
