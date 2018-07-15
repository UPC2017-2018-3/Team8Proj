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

namespace Hospital
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!Object.Equals(Request.Cookies["username"], null))
                {
                    HttpCookie adminUserNameCookie = Request.Cookies["username"];
                    this.adminUserName.Text = adminUserNameCookie.Value;
                }

                this.Validator.Attributes.Add("onkeypress","if(event.keyCode==13){document.all.Btn_Login.click();return false;}");
            }
        }

        protected void ChangeCode_Click(object sender, ImageClickEventArgs e)
        {
            this.ChangeCode.ImageUrl = "Validate.aspx";
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            if (String.Compare(Session["Code"].ToString(), this.Validator.Text, true) != 0)
            {
                Response.Write("<script>alert('对不起,你输入的验证码不正确!');</script>");
                return; 
            }
            AdminModel admin = new AdminModel();
            admin.setUsername(this.adminUserName.Text);
            admin.setPassword(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.adminPassword.Text.Trim(), "MD5").ToString());
            AdminLogic adminLogic = new AdminLogic();
            if (adminLogic.checkAdmin(admin)) 
            {
                CreateCookie();
                Session["username"] = admin.getUsername();
                Session.Timeout = 10;
                Response.Redirect("main.aspx");
            }
            else 
            {
                Response.Write("<script>alert('" + adminLogic.getErrMessage() + "');</script>");
            }
           
        }

      
        protected void Btn_Cancle_Click(object sender, EventArgs e)
        {
            this.adminUserName.Text = "";
            this.adminPassword.Text = "";
            this.Validator.Text = "";
            this.ChangeCode.ImageUrl = "Validate.aspx";
        }

        private void CreateCookie()
        {
            HttpCookie adminUserNameCookie = new HttpCookie("username");
            adminUserNameCookie.Value = this.adminUserName.Text;
            adminUserNameCookie.Expires = DateTime.MaxValue;
            Response.AppendCookie(adminUserNameCookie);
        }
}

}
