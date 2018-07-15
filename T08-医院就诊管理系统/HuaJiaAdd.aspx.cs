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
using System.Data;
using System.Data.SqlClient;

using Hospital.Model;
using Hospital.Logic;

public partial class HuaJiaAdd : System.Web.UI.Page
{
    string connectionstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            AdminModel adminModel = (new AdminLogic()).getAdminInfo(Session["username"].ToString());
            
            DataSet medicineDs = MedicineLogic.getAllMedicineInfo();
            for (int i = 0; i < medicineDs.Tables[0].Rows.Count; i++)
            {
                DataRow dr = medicineDs.Tables[0].Rows[i];
                ListItem li = new ListItem(dr["medicineId"].ToString() + "-" + dr["medicineName"].ToString(), dr["medicineId"].ToString());
                this.MedicineId.Items.Add(li);
            }
            InitMedicineCartInfo();
        }
        
    }

    
    protected void InitMedicineCartInfo()
    {
        string username = Session["username"].ToString();
        DataSet huajia_cart_ds = HuaJiaCartLogic.GetHuaJiaCartInfo(username);
        this.GridView1.DataSource = huajia_cart_ds;
        this.GridView1.DataBind();
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        InitMedicineCartInfo();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        InitMedicineCartInfo();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        
        int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Values[0].ToString());
        HuaJiaCartLogic huaJiaCartLogic = new HuaJiaCartLogic();
        if(huaJiaCartLogic.DeleteHuaJiaCartInfo(id))
        {
            Response.Write("<script language=javascript>alert('成功删除药品划价销售信息！');</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + huaJiaCartLogic.getErrMessage() + "');</script>");
        }
        GridView1.EditIndex = -1;
        InitMedicineCartInfo();

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        InitMedicineCartInfo();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        
        int id = Int32.Parse(GridView1.DataKeys[e.RowIndex].Values[0].ToString());
        int count = Int32.Parse(((TextBox)GridView1.Rows[e.RowIndex].FindControl("Count")).Text);
        HuaJiaCartLogic huaJiaCartLogic = new HuaJiaCartLogic();
        if(huaJiaCartLogic.UpdateHuaJiaCartInfo(id,count))
        {
            Response.Write("<script language=javascript>alert('修改成功!');</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + huaJiaCartLogic.getErrMessage() + "');</script>");
        }
        GridView1.EditIndex = -1;
        InitMedicineCartInfo();

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
           
            e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#00ffee';");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");

        }
    }
    protected void Btn_Finished_Click(object sender, EventArgs e)
    {
        string sql = "delete from [t_huajia_cart]";
        SqlConnection con = new SqlConnection(connectionstr);
        DataSet ds = new DataSet();
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        adapter.Fill(ds);
        con.Close();
        Response.Write("<script>alert('缴费成功');</script>");
        Response.AddHeader("Refresh", "0"); 


        
    }
    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        
        HuaJiaCartModel huaJiaCartModel = new HuaJiaCartModel();
        huaJiaCartModel.setUsername(Session["username"].ToString());
        int medicineId = Int32.Parse(this.MedicineId.SelectedValue);
        huaJiaCartModel.setMedicineId(medicineId);
        float price = MedicineLogic.getPriceById(medicineId);
        huaJiaCartModel.setPrice(price);
        int count = Int32.Parse(this.Count.Text);
        huaJiaCartModel.setCount(count);
        float totalPrice = price * count;
        huaJiaCartModel.setTotalPrice(totalPrice);
        HuaJiaCartLogic huaJiaCartLogic = new HuaJiaCartLogic();
        if(huaJiaCartLogic.AddHuaJiaCartInfo(huaJiaCartModel))
            Response.Write("<script>alert('药品划价销售信息添加成功!');location.href='HuaJiaAdd.aspx';</script>");
        else
            Response.Write("<script>alert('" + huaJiaCartLogic.getErrMessage() + "');location.href='HuaJiaAdd.aspx';</script>");

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
