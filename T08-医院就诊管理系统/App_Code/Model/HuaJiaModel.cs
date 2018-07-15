using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Hospital.Model
{
    /// <summary>
    /// HuaJiaModel 的摘要说明:关系映射数据库中的划价信息表
    /// </summary>
    public class HuaJiaModel
    {
        private int id;
        private string huajia_serial_no;
        private int medicineId;
        private float price;
        private int count;
        private float totalPrice;
        private DateTime operateTime;
        private string Operator;

        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }
        public void setHuajia_serial_no(string huajia_serial_no) { this.huajia_serial_no = huajia_serial_no; }
        public string getHuajia_serial_no() { return this.huajia_serial_no; }
        public void setMedicineId(int medicineId) { this.medicineId = medicineId; }
        public int getMedicineId() { return this.medicineId; }
        public void setPrice(float price) { this.price = price; }
        public float getPrice() { return this.price; }
        public void setCount(int count) { this.count = count; }
        public int getCount() { return this.count; }
        public void setTotalPrice(float totalPrice) { this.totalPrice = totalPrice; }
        public float getTotalPrice() { return this.totalPrice; }
        public void setOperateTime(DateTime operateTime) { this.operateTime = operateTime; }
        public DateTime getOperateTime() { return this.operateTime; }
        public void setOperator(string Operator) { this.Operator = Operator; }
        public string getOperator() { return this.Operator; }

        public HuaJiaModel()
        {
            id = 0;
            huajia_serial_no = "";
            medicineId = 0;
            price = 0.0f;
            count = 0;
            totalPrice = 0.0f;
            operateTime = DateTime.Now;
            Operator = "";
        }
    }

}
