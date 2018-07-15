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
    /// HuaJiaCartLogic 的摘要说明:关于划价药品购物车的业务处理
    /// </summary>
    /// 
    public class HuaJiaCartLogic
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }

        public HuaJiaCartLogic()
        {
            this.errMessage = "";
        }
        public static DataSet GetHuaJiaCartInfo(string username)
        {
            string sqlString = "select * from [huajia_cart_view] where username=" + SqlString.GetQuotedString(username);
            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);
        }
        public bool UpdateHuaJiaCartInfo(int id, int count)
        {
            DataBase db = new DataBase(); 
            string sqlString = "select medicineId from [t_huajia_cart] where id=" + id;
            int medicineId = 0;
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                medicineId = Convert.ToInt32(ds.Tables[0].Rows[0]["medicineId"]);
            sqlString = "select stockCount from [t_medicine] where medicineId=" + medicineId;
            int leftStockCount = 0;
            ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                leftStockCount = Convert.ToInt32(ds.Tables[0].Rows[0]["stockCount"]);
            sqlString = "select count from [t_huajia_cart] where id=" + id;
            int oldCount = 0;
            ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                oldCount = Convert.ToInt32(ds.Tables[0].Rows[0]["count"]);
            int leftCount = leftStockCount + oldCount - count;
            if (leftCount < 0)
            {
                this.errMessage = "药品库存不足,请确认销售数目!";
                return false;
            }
            string update_cart_count_string = "update [t_huajia_cart] set count=" + count + " where id=" + id;
            string update_cart_totalPrice_string = "update [t_huajia_cart] set totalPrice = (price * count) where id=" + id;
           
            string update_medicine_string = "update [t_medicine] set stockCount=" + leftCount + " where medicineId=" + medicineId;
            string[] sqlStrings = new string[3]{update_cart_count_string,update_cart_totalPrice_string,update_medicine_string};
            if(!db.ExecuteSQL(sqlStrings))
            { 
                this.errMessage = "更新药品销售信息时发生了错误!";
                return false;
            }
            return true;
        }
        public bool DeleteHuaJiaCartInfo(int id)
        {
            DataBase db = new DataBase();
            string sqlString = "select medicineId from [t_huajia_cart] where id=" + id;
            int medicineId = 0;
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                medicineId = Convert.ToInt32(ds.Tables[0].Rows[0]["medicineId"]);
            sqlString = "select count from [t_huajia_cart] where id=" + id;
            int count = 0;
            ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                count = Convert.ToInt32(ds.Tables[0].Rows[0]["count"]);
            string del_cart_string = "delete from [t_huajia_cart] where id=" + id;
            string update_medicine_string = "update [t_medicine] set stockCount=stockCount+" + count + " where medicineId=" + medicineId;
            string[] sqlStrings = new string[2] { del_cart_string,update_medicine_string };
            if(!db.ExecuteSQL(sqlStrings))
            {
                this.errMessage = "删除药品销售信息时发生了错误!";
                return false;
            }
            return true;
        }

        public bool AddHuaJiaCartInfo(HuaJiaCartModel huaJiaCartModel)
        {
            string sqlString = "select stockCount from [t_medicine] where medicineId=" + huaJiaCartModel.getMedicineId();
            int leftStockCount = 0;
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                leftStockCount = Convert.ToInt32(ds.Tables[0].Rows[0]["stockCount"]);
            if (huaJiaCartModel.getCount() > leftStockCount)
            {
                this.errMessage = "你输入的药品销售数目超出了系统库存!";
                return false;
            }

            string insert_cart_string = "insert into [t_huajia_cart] (username,medicineId,price,count,totalPrice) values (";
            insert_cart_string += SqlString.GetQuotedString(huaJiaCartModel.getUsername()) + ",";
            insert_cart_string += huaJiaCartModel.getMedicineId() + ",";
            insert_cart_string += huaJiaCartModel.getPrice() + ",";
            insert_cart_string += huaJiaCartModel.getCount() + ",";
            insert_cart_string += huaJiaCartModel.getTotalPrice() + ")";
            string update_medicine_string = "update [t_medicine] set stockCount = stockCount -" + huaJiaCartModel.getCount() + " where medicineId=" + huaJiaCartModel.getMedicineId();
            string[] sqlStrings = new string[2]{insert_cart_string,update_medicine_string};
            if (!db.ExecuteSQL(sqlStrings))
            {
                this.errMessage = "添加药品销售信息时发生了错误！";
                return false;
            }
            return true;
        }

       
        public static int GetTotalCountInCart(string username)
        {
            string sqlString = "select sum(count) as totalCount from [huajia_cart_view] where username=" + SqlString.GetQuotedString(username);
            int totalCount = 0;
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                totalCount = Convert.ToInt32(ds.Tables[0].Rows[0]["totalCount"]);
            return totalCount;
        }
        public static float GetTotalPriceInCart(string username)
        {
            float totalPrice = 0.0f;
            string sqlString = "select sum(totalPrice) as totalPrice from [huajia_cart_view] where username=" + SqlString.GetQuotedString(username);
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                totalPrice = Convert.ToSingle(ds.Tables[0].Rows[0]["totalPrice"]);

            return totalPrice;
        }
        public static bool AddMedicineSellInfoInCart(string huajia_serial_no, string username)
        {
            bool isSuccessful = true;
           
            return isSuccessful;
        }
    }

}
