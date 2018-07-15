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
    /// ZhuyuanModel 的摘要说明：关系影射数据库中的住院信息表
    /// </summary>
    public class ZhuyuanModel
    {
        private int t_zhuyuan_id;
        private string name;
        private string sex;
        private int age;
        private string roomNo;
        private DateTime arriveTime;
        private int isLeave;
        private DateTime leaveTime;
        private float money;
        private string checkinOperator;
        private string checkoutOperator;

        public void setT_zhuyuan_id(int t_zhuyuan_id) { this.t_zhuyuan_id = t_zhuyuan_id; }
        public int getT_zhuyuan_id() { return this.t_zhuyuan_id; }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void setSex(string sex) { this.sex = sex; }
        public string getSex() { return this.sex; }
        public void setAge(int age) { this.age = age; }
        public int getAge() { return this.age; }
        public void setRoomNo(string roomNo) { this.roomNo = roomNo; }
        public string getRoomNo() { return this.roomNo; }
        public void setArriveTime(DateTime arriveTime) { this.arriveTime = arriveTime; }
        public DateTime getArriveTime() { return this.arriveTime; }
        public void setIsLeave(int isLeave) { this.isLeave = isLeave; }
        public int getIsLeave() { return this.isLeave; }
        public void setLeaveTime(DateTime leaveTime) { this.leaveTime = leaveTime; }
        public DateTime getLeaveTime() { return this.leaveTime; }
        public void setMoney(float money) { this.money = money; }
        public float getMoney() { return this.money; }
        public void setCheckinOperator(string checkinOperator) { this.checkinOperator = checkinOperator; }
        public string getCheckinOperator() { return this.checkinOperator; }
        public void setCheckoutOperator(string checkoutOperator) { this.checkoutOperator = checkoutOperator; }
        public string getCheckoutOperator() { return this.checkoutOperator; }
        public ZhuyuanModel()
        {
            t_zhuyuan_id = 0;
            name = "";
            sex = "";
            age = 0;
            roomNo = "";
            arriveTime = DateTime.Now;
            isLeave = 0;
            leaveTime = DateTime.Now;
            money = 0.0f;
            checkinOperator = "";
            checkoutOperator = "";
        }
    }

}
