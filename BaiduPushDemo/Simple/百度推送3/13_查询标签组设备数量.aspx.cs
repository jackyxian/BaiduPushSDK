using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_13_查询标签组设备数量 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string tag = "basketball";

        Tag_Device_Num_Mod tdnm = new Tag_Device_Num_Mod(apikKey, tag);
        Tag_Device_Num tdn = new Tag_Device_Num(secretKey, tdnm);
        string result = tdn.PushMessage();
        Response.Write(result);

    }
}