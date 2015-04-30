using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_15_取消定时任务 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string timer_id = "277341666258968557";

        Timer_Cancel_Mod tcm = new Timer_Cancel_Mod(apikKey, timer_id);
        Timer_Cancel tc = new Timer_Cancel(secretKey, tcm);
        string result = tc.PushMessage();
        Response.Write(result);
    }
}