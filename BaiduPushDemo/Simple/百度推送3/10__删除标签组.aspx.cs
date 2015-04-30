using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_10__删除标签组 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";
        string tag = "ball";

        App_Del_Tag_Mod dtm = new App_Del_Tag_Mod(apikKey, tag);
        App_Del_Tag dt = new App_Del_Tag(secretKey, dtm);
        string result = dt.PushMessage();
        Response.Write(result);
    }
}