<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HuaJiaAdd.aspx.cs" Inherits="HuaJiaAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <LINK href="css/style.css" type="text/css" rel="stylesheet">
    <script type="text/javascript"> 
         window.location.href = window.location.href;
        window.location.Reload();
 
</script>
</head>
<body>
   <form method="post" id="frmAnnounce" runat="server">
      <table width=600 border=0 cellpadding=0 cellspacing=0 align="center">
        <tr style="color:blue;font-size:14px;">
	  <td style="height: 14px; width: 604px;">
          <img src="images/ADD.gif" width=14px height=14px>药品划价管理--&gt;药品划价</td>
        </tr>
        <tr>
	  <td style="height: 26px; width: 604px;">
          <br />
          你好，当前购买的药品信息如下：<br />
         <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                  CellPadding="4" DataKeyNames="id" 
                  ForeColor="#333333" GridLines="None" Width="603px" 
              OnRowDataBound="GridView1_RowDataBound" PageSize="8"  
              OnPageIndexChanging="GridView1_PageIndexChanging" 
              OnRowCancelingEdit="GridView1_RowCancelingEdit" 
              OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" 
              OnRowUpdating="GridView1_RowUpdating" 
              onselectedindexchanged="GridView1_SelectedIndexChanged" Height="16px">
                  <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                  <Columns>
                      
                      <asp:BoundField DataField="medicineId" HeaderText="药品编号" ReadOnly="True" SortExpression="medicineId" />
                      <asp:BoundField DataField="medicineName" HeaderText="药品名称" ReadOnly=true SortExpression="medicineName" />
                      <asp:BoundField DataField="price" HeaderText="药品单价" ReadOnly=true SortExpression="price" />
                      <asp:TemplateField HeaderText="商品数量">
                         <EditItemTemplate>
                             <asp:TextBox ID="Count" runat="server" Text='<%# Eval("count") %>'  Width="80"></asp:TextBox>
                         </EditItemTemplate>
                          <ItemTemplate>
                             <asp:Label ID="Label2" runat="server"><%# Eval("count") %></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>   
                      <asp:CommandField HeaderText="编辑" EditText="修改" UpdateText="更新" ShowEditButton="True" />
                      <asp:TemplateField HeaderText="删除" ShowHeader="False">
                         <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('确认要删除吗？');" 
                                        Text="删除"></asp:LinkButton>
                         </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
                  <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                  <EmptyDataTemplate>
                      对不起，当前没有药品销售信息!
                  </EmptyDataTemplate>
                  <EditRowStyle BackColor="#999999" />
                  <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                  <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                  <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                  <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
              </asp:GridView>
              <div align=right>
                <asp:Button ID="Btn_Finished" runat="server" OnClick="Btn_Finished_Click" Text="划价收费" /></div></td>
            </tr>
            <tr><td style="width: 604px">
                <br />
                添加新的药品信息：<br />
                <br />
                选择药品：&nbsp;<asp:DropDownList ID="MedicineId" runat="server"></asp:DropDownList><br />
                药品数目：<asp:TextBox ID="Count" runat="server" Width="72px"></asp:TextBox><br />
                <br />
                <asp:Button ID="Btn_Add" runat="server" OnClick="Btn_Add_Click" Text="添加" />
                </td></tr>
       &nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
