using CommLib.BdPush;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_4_推送消息至指定一组设备_消息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //只有传透消息
        string apikKey = "";
        string secretKey = "";
        string ids = "{\"channel_id\":3768035906403034373}";

        Push_Batch_Device_Mod pbdm = new Push_Batch_Device_Mod(apikKey,ids, "{\"title\":\"公司通知：\",\"description\":\"五一劳动节放假安排！\"}", "hello");
        Push_Batch_Device pbd = new Push_Batch_Device(secretKey, pbdm);
        string result = pbd.PushMessage();
        Response.Write(result);

    }
}