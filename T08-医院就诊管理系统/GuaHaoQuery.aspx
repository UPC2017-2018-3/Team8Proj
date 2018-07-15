<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuaHaoQuery.aspx.cs" Inherits="GuaHaoQuery" %>

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
    <form method="post" id="frmAnnounce" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 14px; width: 600px;">
          <img src="images/list.gif" width=14px height=14px>挂号管理--&gt;挂号信息查询</td>
        </tr>
        <tr>
        <td style="width: 600px;"　valign=top>
            姓名:<asp:TextBox ID="Name" runat="server" Width="62px"></asp:TextBox>&nbsp; 开始时间:<asp:TextBox ID="StartTime" runat="server" Width="65px"></asp:TextBox>
              <input class="submit" name="Button" onclick="seltime('StartTime')" style="width: 30px"
                  type="button" value="选择" />结束时间:<asp:TextBox ID="EndTime" runat="server" Width="64px"></asp:TextBox>
              <input class="submit" name="Button" onclick="seltime('EndTime')" style="width: 30px"
                  type="button" value="选择" />
              <asp:Button ID="Btn_Query" runat="server" OnClick="Btn_Query_Click" Text="查询" /><br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                CellPadding="3" CellSpacing="2"
                Width="594px" DataSourceID="GuaHaoDataSource" OnPageIndexChanging="GridView1_PageIndexChanging">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="姓名" SortExpression="name" />
                    <asp:BoundField DataField="sex" HeaderText="性别" SortExpression="sex" />
                    <asp:BoundField DataField="age" HeaderText="年龄" SortExpression="age" />
                    <asp:BoundField DataField="subjectName" HeaderText="科目" SortExpression="subjectName" />
                    <asp:BoundField DataField="operateTime" HeaderText="挂号时间" SortExpression="operateTime" />
                    <asp:BoundField DataField="operator" HeaderText="操作员" SortExpression="operator" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="GuaHaoDataSource" runat="server" ConnectionString="Data Source=.;Initial Catalog=Hospital;Integrated Security=True"
                ProviderName="System.Data.SqlClient" SelectCommand="SELECT [name], [sex], [age], [subjectName], [operateTime], [operator] FROM [guahaoView]">
            </asp:SqlDataSource>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        </tr>
      </table>
    </form>
</body>
</html>