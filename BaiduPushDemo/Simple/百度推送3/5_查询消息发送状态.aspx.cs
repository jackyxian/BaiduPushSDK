using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_5_查询消息发送状态 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string msg_ids = "5829936335720352035";

        Report_Query_Msg_Status_Mod qmsm = new Report_Query_Msg_Status_Mod(apikKey,msg_ids);
        Report_Query_Msg_Status qms = new Report_Query_Msg_Status(secretKey, qmsm);
        string result = qms.PushMessage();
        Response.Write(result);
    }
}