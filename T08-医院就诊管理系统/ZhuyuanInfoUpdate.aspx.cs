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

using Hospital.Model;
using Hospital.Logic;

public partial class ZhuyuanInfoUpdate : System.Web.UI.Page
{
    public void InitView()
    {
        int t_zhuyuan_id = Int32.Parse(Request.QueryString["t_zhuyuan_id"]);
        ZhuyuanModel zhuyuanModel = ZhuyuanLogic.GetZhuyuanInfoById(t_zhuyuan_id);
        this.Name.Text = zhuyuanModel.getName();
        this.Sex.Text = zhuyuanModel.getSex();
        this.Age.Text = zhuyuanModel.getAge().ToString();
        this.RoomNo.Text = zhuyuanModel.getRoomNo();
        this.ArriveTime.Text = zhuyuanModel.getArriveTime().ToString();
    }

    protected void Btn_SignOut_Click(object sender, EventArgs e)
    {
        int t_zhuyuan_id = Int32.Parse(Request.QueryString["t_zhuyuan_id"]);
        float money = Convert.ToSingle(this.Money.Text);
        ZhuyuanLogic zhuyuanLogic = new ZhuyuanLogic();
        if (zhuyuanLogic.UpdateZhuyuanInfo(t_zhuyuan_id, money))
            Response.Write("<script>alert('病人成功办理出院！');location.href='PatientQuery.aspx';</script>");
    }
    protected void Btn_Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("PatientQuery.aspx");
    }
}
