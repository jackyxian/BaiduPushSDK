using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommLib.BdPush
{
    /// <summary>
    /// 作者：冼树华
    /// QQ：56472465
    /// 日期：20150-04-29
    /// 功能：统计APP 设备数
    /// </summary>
    public class Report_Statistic_Device_Mod : Baidu_Mod
    {

        #region 属性
        #endregion

        #region 构造函数
        public Report_Statistic_Device_Mod(string apikey)
        {
            this.apikey = apikey;               
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
