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
    /// HuaJiaCartModel 的摘要说明:关系映射数据库中的t_huajia_cart数据表
    /// </summary>
    public class HuaJiaCartModel
    {
        private int id;
        private string username;
        private int medicineId;
        private float price;
        private int count;
        private float totalPrice;

        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }
        public void setUsername(string username) { this.username = username; }
        public string getUsername() { return this.username; }
        public void setMedicineId(int medicineId) { this.medicineId = medicineId; }
        public int getMedicineId() { return this.medicineId; }
        public void setPrice(float price) { this.price = price; }
        public float getPrice() { return this.price; }
        public void setCount(int count) { this.count = count; }
        public int getCount() { return this.count; }
        public void setTotalPrice(float totalPrice) { this.totalPrice = totalPrice; }
        public float getTotalPrice() { return this.totalPrice; }

        public HuaJiaCartModel()
        {
            id = 0;
            username = "";
            medicineId = 0;
            price = 0.0f;
            count = 0;
            totalPrice = 0;
        }
    }

}
