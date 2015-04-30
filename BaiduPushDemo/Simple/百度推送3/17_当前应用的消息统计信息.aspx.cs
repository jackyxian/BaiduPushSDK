using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_17_当前应用的消息统计信息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
   

        Report_Statistic_Msg_Mod rsmm = new Report_Statistic_Msg_Mod(apikKey);
        Report_Statistic_Msg rsm = new Report_Statistic_Msg(secretKey, rsmm);
        string result = rsm.PushMessage();
        Response.Write(result);
    }
}