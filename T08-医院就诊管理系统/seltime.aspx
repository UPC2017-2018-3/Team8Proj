<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML>
	<HEAD>
		<TITLE>日历</TITLE>
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<STYLE TYPE="text/css">
.normal{BACKGROUND: #C1DA90}
.today {font-weight:bold;BACKGROUND: white}
.satday{color:green;BACKGROUND: #E2F3C0}
.sunday{color:red;BACKGROUND: #A8C373}
.days {font-size=12px;font-weight:bold;BACKGROUND: #A8C373}
		</STYLE>
		<LINK href="../css/style.css" type="text/css" rel="stylesheet">
		<SCRIPT LANGUAGE="JavaScript">

var months = new Array("一月", "二月", "三月",
"四月", "五月", "六月", "七月", "八月", "九月",
"十月", "十一月", "十二月");
var daysInMonth = new Array(31, 28, 31, 30, 31, 30, 31, 31,
30, 31, 30, 31);
var days = new Array("日","一", "二", "三",
"四", "五", "六");
function getDays(month, year) {
if (1 == month)
return ((0 == year % 4) && (0 != (year % 100))) ||
(0 == year % 400) ? 29 : 28;
else
return daysInMonth[month];
}

function getToday() {
this.now = new Date();
this.year = this.now.getFullYear();
this.month = this.now.getMonth();
this.day = this.now.getDate();
}


today = new getToday();

function newCalendar() {

today = new getToday();
var parseYear = parseInt(document.all.year
[document.all.year.selectedIndex].text);
var newCal = new Date(parseYear,
document.all.month.selectedIndex, 1);
var day = -1;
var startDay = newCal.getDay();
var daily = 0;
if ((today.year == newCal.getFullYear()) &&(today.month == newCal.getMonth()))
day = today.day;
var tableCal = document.all.calendar.tBodies.dayList;
var intDaysInMonth =getDays(newCal.getMonth(), newCal.getFullYear());
for (var intWeek = 0; intWeek < tableCal.rows.length;intWeek++)
for (var intDay = 0;intDay < tableCal.rows[intWeek].cells.length;intDay++)
{
var cell = tableCal.rows[intWeek].cells[intDay];
if ((intDay == startDay) && (0 == daily))
daily = 1;
if(day==daily)
cell.className = "today";
else if(intDay==6)
cell.className = "sunday";
else if (intDay==0)
cell.className ="satday";
else
cell.className="normal";

if ((daily > 0) && (daily <= intDaysInMonth))
{
cell.innerText = daily;
daily++;
}
else
cell.innerText = "";
}
}

function resetCalendar() {

today = new getToday();
var parseYear = parseInt(document.all.year
[document.all.year.selectedIndex].text);
var newCal = new Date(parseYear,
document.all.month.selectedIndex, 1);
var day = -1;
var startDay = newCal.getDay();
var daily = 0;
if ((today.year == newCal.getFullYear()) &&(today.month == newCal.getMonth()))
day = today.day;
var tableCal = document.all.calendar.tBodies.dayList;
var intDaysInMonth =getDays(newCal.getMonth(), newCal.getFullYear());
for (var intWeek = 0; intWeek < tableCal.rows.length;intWeek++)
for (var intDay = 0;intDay < tableCal.rows[intWeek].cells.length;intDay++)
{
var cell = tableCal.rows[intWeek].cells[intDay];
if ((intDay == startDay) && (0 == daily))
daily = 1;
if(day==daily)
cell.className = "normal";
else if(intDay==6)
cell.className = "sunday";
else if (intDay==0)
cell.className ="satday";
else
cell.className="normal";

if ((daily > 0) && (daily <= intDaysInMonth))
{
cell.innerText = daily;
daily++;
}
else
cell.innerText = "";
}
}

function getDate() {
var sDate;

if ("TD" == event.srcElement.tagName)
if ("" != event.srcElement.innerText)
{
 var kss = '<%=Request.QueryString["InputName"]%>'
 var monthStr = document.all.month.value;
 var dateStr = event.srcElement.innerText;
  if (monthStr.length==1) monthStr = "0" + monthStr;
  if (dateStr.length==1) dateStr = "0" + dateStr;
 sDate = document.all.year.value + "-" + monthStr + "-" + dateStr ;
 var targetDiv=eval("opener.document.frmAnnounce."+kss);
 targetDiv.value=sDate;
 window.close();
}
}
		</SCRIPT>
	</HEAD>
	<BODY ONLOAD="newCalendar()" scroll="no" leftmargin="3" topmargin="3" bgcolor="#F0F9DF">
		<input type="hidden" name="ret" value="2003-5-18">
		<TABLE ID="calendar" cellspacing="1" cellpadding="0" border="0" width="100%">
			<THEAD>
				<TR>
					<td colspan="3" align="center">
						<SELECT ID="month" ONCHANGE="newCalendar()">
							<SCRIPT LANGUAGE="JavaScript">
for (var intLoop = 0; intLoop < months.length;intLoop++)
document.write("<OPTION VALUE= " + (intLoop + 1) + " " +(today.month == intLoop ?"Selected" : "") + ">" + months[intLoop]);
							</SCRIPT>
						</SELECT>
					</td>
					<td>&nbsp;</td>
					<td colspan="3" align="center">
						<SELECT ID="year" ONCHANGE="newCalendar()">
							<SCRIPT LANGUAGE="JavaScript">
for (var intLoop = today.year-50; intLoop < (today.year + 30);
intLoop++)
document.write("<OPTION VALUE= " + intLoop + " " +
(today.year == intLoop ?
"Selected" : "") + ">" +
intLoop);
							</SCRIPT>
						</SELECT>
					</td>
				</TR>
				<TR CLASS="days" align="center">
					<SCRIPT LANGUAGE="JavaScript">
document.write("<TD class=satday width=14%>" + days[0] + "</TD>");
for (var intLoop = 1; intLoop < days.length-1;intLoop++)
document.write("<TD >" + days[intLoop] + "</TD>");
document.write("<TD class=sunday>" + days[intLoop] + "</TD>");
					</SCRIPT>
				</TR>
			</THEAD>
			<TBODY ID="dayList" onclick='javascript:getDate()' ondblclick='javascript:getDate();doOk();'>
				<SCRIPT LANGUAGE="JavaScript">
for (var intWeeks = 0; intWeeks < 6; intWeeks++) {
document.write("<TR style='cursor:hand' align=center>");
for (var intDays = 0; intDays < days.length;intDays++)
document.write('<TD  width=14%  onmousedown="Javascript:doChangeColor()" id="id'+intWeeks+"_"+intDays+'"></TD>');
document.write("</TR>");
}
				</SCRIPT>
				<tr>
					<td colspan="7">&nbsp;</td>
				</tr>
			</TBODY>
		</TABLE>
		<table width="100%" cellspacing="0" cellpadding="1" border="0">
			<tr>
				<td height="1" bgcolor="#cccccc"></td>
			</tr>
			<tr>
				<td align="center"><input type="button" value="确 定" onclick="Javascript:doOk();"> <input type="hidden" name="txtValue" value="">
					<Input type="button" value="取 消" OnClick="Javascript:cancel();"></td>
			</tr>
		</table>
	</BODY>
</HTML>
<Script Language="JavaScript">
window.returnValue="";
function cancel() {
window.close();
}
function doChangeColor(){
if (event.srcElement.tagName=="TD"){
    var sValue=document.all("txtValue").value
   if(document.all(event.srcElement.id).innerText!=""){
     resetCalendar();
     if (sValue!=""){
       document.all(sValue).style.background="#CFF488";
      }
     event.srcElement.style.background="white";
     document.all("txtValue").value=event.srcElement.id;
    }
 }

}
</Script>