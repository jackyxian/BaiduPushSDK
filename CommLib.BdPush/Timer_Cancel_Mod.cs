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
    /// 功能：取消尚未执行的定时推送任务
    /// </summary>
    public class Timer_Cancel_Mod : Baidu_Mod
    {

        #region 属性
        public string timer_id {get;set;} 	//string 	是 	只有未被执行并且距离实际执行时间一分钟以上的定时任务才能被取消 	定时任务ID
        #endregion

        #region 构造函数
        public Timer_Cancel_Mod(string apikey, string timer_id)
        {
            this.apikey = apikey;
            this.timer_id = timer_id;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
