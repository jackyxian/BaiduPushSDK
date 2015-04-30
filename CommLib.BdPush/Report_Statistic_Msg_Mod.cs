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
    /// 功能：统计app消息信息
    /// 注：支持组播、广播、批量单播。由于数据库中最多记录三个月的统计结果，所以返回结果不分页，返回数据库中所有统计项。
    /// </summary>
    public class Report_Statistic_Msg_Mod : Baidu_Mod
    {

        #region 属性
        public uint query_type {get;set;} 	        //number 	否 	统计的消息类型状态，接收一个number或多个number组成的json数组 	0：tag组播； 1：广播； 2：批量单播； 3：标签组合； 4：精准推送； 5：LBS推送； 6：系统保留； 7：单播；
        #endregion

        #region 构造函数
        public Report_Statistic_Msg_Mod(string apikey)
        {
            this.apikey = apikey;               
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
