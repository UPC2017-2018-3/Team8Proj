using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Hospital.Logic;
using Hospital.Model;

public partial class GuaHaoAdd : System.Web.UI.Page
{
    
    
    protected void Btn_GuaHao_Click(object sender, EventArgs e)
    {
        GuaHaoModel guaHaoModel = new GuaHaoModel();
        guaHaoModel.setName(this.Name.Text);
        guaHaoModel.setSex(this.Sex.SelectedValue);
        guaHaoModel.setAge(Int32.Parse(this.Age.Text));
        guaHaoModel.setSubjectId(Int32.Parse(this.SubjectId.SelectedValue));
        guaHaoModel.setOperator(Session["username"].ToString());

        GuaHaoLogic guahaoLogic = new GuaHaoLogic();
        if (guahaoLogic.AddGuaHaoInfo(guaHaoModel))
            Response.Write("<script>alert('挂号成功!');location.href='GuaHaoAdd.aspx';</script>");
    }
    protected void SubjectId_SelectedIndexChanged(object sender, EventArgs e)
    {
        int subjectId = Int32.Parse(this.SubjectId.SelectedValue);
        this.Money.Text = SubjectLogic.getGuaHaoMoneyById(subjectId).ToString();
    }
}
