<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ZhuyuanInfoUpdate.aspx.cs" Inherits="ZhuyuanInfoUpdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="Form1" method="post" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 13px; width: 502px;">
          <img src="images/edit.gif" width=14px height=14px>住院管理--&gt;病人出院登记</td>
        </tr>
        <tr>
        <td style="height: 42px">
            <br />
            姓名：&nbsp;
            <asp:Label ID="Name" runat="server" Text="Label"></asp:Label><br />
            <br />
            性别：&nbsp;
            <asp:Label ID="Sex" runat="server" Text="Label"></asp:Label><br />
            <br />
            年龄：
            <asp:Label ID="Age" runat="server" Text="Label"></asp:Label>岁<br />
            <br />
            病房号：
            <asp:Label ID="RoomNo" runat="server" Text="Label"></asp:Label><br />
            <br />
            入院时间：<asp:Label ID="ArriveTime" runat="server" Text="Label"></asp:Label><br />
            <br />
            住院费：<asp:TextBox ID="Money" runat="server" Width="105px"></asp:TextBox><br />
            <br />
            &nbsp;
            <asp:Button ID="Btn_SignOut" runat="server" Text="出院登记" OnClick="Btn_SignOut_Click" />
            <asp:Button ID="Btn_Back" runat="server" OnClick="Btn_Back_Click" Text="返回" /></td>
       </tr>
     </table>
         &nbsp;&nbsp;
    </form>
</body>
</html>
