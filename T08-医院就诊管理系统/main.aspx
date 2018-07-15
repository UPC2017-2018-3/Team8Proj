<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="main.aspx.cs" Inherits="main" %>
<%@ Register Src="UserControl/WebHeadControl.ascx" TagName="WebHeadControl" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<style type="text/css">
A:visited{TEXT-DECORATION:none;color : 000000}
A:link{text-decoration:none;color : 000000}
A:hover{TEXT-DECORATION:none;color : 04266D}
</style>
    <title>系统管理----医院就诊管理系统</title>
</head>
<body BGCOLOR=#FFFFFF LEFTMARGIN=0 TOPMARGIN=0 background="images/">
    <form id="form1" runat="server">
    <div>
<TABLE WIDTH=770 BORDER=0 CELLPADDING=0 CELLSPACING=0 align="center">
	<TR>
		<TD COLSPAN=2 style="height: 59px">
            &nbsp;</TD>
	</TR>
	<TR>
		<TD COLSPAN=2 style="background-color: #799AE1; font-size: 12px; color: white; height: 32px;">
            <table cellspacing="0">
                <tr>
                    <td style="background:#799AE1;width: 806px; height: 18px;">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 操作员：<asp:Label ID="Operator" runat="server"
                Text="Label"></asp:Label></td>
                    <td align="right" style="background:#799AE1;width: 650px; height: 18px;">
                        登陆时间：<asp:Label ID="LoginTime" runat="server" Text="Label"></asp:Label>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    </td>
                </tr>
            </table>
        </TD>
	</TR>
	
	<TR>
<TD valign="top" background="images/default_6.gif" align="center">
        <iframe style="height: 600px; width: 158px;" frameborder="0" name="menu" scrolling="no" src="menu.aspx" width="158">
        </iframe>
			</TD>
		<TD valign="top" style="width: 477px; background-image: url(images/default_5.gif);">			
<iframe style="height: 600px; width: 624px;" frameborder="0" name="mainFrame" scrolling="no" src="desk.aspx" width="586">
        </iframe>
        </TD>
	</TR>
        <tr>
        <td colspan=2 style="height: 19px">
            &nbsp;</td>
        </tr>
</TABLE>
   		
    </div>
    </form>
  

</body>
</html>
