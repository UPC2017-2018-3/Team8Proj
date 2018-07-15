using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Hospital.Model;
using Hospital.DB;

namespace Hospital.Logic
{

    /// <summary>
    /// HuaJiaLogic 的摘要说明：关于药品划价信息处理逻辑
    /// </summary>
    public class HuaJiaLogic
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }
        public HuaJiaLogic()
        {
            this.errMessage = "";
        }
        public static bool AddHuaJiaInfo(HuaJiaModel huajiaModel)
        {
            string sqlString = "insert into [t_huajia] (huajia_serial_no,medicineId,price,count,totalPrice,operateTime,operator) values (";
            sqlString += SqlString.GetQuotedString(huajiaModel.getHuajia_serial_no()) + ",";
            sqlString += huajiaModel.getMedicineId() + ",";
            sqlString += huajiaModel.getPrice() + ",";
            sqlString += huajiaModel.getCount() + ",";
            sqlString += huajiaModel.getTotalPrice() + ",'";
            sqlString += huajiaModel.getOperateTime() + "',";
            sqlString += SqlString.GetQuotedString(huajiaModel.getOperator()) + ")";
            DataBase db = new DataBase();
            if (db.InsertOrUpdate(sqlString) < 0) return false;
            return true;
        }

        public static DataSet QueryHuaJiaInfo(string huajia_serial_no, string starttime, string endtime)
        {
            string sqlString = "select * from [huajia_view] where 1=1";
            if (!huajia_serial_no.Equals(""))
                sqlString += " and huajia_serial_no like '%" + huajia_serial_no + "%'";
            if (!starttime.Equals(""))
                sqlString += " and operateTime > '" + starttime + "'";
            if (!endtime.Equals(""))
                sqlString += " and operateTime < '" + endtime + "'";
            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);
        }
    }
}

