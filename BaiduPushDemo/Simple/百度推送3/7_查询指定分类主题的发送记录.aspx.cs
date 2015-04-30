using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_7_查询指定分类主题的发送记录 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apiKey = "";
        string secretKey = "";
        string topic_id = "2773416662589685571";

        Report_Query_Topic_Records_Mod qtrm = new Report_Query_Topic_Records_Mod(apiKey, topic_id);
        Report_Query_Topic_Records qtr = new Report_Query_Topic_Records(secretKey, qtrm);
        string result = qtr.PushMessage();
        Response.Write(result);
    }
}