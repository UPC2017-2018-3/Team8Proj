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
    /// GuaHaoModel 的摘要说明:关系影射数据库中的挂号信息表
    /// </summary>
    /// 
    public class GuaHaoModel
    {
      
        private int id;
        private string name;
        private string sex;
        private int age;
        private int subjectId;
        private DateTime operateTime;
        private string Operator;

        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void setSex(string sex) { this.sex = sex; }
        public string getSex() { return this.sex; }
        public void setAge(int age) { this.age = age; }
        public int getAge() { return this.age; }
        public void setSubjectId(int subjectId) { this.subjectId = subjectId; }
        public int getSubjectId() { return this.subjectId; }
        public void setOperateTime(DateTime operatorTime) { this.operateTime = operateTime; }
        public DateTime getOperateTime() { return this.operateTime; }
        public void setOperator(string Operator) { this.Operator = Operator; }
        public string getOperator() { return this.Operator; }

        public GuaHaoModel()
        {
            id = age = subjectId = 0;
            name = sex = Operator = "";
            operateTime = DateTime.Now;
        }
    }
}

