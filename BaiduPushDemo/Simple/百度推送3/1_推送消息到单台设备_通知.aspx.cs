using CommLib.BdPush;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_1_推送消息到单台设备_通知 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";

        Notice_Android_Mod dam = new Notice_Android_Mod("今天天气", "下午北京可能有沙尘暴，大家小心");
        string json = JsonConvert.SerializeObject(dam);
        Push_Single_Device_Mod psdm = new Push_Single_Device_Mod(apikKey, "3768035906403034373", json, (int)Baidu_Helper.Message_Type.Notice);
        Push_Single_Device psd = new Push_Single_Device(secretKey, psdm);
        string result = psd.PushMessage();
        Response.Write(result);
    }
}