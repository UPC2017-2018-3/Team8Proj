<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>左边菜单</title>
	<style type=text/css>
body  { background:#799AE1; margin:0px; font:9pt 宋体; }
table  { border:0px; }
td  { font:normal 12px 宋体; }
img  { vertical-align:bottom; border:0px; }
a  { font:normal 12px 宋体; color:#000000; text-decoration:none; }
a:hover  { color:#428EFF;text-decoration:underline; }
.sec_menu  { border-left:1px solid white; border-right:1px solid white; border-bottom:1px solid white; overflow:hidden; background:#D6DFF7; }
.menu_title  { }
.menu_title span  { position:relative; top:2px; left:8px; color:#215DC6; font-weight:bold; }
.menu_title2  { }
.menu_title2 span  { position:relative; top:2px; left:8px; color:#428EFF; font-weight:bold; }
</style>
<SCRIPT language=javascript>
function showsubmenu(sid)
{
whichEl = eval("submenu" + sid);
if (whichEl.style.display == "none")
{
eval("submenu" + sid + ".style.display=\"\";");
}
else
{
eval("submenu" + sid + ".style.display=\"none\";");
}
}
</SCRIPT>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/title_bg_quit.gif"  ><span><a href="desk.aspx" target="mainFrame"><b>管理首页</b></a> | <a href="logout.aspx" target="_parent"><b>退出</b></a></span> </td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20"></td>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>
      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/admin_left_1.gif" id="menuTitle1" onclick="showsubmenu(1)"><span>挂号管理</span> </td>
        </tr>
        <tr>
          <td style="display:" id='submenu1'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
		         <tr>
                  <td height="20"><a href="GuaHaoAdd.aspx" target="mainFrame">病人挂号登记</a></td>
                </tr>
                <tr>
                  <td height="20"><a href="GuaHaoQuery.aspx" target="mainFrame">挂号信息查询</a></td>
                </tr>
               
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20">&nbsp;</td>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>
      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/admin_left_2.gif" id="Td4" onclick="showsubmenu(2)"><span>就诊管理</span> </td>
        </tr>
        <tr>
          <td style="display:" id='Td7'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                   <td height="20"><a href="JiuzhenAdd.aspx" target="mainFrame">就诊信息查询</a></td>
                </tr>
               
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20">&nbsp;</td>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>

     <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/admin_left_2.gif" id="Td1" onclick="showsubmenu(2)"><span>药品划价管理</span> </td>
        </tr>
        <tr>
          <td style="display:" id='submenu2'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20"><a href="HuaJiaAdd.aspx" target="mainFrame">药品划价收费</a></td>
                </tr>
               
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20">&nbsp;</td>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>

      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/admin_left_2.gif" id="Td2" onclick="showsubmenu(2)"><span>住院管理</span> </td>
        </tr>
        <tr>
          <td style="display:" id='Td3'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20"><a href="PatientSignIn.aspx" target="mainFrame">病人住院登记</a></td>
                </tr>
                
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20">&nbsp;</td>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>

      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
          <td height="25" class="menu_title" onmouseover="this.className='menu_title2';" onmouseout="this.className='menu_title';" background="images/admin_left_2.gif" id="Td5" onclick="showsubmenu(2)"><span>药品库房管理</span> </td>
        </tr>
        <tr>
          <td style="display:" id='Td6'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                  <td height="20"><a href="MedicineAdd.aspx" target="mainFrame">添加新药品</a></td>
                </tr>
                <tr>
                  <td height="20"><a href="MedicineManage.aspx" target="mainFrame">药品信息调整</a></td>
                </tr>
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>

      <table cellpadding="0" cellspacing="0" width="158" align="center">
        <tr>
        </tr>
        <tr>
          <td style="display:" id='submenu5'><div class="sec_menu" style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                </tr>
              </table>
          </div></td>
        </tr>
        <tr>
          <td><div  style="width:158">
              <table cellpadding="0" cellspacing="0" align="center" width="135">
                <tr>
                </tr>
              </table>
          </div></td>
        </tr>
      </table>
      
    </div>
    </form>
</body>
</html>