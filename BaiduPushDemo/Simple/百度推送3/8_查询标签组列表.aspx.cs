using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_8_查询标签组列表 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";

        App_Query_Tags_Mod qtm = new App_Query_Tags_Mod(apikKey);            //全部    
        //Query_Tags_Mod qtm = new Query_Tags_Mod(apiKey,"ball");   //某个
        App_Query_Tags qt = new App_Query_Tags(secretKey, qtm);
        string result = qt.PushMessage();
        Response.Write(result);
    }
}