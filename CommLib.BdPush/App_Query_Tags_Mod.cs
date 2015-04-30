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
    /// 功能：查询应用的tag
    /// </summary>
    public class App_Query_Tags_Mod : Baidu_Mod
    {

        #region 属性
        public string tag {get;set;} 	//string 	否 	1-128字节，不传则获取应用下所有标签信息 	标签名称
        public uint start {get;set;} 	//number 	否 	整数，默认为0 	指定返回记录的起始索引位置
        public uint limit {get;set;} 	//number 	否 	整数：[1,100]，默认100 	返回的记录条数
        #endregion

        #region 构造函数
        public App_Query_Tags_Mod(string apikey)
        {
            this.apikey = apikey;                 
            this.start = 0;
            this.limit = 100;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }

        public App_Query_Tags_Mod(string apikey, string tag)
        {
            this.apikey = apikey;
            this.tag = tag;
            this.start = 0;
            this.limit = 100;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
