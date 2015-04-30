using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_3_根据标签推送_消息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string timer_id = "277341666258968557";

        Push_Tags_Mod ptm = new Push_Tags_Mod(apikKey, timer_id,"{\"title\":\"胶圈产品部通知：\",\"description\":\"今天下午3点开会商讨销售方案！\"}");
        Push_Tags pt = new Push_Tags(secretKey, ptm);
        string result = pt.PushMessage();
        Response.Write(result);
    }
}