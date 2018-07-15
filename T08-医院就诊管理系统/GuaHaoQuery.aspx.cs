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

public partial class GuaHaoQuery : System.Web.UI.Page
{
  
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string name = this.Name.Text;
        string starttime = this.StartTime.Text;
        string endtime = this.EndTime.Text;

        GuaHaoLogic guahaoLogic = new GuaHaoLogic();
        this.GridView1.DataSourceID = null;
        this.GridView1.DataSource = guahaoLogic.QueryGuaHaoInfo(name, starttime, endtime);
        this.GridView1.PageIndex = e.NewPageIndex;
        this.GridView1.DataBind();
    }

    
    protected void Btn_Query_Click(object sender, EventArgs e)
    {
        string name = this.Name.Text;
        string starttime = this.StartTime.Text;
        string endtime = this.EndTime.Text;

        GuaHaoLogic guahaoLogic = new GuaHaoLogic();
        this.GridView1.DataSourceID = null;
        this.GridView1.DataSource = guahaoLogic.QueryGuaHaoInfo(name, starttime, endtime);
        this.GridView1.PageIndex = 0;
        this.GridView1.DataBind();

    }
}
