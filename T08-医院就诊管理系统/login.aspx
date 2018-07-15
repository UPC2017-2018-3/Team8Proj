<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Hospital.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head> <link rel="stylesheet" type="text/css" href="css/stylesheet.css">
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<style type="text/css">
A:visited{TEXT-DECORATION:none;color : 000000}
A:link{text-decoration:none;color : 000000}
A:hover{TEXT-DECORATION:none;color : 04266D}
    .auto-style2 {
        margin-top: 59px;
        height: 227px;
        width: 392px;
        }
    .auto-style10 {
        width: 120px;
        height: 19px;
    }
    .auto-style11 {
        height: 19px;
    }
    .auto-style14 {
        width: 120px;
        height: 20px;
    }
    .auto-style15 {
        height: 20px;
    }
    .auto-style16 {
        width: 367px;
        height: 23px;
    }
    .auto-style17 {
        width: 120px;
        height: 28px;
    }
    .auto-style18 {
        height: 28px;
    }
   .auto-style19{
       width:450px;
       height:219px;
       align:right;
        margin-left: 629px;
        margin-top: 150px;
    }
</style>
<title>系统登录----医院就诊管理系统</title>
</head>
<body style="background-color: #FFFFFF; background-image:url('images/p1.jpg')">

<form id=form1 runat=server>
<br><br><br>
    <div  class="auto-style19" style="background-color:rgba(102,102,153,0.2) " >
       <table align="right" cellpadding="0" cellspacing="0"  class="auto-style2" >
            <tr>
            <td></td>
            <td align="right" class="auto-style17" ><font face="华文中宋" size="4"><b>用　户 名：</b></font></td>
            <td width="247" valign="middle" class="auto-style18">
                <asp:TextBox ID="adminUserName" runat="server" Width="122px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adminUserName"
                    ErrorMessage=" 帐号不能为空!"></asp:RequiredFieldValidator></td>
          </tr>
			<tr>
            <td></td>
            <td align="right" class="auto-style10"><font face="华文中宋" size="4"><b>密　　 码：</b></font></td>
            <td width="247" valign="middle" class="auto-style11">
                <asp:TextBox ID="adminPassword" runat="server" TextMode="Password" Width="123px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="adminPassword"
                    ErrorMessage="密码不能为空!"></asp:RequiredFieldValidator></td>
          </tr>
			<tr>
             <td></td>
             <td align="right" class="auto-style17" ><font face="华文中宋" size="4"><b>验 证 码：</b></font></td>
			
            <td width="247" valign="middle" class="auto-style15">
			<p align="left">
                <asp:TextBox ID="Validator" runat="server" Width="62px"></asp:TextBox>
                <asp:ImageButton ID="ChangeCode" runat="server" CausesValidation="False" Height="20px"
                    ImageUrl="Validate.aspx" OnClick="ChangeCode_Click" ToolTip="看不清楚？点击图片换一个验证码"
                    Width="55px" />
            </td>
          </tr>
			<tr>
           <td></td>
            <td colspan=2 class="auto-style16">
			<p align="center">
                <asp:Button ID="Btn_Login" 
                    runat="server" OnClick="Btn_Login_Click" Text="登录" Height="24px" Width="43px" />
                &nbsp;&nbsp;
                <asp:Button ID="Btn_Cancle" runat="server" OnClick="Btn_Cancle_Click" Text="取消" 
                    Height="24px" Width="43px" /></td>
          </tr>
			          
        </table>
        </div>
</form>
</body>
</html>