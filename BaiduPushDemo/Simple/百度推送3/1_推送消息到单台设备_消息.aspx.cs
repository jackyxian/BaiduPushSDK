using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_1_推送消息到单台设备_消息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string channel_id = "3768035906403034373";

        Push_Single_Device_Mod psdm = new Push_Single_Device_Mod(apikKey, channel_id, "{\"title\":\"胶圈体育总局通知：\",\"description\":\"老荣膝盖酸痛退役！\"}");
        Push_Single_Device psd = new Push_Single_Device(secretKey, psdm);
        string result = psd.PushMessage();
        Response.Write(result);
    }
}