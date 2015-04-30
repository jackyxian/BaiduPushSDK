using CommLib.BdPush;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_3_根据标签推送_通知 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string tag = "ball";
        
        Notice_Android_Mod dam = new Notice_Android_Mod("今天股市", "熊市，熊出没人注意！");
        string json = JsonConvert.SerializeObject(dam);
        Push_Tags_Mod ptd = new Push_Tags_Mod(apikKey, tag, json, (int)Baidu_Helper.Message_Type.Notice);
        Push_Tags pa = new Push_Tags(secretKey, ptd);
        string result = pa.PushMessage();
        Response.Write(result);
    }
}