<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientSignIn.aspx.cs" Inherits="PatientSignIn" %>

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
     <form id="Form1" method="post" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 13px; width: 502px;">
          <img src="images/ADD.gif" width=14px height=14px>住院管理--&gt;病人住院登记</td>
        </tr>
        <tr>
        <td style="height: 42px">
            <br />
            姓名：
            <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name"
                ErrorMessage=" 请输入姓名！"></asp:RequiredFieldValidator><br />
            <br />
            性别：&nbsp;
            <asp:DropDownList ID="Sex" runat="server" Width="44px">
                <asp:ListItem>男</asp:ListItem>
                <asp:ListItem>女</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            年龄：
            <asp:TextBox ID="Age" runat="server" Width="47px"></asp:TextBox>岁<br />
            <br />
            病房号：
            <asp:TextBox ID="RoomNo" runat="server" Width="81px"></asp:TextBox><br />
            <br />
            &nbsp;
            <asp:Button ID="Btn_Add" runat="server" Text="登记" OnClick="Btn_GuaHao_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                DataSourceID="SqlDataSource1" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" Width="351px">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="center" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:HospitalConnectionString9 %>" 
                SelectCommand="SELECT [name], [sex], [age], [roomNo] FROM [t_zhuyuan]">
            </asp:SqlDataSource>
            
            </td>
       </tr>
     </table>
         &nbsp;&nbsp;
    </form>
</body>
</html>
