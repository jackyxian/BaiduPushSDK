using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_16_查询分类主题列表 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";

        Topic_Query_List_Mod tqlm = new Topic_Query_List_Mod(apikKey);
        Topic_Query_List tql = new Topic_Query_List(secretKey, tqlm);
        string result = tql.PushMessage();
        Response.Write(result);
    }
}