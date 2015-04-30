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
    /// 功能：推送消息或通知给指定的标签
    /// </summary>
    public class Push_Tags_Mod : Baidu_Mod
    {

        #region 属性
        public uint type {get;set;}             //number 	是 	目前固定值为 1 	推送的标签类型
        public string tag {get;set;}            //string 	是 	已创建的tag名称 	标签名
        public uint msg_type { get; set; }      //number 	否 	取值如下：0：消息；1：通知。默认为0 	消息类型
        public string msg { get; set; }         //string 	是 	详情见消息/通知数据格式 	消息内容，json格式
        public uint msg_expires { get; set; }   //number 	否 	0~604800(86400*7)，默认为5小时(18000秒) 	相对于当前时间的消息过期时间，单位为秒
        public uint deploy_status { get; set; } //number 	否 	取值为：1：开发状态；2：生产状态； 若不指定，则默认设置为生产状态。 	设置iOS应用的部署状态，仅iOS应用推送时使用
        public uint send_time { get; set; }     //number    否  指定的实际发送时间，必须在当前时间60s以外，1年以内 	定时推送，用于指定的实际发送时间
        #endregion

        #region 构造函数
        public Push_Tags_Mod(string apikey, string tag, string msg)
        {
            this.apikey = apikey;
            this.type = 1;                  //目前固定值为 1
            this.tag = tag;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = 0;              //消息
            this.msg_expires = 604800;      //7天过期
            this.device_type = 3;           //安卓
            this.deploy_status = 2;         //生产状态
        }

        public Push_Tags_Mod(string apikey, string tag, string msg, uint msg_type)
        {
            this.apikey = apikey;
            this.type = 1;                  //目前固定值为 1
            this.tag = tag;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = msg_type;       //消息类型
            this.msg_expires = 604800;      //7天过期
            this.device_type = 3;           //安卓
            this.deploy_status = 2;         //生产状态
        }
        #endregion

    }
}
