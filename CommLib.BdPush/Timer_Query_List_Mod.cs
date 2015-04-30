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
    /// 功能：查看还未执行的定时任务，每个应用可设置的有效的定时任务有限制(目前为10个)。
    /// </summary>
    public class Timer_Query_List_Mod : Baidu_Mod
    {
        
        #region 属性
        public string timer_id{get;set;} 	            //string 	否 	推送接口返回的timer_id唯一标识一个定时推送任务 	如果指定该参数，将仅返回该timer_id对应定时任务的相关信息
        public uint start {get;set;} 	                //number 	否 	整数，默认为0 	指定返回记录的起始索引位置
        public uint limit {get;set;}                    //number 	否 	整数：[1,100]，默认100 	返回的记录条数
        #endregion

        #region 构造函数
        public Timer_Query_List_Mod(string apikey)
        {
            this.apikey = apikey;               
            this.start = 0;
            this.limit = 10;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }

        public Timer_Query_List_Mod(string apikey, string timer_id)
        {
            this.apikey = apikey;
            this.timer_id = timer_id;                  
            this.start = 0;
            this.limit = 10;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
