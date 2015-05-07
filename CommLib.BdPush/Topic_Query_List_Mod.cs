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
    /// 功能：查询推送过程中使用过的分类主题列表
    /// </summary>
    public class Topic_Query_List_Mod : Baidu_Mod
    {

        #region 属性
        public uint start {get;set;} 	                //number 	否 	整数，默认为0 	指定返回记录的起始索引位置
        public uint limit {get;set;}                    //number 	否 	整数：[1,10]，默认10 	返回的记录条数，官网文档的默认值最大为20，是错误的
        #endregion

        #region 构造函数
        public Topic_Query_List_Mod(string apikey)
        {
            this.apikey = apikey;               
            this.start = 0;
            this.limit = 10;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
