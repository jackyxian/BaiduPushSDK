using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_6_查询定时消息的发送记录 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string timer_id = "2773416662589685571";

        Report_Query_Timer_Records_Mod qtrm = new Report_Query_Timer_Records_Mod(apikKey, timer_id);
        Report_Query_Timer_Records qtr = new Report_Query_Timer_Records(secretKey, qtrm);
        string result = qtr.PushMessage();
        Response.Write(result);
    }
}