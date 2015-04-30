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
    /// 功能：根据msg_id获取消息推送报告
    /// </summary>
    public class Report_Query_Msg_Status_Mod : Baidu_Mod
    {
        #region 属性
        public string msg_id {get;set;}	            //string 	是 	推送接口返回的msg_id，支持一个由msg_id组成的json数组 	消息ID
        #endregion

        #region 构造函数
        public Report_Query_Msg_Status_Mod(string apikey, string msg_id)
        {
            this.apikey = apikey;
            this.msg_id = msg_id;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
