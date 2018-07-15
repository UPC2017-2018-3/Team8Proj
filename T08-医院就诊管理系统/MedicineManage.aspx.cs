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

public partial class MedicineManage : System.Web.UI.Page
{
    protected void Btn_Query_Click(object sender, EventArgs e)
    {
        string medicineName = this.MedicineName.Text;
        this.GridView1.DataSourceID = null;
        this.GridView1.DataSource = MedicineLogic.QueryMedicineInfo(medicineName);
        this.GridView1.PageIndex = 0;
        this.GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        string medicineName = this.MedicineName.Text;
        this.GridView1.DataSourceID = null;
        this.GridView1.DataSource = MedicineLogic.QueryMedicineInfo(medicineName);
        this.GridView1.PageIndex = e.NewPageIndex;
        this.GridView1.DataBind();
    }
}
