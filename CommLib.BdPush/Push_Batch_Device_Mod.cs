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
    /// 功能：推送消息给批量设备（批量单播）
    /// </summary>
    public class Push_Batch_Device_Mod : Baidu_Mod
    {

        #region 属性
        public string channel_ids { get; set; } //string 	是 	一组channel_id（最多为一万个）组成的json数组字符串 	对应一批设备
        public uint msg_type { get; set; }      //number 	否 	取值如下：0：消息；1：通知。默认为0 	消息类型
        public string msg { get; set; }         //string 	是 	详情见消息/通知数据格式 	消息内容，json格式
        public uint msg_expires { get; set; }   //number 	否 	0~604800(86400*7)，默认为5小时(18000秒) 	相对于当前时间的消息过期时间，单位为秒
        public string topic_id { get; set; }    //string 	是 	字母、数字及下划线组成，长度限制为1~128 	分类主题名称
        #endregion

        #region 构造函数
        public Push_Batch_Device_Mod(string apikey, string channel_ids, string msg, string topic_id)
        {
            this.apikey = apikey;
            this.channel_ids = channel_ids;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = 0;              //消息
            this.msg_expires = 86400;       //1天过期（只能一天）
            this.device_type = 3;           //安卓
            this.topic_id = topic_id;       //主题
        }

        public Push_Batch_Device_Mod(string apikey, string channel_ids, string msg, uint msg_type, string topic_id)
        {
            this.apikey = apikey;
            this.channel_ids = channel_ids;
            this.msg = msg;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.msg_type = msg_type;       //消息类型
            this.msg_expires = 86400;       //1天过期（只能一天）
            this.device_type = 3;           //安卓
            this.topic_id = topic_id;       //主题
        }
        #endregion

    }
}
