using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_19_查询分类主题统计信息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string topic_id = "2773416662589685571";

        Report_Statistic_Topic_Mod rstm = new Report_Statistic_Topic_Mod(apikKey, topic_id);
        Report_Statistic_Topic rst = new Report_Statistic_Topic(secretKey, rstm);
        string result = rst.PushMessage();
        Response.Write(result);
    }
}