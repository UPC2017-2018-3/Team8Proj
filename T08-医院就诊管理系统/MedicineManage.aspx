<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicineManage.aspx.cs" Inherits="MedicineManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
<link href="css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form method="post" id="frmAnnounce" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 14px; width: 600px;">
          <img src="images/list.gif" width=14px height=14px>药品库房管理--&gt;药品信息管理</td>
        </tr>
        <tr>
        <td style="width: 600px;"　valign=top>
            药品名称：<asp:TextBox ID="MedicineName" runat="server" Width="141px"></asp:TextBox>&nbsp; &nbsp;
              <asp:Button ID="Btn_Query" runat="server" OnClick="Btn_Query_Click" Text="查询" /><br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px"
                CellPadding="3" CellSpacing="2"
                Width="594px" DataSourceID="MedicineDataSource" OnPageIndexChanging="GridView1_PageIndexChanging">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:BoundField DataField="medicineName" HeaderText="药品名称" SortExpression="medicineName" />
                    <asp:BoundField DataField="price" HeaderText="药品单价" SortExpression="price" />
                    <asp:BoundField DataField="stockCount" HeaderText="药品库存" SortExpression="stockCount" />
                    <asp:BoundField DataField="unit" HeaderText="药品单位" SortExpression="unit" />
                    <asp:BoundField DataField="pzwh" HeaderText="批准文号" SortExpression="pzwh" />

                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="MedicineDataSource" runat="server" ConnectionString="Data Source=.;Initial Catalog=Hospital;Integrated Security=True"
                ProviderName="System.Data.SqlClient" SelectCommand="SELECT  * FROM [t_medicine]">
            </asp:SqlDataSource>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        </tr>
      </table>
    </form>
</body>
</html>