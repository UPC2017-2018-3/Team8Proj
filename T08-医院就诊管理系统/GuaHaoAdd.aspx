<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuaHaoAdd.aspx.cs" Inherits="GuaHaoAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script language=javascript>
     function seltime(inputName)
     {
	window.open('seltime.aspx?InputName='+inputName+'','','width=250,height=220,left=360,top=250,scrollbars=yes');  
     }
   </script>
</head>
<body>
     <form method="post" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 14px; width: 502px;">
          <img src="images/ADD.gif" width=14px height=14px>挂号信息管理--&gt;病人挂号登记</td>
        </tr>
        <tr>
        <td style="height: 42px">
            <br />
            姓名：
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name"
                ErrorMessage=" 请输入姓名！"></asp:RequiredFieldValidator><br />
            <br />
            性别：
            <asp:DropDownList ID="Sex" runat="server">
                <asp:ListItem>男</asp:ListItem>
                <asp:ListItem>女</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            年龄：
            <asp:TextBox ID="Age" runat="server" Width="45px"></asp:TextBox>岁<br />
            <br />
            &nbsp;挂号科目：
            <asp:DropDownList ID="SubjectId" runat="server" DataSourceID="SubjectDataSource" DataTextField="subjectName" DataValueField="subjectId" OnSelectedIndexChanged="SubjectId_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            &nbsp;挂号费：
            <asp:Label ID="Money" runat="server" ForeColor="Red"></asp:Label>
            元<br />
            <br />
            &nbsp;
            <asp:Button ID="Btn_GuaHao" runat="server" Text="挂号" OnClick="Btn_GuaHao_Click" /></td>
       </tr>
     </table>
         &nbsp;&nbsp;
         <asp:SqlDataSource ID="SubjectDataSource" runat="server" ConnectionString="Data Source=.;Initial Catalog=Hospital;Integrated Security=True"
             ProviderName="System.Data.SqlClient" SelectCommand="SELECT [subjectId], [subjectName] FROM [t_subject]">
         </asp:SqlDataSource>
    </form>
</body>
</html>
