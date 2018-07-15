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

public partial class PatientSignIn : System.Web.UI.Page
{
    protected void Btn_GuaHao_Click(object sender, EventArgs e)
    {
        string name = this.Name.Text;
        string sex = this.Sex.SelectedValue;
        int age = Int32.Parse(this.Age.Text);
        string roomNo = this.RoomNo.Text;

        ZhuyuanModel zhuyuanModel = new ZhuyuanModel();
        zhuyuanModel.setName(name);
        zhuyuanModel.setSex(sex);
        zhuyuanModel.setAge(age);
        zhuyuanModel.setRoomNo(roomNo);
        zhuyuanModel.setCheckinOperator(Session["username"].ToString());

        ZhuyuanLogic zhuyuanLogic = new ZhuyuanLogic();
        if (zhuyuanLogic.AddZhuyuanInfo(zhuyuanModel))
            Response.Write("<script>alert('病人住院信息登记成功！');location.href='PatientSignIn.aspx';</script>");
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
