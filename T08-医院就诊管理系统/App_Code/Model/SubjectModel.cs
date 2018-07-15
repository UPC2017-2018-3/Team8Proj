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
    /// SubjectModel 的摘要说明:关系映射数据库中的科目信息表
    /// </summary>
    public class SubjectModel
    {
      
        private int subjectId;
        private string subjectName;
        private float guahaoMoney;

        public void setSubjectId(int subjectId) { this.subjectId = subjectId; }
        public int getSubjectId() { return this.subjectId; }
        public void setSubjectName(string subjectName) { this.subjectName = subjectName; }
        public string getSubjectName() { return this.subjectName; }
        public void setGuahaoMoney(float guahaoMoney) { this.guahaoMoney = guahaoMoney; }
        public float getGuahaoMoney() { return this.guahaoMoney; }

        public SubjectModel()
	{
        subjectId = 0;
        subjectName = "";
        guahaoMoney = 0.0f;
	}
    }

}
