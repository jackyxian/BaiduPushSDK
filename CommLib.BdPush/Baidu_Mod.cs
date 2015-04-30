using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommLib.BdPush
{
    /// <summary>
    /// 作者：冼树华
    /// QQ：56472465
    /// 日期：20150-04-29
    /// 功能：请求参数的基类
    /// </summary>
    public class Baidu_Mod
    {
        #region 公有属性
        public string apikey { get; set; }	        //string 	是 	应用的api key,用于标识应用。
        public uint timestamp { get; set; }	        //uint 	    是 	用户发起请求时的unix时间戳。本次请求签名的有效时间为该时间戳向后10分钟。
        public string sign { get; set; } 	        //string 	是 	调用参数签名值，与apikey成对出现。用于防止请求内容被篡改, 生成方法请参考。
        public uint? expires { get; set; }          //uint 	    否 	用户指定本次请求签名的失效时间。格式为unix时间戳形式，用于防止 replay 型攻击。为保证防止 replay攻击算法的正确有效，请保证客户端系统时间正确。
        public uint? device_type { get; set; }	    //uint  	否 	当一个应用同时支持多个设备平台类型（比如：Android和iOS），请务必设置该参数。其余情况可不设置。具体请参见：device_type参数使用说明，android:3,ios:4
        #endregion
    }   
}
