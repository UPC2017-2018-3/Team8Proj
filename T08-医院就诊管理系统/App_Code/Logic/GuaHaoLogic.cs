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
    /// GuaHaoLogic 的摘要说明:关于挂号的业务处理逻辑
    /// </summary>
    public class GuaHaoLogic
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }

        public bool AddGuaHaoInfo(GuaHaoModel guaHaoModel)
        {
            if (guaHaoModel.getName().Equals(""))
            {
                this.errMessage = "病人姓名输入不能为空！";
                return false;
            }

            string sqlString = "insert into [t_guahao] (name,sex,age,subjectId,operateTime,operator) values (";
            sqlString += SqlString.GetQuotedString(guaHaoModel.getName()) + ",";
            sqlString += SqlString.GetQuotedString(guaHaoModel.getSex()) + ",";
            sqlString += guaHaoModel.getAge() + ",";
            sqlString += guaHaoModel.getSubjectId() + ",'";
            sqlString += guaHaoModel.getOperateTime() + "',";
            sqlString += SqlString.GetQuotedString(guaHaoModel.getOperator()) + ")";

            DataBase db = new DataBase();
            if (db.InsertOrUpdate(sqlString) <= 0)
            {
                this.errMessage = "向数据库中加入挂号信息发生了错误！";
                return false;
            }
            return true;
        }
        public DataSet QueryGuaHaoInfo(string name, string starttime, string endtime)
        {
            string sqlString = "select * from [guahaoView] where 1=1";
            if (!name.Equals(""))
                sqlString += " and name like '%" + name + "%'";
            if (!starttime.Equals(""))
                sqlString += " and operateTime > '" + starttime + "'";
            if (!endtime.Equals(""))
                sqlString += " and operateTime < '" + endtime + "'";
            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);
        }
        public GuaHaoLogic()
        {
            this.errMessage = "";
        }
    }

}
