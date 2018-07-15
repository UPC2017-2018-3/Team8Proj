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
    /// MedicineLogic 的摘要说明:关于药品的业务处理逻辑
    /// </summary>
    public class MedicineLogic
    {
        private string errMessage;
        public string getErrMessage() { return this.errMessage; }

        public MedicineLogic()
        {
            this.errMessage = "";
        }

       
        public static float getPriceById(int medicineId)
        {
            float price = 0.0f;
            string sqlString = "select price from [t_medicine] where medicineId=" + medicineId;
            DataBase db = new DataBase();
            DataSet ds = db.GetDataSet(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
                price = Convert.ToSingle(ds.Tables[0].Rows[0]["price"]);
            return price;
        }
        public static DataSet getAllMedicineInfo()
        {
            string sqlString = "select medicineId,medicineName from [t_medicine]";
            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);
        }
        public bool AddMedicineInfo(MedicineModel medicineModel)
        {
            string sqlString = "insert into [t_medicine] (medicineName,price,stockCount,unit,pzwh,ingredient,efficacy,usage) values (";
            sqlString += SqlString.GetQuotedString(medicineModel.getMedicineName()) + ",";
            sqlString += medicineModel.getPrice() + ",";
            sqlString += medicineModel.getStockCount() + ",";
            sqlString += SqlString.GetQuotedString(medicineModel.getUnit()) + ",";
            sqlString += SqlString.GetQuotedString(medicineModel.getPzwh()) + ",";
            sqlString += SqlString.GetQuotedString(medicineModel.getIngredient()) + ",";
            sqlString += SqlString.GetQuotedString(medicineModel.getEfficacy()) + ",";
            sqlString += SqlString.GetQuotedString(medicineModel.getUsage()) + ")";

            DataBase db = new DataBase();
            if (db.InsertOrUpdate(sqlString) < 0)
            {
                this.errMessage = "向系统加入新的药品信息发生了错误！";
                return false;
            }
            return true;
        }
        public static DataSet QueryMedicineInfo(string medicineName)
        {
            string sqlString = "select * from [t_medicine] where medicineName like '%" + medicineName + "%'";
            DataBase db = new DataBase();
            return db.GetDataSet(sqlString);
        }
        public static MedicineModel GetMedicineInfo(int medicineId)
        {
            MedicineModel medicineModel = null;
            
            return medicineModel;
        }
        public bool UpdateMedicineInfo(MedicineModel medicineModel)
        {
            string sqlString = "update [t_medicine] set medicineName=";
            sqlString += SqlString.GetQuotedString(medicineModel.getMedicineName()) + ",price=";
            sqlString += medicineModel.getPrice() + ",stockCount=";
            sqlString += medicineModel.getStockCount() + ",unit=";
            sqlString += SqlString.GetQuotedString(medicineModel.getUnit()) + ",pzwh=";
            sqlString += SqlString.GetQuotedString(medicineModel.getPzwh()) + ",ingredient=";
            sqlString += SqlString.GetQuotedString(medicineModel.getIngredient()) + ",efficacy=";
            sqlString += SqlString.GetQuotedString(medicineModel.getEfficacy()) + ",usage=";
            sqlString += SqlString.GetQuotedString(medicineModel.getUsage()) + " where medicineId=" + medicineModel.getMedicineId();

            DataBase db = new DataBase();
            if (db.InsertOrUpdate(sqlString) < 0)
            {
                this.errMessage = "更新药品信息发生了错误！";
                return false;
            }
            return true;
        }
    }
}

