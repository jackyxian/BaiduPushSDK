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
    /// 功能：提交发送信息到百度接口的抽象接口
    /// </summary>
    public abstract class Baidu_Send
    {
        public Baidu_Mod mod { get; set; }
        public string url { get; set; }
        public string httpMehtod { get; set; }
        public string secret_key { get; set; }

        public abstract string PushMessage();
    }
}
