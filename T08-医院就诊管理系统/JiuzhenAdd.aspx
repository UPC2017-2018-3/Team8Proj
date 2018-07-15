<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JiuzhenAdd.aspx.cs" Inherits="JiuzhenAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>无标题页</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script language="javascript">
        function seltime(inputName) {
            window.open('seltime.aspx?InputName=' + inputName + '', '', 'width=250,height=220,left=360,top=250,scrollbars=yes');
        }
        <script type="text/javascript"> 
        window.location.href=window.location.href;
window.location.Reload();

</script>

   </script>
    <style type="text/css">
        #form1
        {
            height: 9567px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 13px; width: 502px;">
          <img src="images/ADD.gif" width=14px height=14px>就诊管理--&gt;添加患者信息</td>
        </tr>
        <tr>
        <td style="height: 42px">
            <br />
            患者id：
            <asp:TextBox ID="Id" runat="server" Width="92px"></asp:TextBox>
           
            <asp:Button ID="Button1" runat="server" style="margin-left: 63px" Text="查询" 
                onclick="Button1_Click" />
            <br />
            <br />
            患者姓名：
            <asp:TextBox ID="Name" runat="server" Width="78px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 患者性别：
            <asp:TextBox ID="Sex" runat="server" Width="81px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 患者年龄：
            <asp:TextBox ID="Age" runat="server" Width="81px"></asp:TextBox><br />
            <br />
            病情描述： 
             
            <asp:Button ID="Button2" runat="server" Text="添加" onclick="Button2_Click1" />
            <br />
            <asp:TextBox ID="Ingredient0" runat="server" Height="132px" TextMode="MultiLine" Width="564px"></asp:TextBox><br />
            <br />
            开药：<asp:DropDownList ID="MedicineId" runat="server" 
                DataSourceID="SqlDataSource4" DataTextField="medicineName" 
                DataValueField="medicineName"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                ConnectionString="<%$ ConnectionStrings:HospitalConnectionString3 %>" 
                SelectCommand="SELECT [medicineName] FROM [t_medicine]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                药品数目：<asp:TextBox ID="Count" runat="server" Width="62px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_Add" runat="server" Text="添加" OnClick="Btn_Add_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="打印" />
            <br />
            
            <br />
            <br />
            <br />
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" DataSourceID="SqlDataSource3" GridLines="Horizontal" 
                Width="419px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
                DataKeyNames="medicineName" Height="100px">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    
                    <asp:BoundField DataField="medicineName" HeaderText="药品名称" 
                        SortExpression="medicineName" ReadOnly="True" />
                    
                    <asp:BoundField DataField="count" HeaderText="药品数量" SortExpression="count" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            
            </asp:GridView>

              
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:HospitalConnectionString2 %>" 
                SelectCommand="SELECT [medicineName], [count] FROM [kaiyao]">
            </asp:SqlDataSource>


            <br />
            </td>
       </tr>
     </table>
         &nbsp;&nbsp;
    </form>
</body>
</html>
