using CommLib.BdPush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Simple_百度推送3_18_当前应用的设备统计信息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string apikKey = "";
        string secretKey = "";

        Report_Statistic_Device_Mod rsdm = new Report_Statistic_Device_Mod(apikKey);
        Report_Statistic_Device rsd = new Report_Statistic_Device(secretKey, rsdm);
        string result = rsd.PushMessage();
        Response.Write(result);
    }
}