using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_2_推送光比消息_消息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apiKey = "";
        string secretKey = "";

        Push_All_Mod psdm = new Push_All_Mod(apiKey, "{\"title\":\"胶圈技术部通知：\",\"description\":\"今天开源中国邀请大家去研讨会！\"}");
        Push_All pa = new Push_All(secretKey, psdm);
        string result = pa.PushMessage();
        Response.Write(result);
    }
}