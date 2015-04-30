using CommLib.BdPush;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_2_推送广播消息_通知 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";

        Notice_Android_Mod dam = new Notice_Android_Mod("交通事故", "王府井大街出现塞车，大家请绕路回家");
        string json = JsonConvert.SerializeObject(dam);
        Push_All_Mod pam = new Push_All_Mod(apikKey, json, (int)Baidu_Helper.Message_Type.Notice);
        Push_All pa = new Push_All(secretKey, pam);
        string result = pa.PushMessage();
        Response.Write(result);
    }
}