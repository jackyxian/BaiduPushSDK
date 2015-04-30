using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_11_添加设备到标签组 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string tag = "basketball";
        string channel_ids = "{\"channel_id\":3768035906403034373}";

        Tag_Add_Devices_Mod qtm = new Tag_Add_Devices_Mod(apikKey, tag, channel_ids);
        Tag_Add_Devices qt = new Tag_Add_Devices(secretKey, qtm);
        string result = qt.PushMessage();
        Response.Write(result);
    }
}