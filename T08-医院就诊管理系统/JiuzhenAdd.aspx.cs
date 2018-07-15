using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using Hospital.Model;
using Hospital.Logic;

public partial class JiuzhenAdd : System.Web.UI.Page
{
    string connectionstr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
   
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        int b= Int32.Parse(Id.Text);
        string sql = "select * from [t_guahao] where id ="+b ;
        SqlConnection con = new SqlConnection(connectionstr);
        DataSet ds = new DataSet();
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        adapter.Fill(ds);
        Age.Text = ds.Tables[0].Rows[0]["age"].ToString();
        Sex.Text = ds.Tables[0].Rows[0]["sex"].ToString();
        Name.Text = ds.Tables[0].Rows[0]["name"].ToString();
        con.Close();
    }
   

    protected void Btn_Add_Click(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection("Data Source=BOYUUSE-JVPLVI0;Initial Catalog=Hospital;Persist Security Info=True;User ID=sa;Password=123456"))
        {
            //int co = Int32.Parse(Request.QueryString["Count"]);
            int co = Int32.Parse(Count.Text);
            //string mn = Request.Form.Get("MedicineId.SelectedValue");
            string mn = MedicineId.SelectedValue;
            string sql = "insert into kaiyao (medicineName,count) values ('" + mn + "','" + co + "')";
            //SqlConnection con = new SqlConnection(connectionstr);
            DataSet ds = new DataSet();
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);

            conn.Close();
            Response.AddHeader("Refresh", "0"); 

        }
       

    }


 

    protected void Button2_Click1(object sender, EventArgs e)
    {
        using (SqlConnection conn = new SqlConnection("Data Source=BOYUUSE-JVPLVI0;Initial Catalog=Hospital;Persist Security Info=True;User ID=sa;Password=123456"))
        {

            int id = Int32.Parse(Id.Text);
            string a = Ingredient0.Text;
            string sql = "insert into bqmsb (id,bqms) values ('" + id + "','" + a + "')";
            DataSet ds = new DataSet();
            conn.Open();


            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);

            //SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Close();
            Response.Write("<script>alert('添加成功!');location.href='JiuzhenAdd.aspx';</script>");


        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string sql = "delete from [kaiyao]";
        SqlConnection con = new SqlConnection(connectionstr);
        DataSet ds = new DataSet();
        con.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        adapter.Fill(ds);
        con.Close();
        Response.Write("<script>alert('就诊完成');</script>");
        Response.AddHeader("Refresh", "0"); 
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}