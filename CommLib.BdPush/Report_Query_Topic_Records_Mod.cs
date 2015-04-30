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
    /// 功能：根据分类主题获取消息推送记录
    /// </summary>
    public class Report_Query_Topic_Records_Mod : Baidu_Mod
    {

        #region 属性
        public string topic_id {get;set;} 	            //string 	是 	字母、数字及下划线组成，长度限制为1~128 	分类主题名称
        public uint start {get;set;} 	                //number 	否 	整数，默认为0 	指定返回记录的起始索引位置
        public uint limit {get;set;}                    //number 	否 	整数：[1,100]，默认100 	返回的记录条数
        public uint range_start{get;set;} 	            //number 	否 	指定查询起始时间范围，以服务端实际推送时间为准；默认为七天前的0点时间 	unix时间戳
        public uint range_end{get;set;} 	            //number 	否 	指定查询截止时间范围，以服务端实际推送时间为准；默认时间为当前时间 	unix时间戳
        #endregion

        #region 构造函数
        public Report_Query_Topic_Records_Mod(string apikey, string topic_id)
        {
            this.apikey = apikey;
            this.topic_id = topic_id;                  
            this.start = 0;
            this.limit = 100;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
