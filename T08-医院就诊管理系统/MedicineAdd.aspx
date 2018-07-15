<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MedicineAdd.aspx.cs" Inherits="MedicineAdd" %>

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
          <img src="images/ADD.gif" width=14px height=14px>药品库房管理--&gt;添加药品信息</td>
        </tr>
        <tr>
        <td style="height: 42px">
            <br />
            药品名称：
            <asp:TextBox ID="MedicineName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="MedicineName"
                ErrorMessage=" 请输入药品名称！"></asp:RequiredFieldValidator><br />
            <br />
            药品单价：
            <asp:TextBox ID="Price" runat="server" Width="80px"></asp:TextBox>
            元<br />
            <br />
            药品数量：
            <asp:TextBox ID="StockCount" runat="server" Width="81px"></asp:TextBox><br />
            <br />
            药品单位：
            <asp:TextBox ID="Unit" runat="server" Width="81px"></asp:TextBox><br />
            <br />
            批准文号：
            <asp:TextBox ID="Pzwh" runat="server"></asp:TextBox><br />
            <br />
            药物成分：
            <asp:TextBox ID="Ingredient" runat="server" Height="54px" TextMode="MultiLine" Width="185px"></asp:TextBox><br />
            <br />
            药品功效：
            <asp:TextBox ID="Efficacy" runat="server" Height="54px" TextMode="MultiLine" Width="185px"></asp:TextBox><br />
            <br />
            <br />
            使用方法：<asp:TextBox ID="Usage" runat="server" Height="54px" TextMode="MultiLine"
                Width="185px"></asp:TextBox><br />
            <br />
            &nbsp;
            <asp:Button ID="Btn_Add" runat="server" Text="添加" OnClick="Btn_GuaHao_Click" /></td>
       </tr>
     </table>
         &nbsp;&nbsp;
    </form>
</body>
</html>
