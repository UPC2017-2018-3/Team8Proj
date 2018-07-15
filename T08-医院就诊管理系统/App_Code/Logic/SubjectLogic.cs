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

/// <summary>
/// SubjectLogic 的摘要说明:关于医疗科目的业务逻辑处理
/// </summary>
public class SubjectLogic
{
    private string errMessage;
    public string getErrMessage() { return this.errMessage; }
	public SubjectLogic()
	{
        this.errMessage = "";
	}
    public static float getFirstGuaHaoMoney()
    {
        float firstGuaHaoMoney = 0.0f;
        string sqlString = "select top 1 guahaoMoney from [t_subject]";
        DataBase db = new DataBase();
        DataSet ds = db.GetDataSet(sqlString);
        if (ds.Tables[0].Rows.Count > 0)
            firstGuaHaoMoney = Convert.ToSingle(ds.Tables[0].Rows[0]["guahaoMoney"]);
        return firstGuaHaoMoney;
    }
    public static float getGuaHaoMoneyById(int subjectId)
    {
        float guahaoMoney = 0.0f;
        string sqlString = "select guahaoMoney from [t_subject] where subjectId=" + subjectId;
        DataBase db = new DataBase();
        DataSet ds = db.GetDataSet(sqlString);
        if (ds.Tables[0].Rows.Count > 0)
            guahaoMoney = Convert.ToSingle(ds.Tables[0].Rows[0]["guahaoMoney"]);
        return guahaoMoney;
    }
}
