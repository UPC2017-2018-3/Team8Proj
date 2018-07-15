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
    /// AdminLogic 的摘要说明:关于系统管理员操作的业务处理
    /// </summary>
    public class AdminLogic
    {
        private string errMessage; 
        public string getErrMessage() { return this.errMessage; }
        public AdminLogic()
        {
            this.errMessage = "";
        }
        public bool checkAdmin(AdminModel admin)
        {
            string queryString;
            bool hasUser, isPasswordRight;
            queryString = "select * from [admin] where username = " + SqlString.GetQuotedString(admin.getUsername());
            DataBase db = new DataBase();
            hasUser = db.GetRecord(queryString);
            if (false == hasUser)
            {
                errMessage = "对不起，用户名不存在!";
                return false;
            }
            queryString = "select * from [admin] where username = " + SqlString.GetQuotedString(admin.getUsername());
            queryString = queryString + " and password = " + SqlString.GetQuotedString(admin.getPassword());
            isPasswordRight = db.GetRecord(queryString);
            if (false == isPasswordRight)
            {
                errMessage = "对不起，用户密码错误!";
                return false;
            }

            return true;
        }
        public bool ChangePassword(AdminModel admin)
        {
            string updateString = "update [admin] set password=" + SqlString.GetQuotedString(admin.getPassword());
            updateString += " where username=" + SqlString.GetQuotedString(admin.getUsername());

            DataBase db = new DataBase();
            if (db.InsertOrUpdate(updateString) < 0)
                return false;
            return true;
        }
        public AdminModel getAdminInfo(string username)
        {
            string sqlString = "select * from [admin] where username=" + SqlString.GetQuotedString(username);
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            AdminModel adminModel = null;
            

            return adminModel;
        }

        

    }
}
