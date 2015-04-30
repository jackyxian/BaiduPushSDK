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
    /// 功能：统计当前应用下一个分类主题的消息数量
    /// 注：支持单播、批量单播。
    /// </summary>
    public class Report_Statistic_Topic_Mod : Baidu_Mod
    {
        #region 属性
        public string topic_id {get;set;} 	            //string 	是 	字母、数字及下划线组成，长度限制为1~128 	一个已使用过的分类主题
        #endregion

        #region 构造函数
        public Report_Statistic_Topic_Mod(string apikey, string topic_id)
        {
            this.apikey = apikey;
            this.topic_id = topic_id;                  
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion
    }
}
