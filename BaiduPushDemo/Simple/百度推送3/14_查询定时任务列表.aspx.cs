using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_14_查询定时任务列表 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string topic_id = "2773416662589685571";

        Report_Query_Topic_Records_Mod rqtrm = new Report_Query_Topic_Records_Mod(apikKey, topic_id);
        Report_Query_Topic_Records rqtr = new Report_Query_Topic_Records(secretKey, rqtrm);
        string result = rqtr.PushMessage();
        Response.Write(result);
    }
}