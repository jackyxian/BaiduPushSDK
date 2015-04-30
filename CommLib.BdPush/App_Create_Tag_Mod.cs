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
    /// 功能：创建一个空的标签组
    /// </summary>
    public class App_Create_Tag_Mod : Baidu_Mod
    {

        #region 属性
        public string tag {get;set;} 	//string 	是 	1~128字节，但不能为‘default’ 	标签名称
        #endregion

        #region 构造函数
        public App_Create_Tag_Mod(string apikey, string tag)
        {
            this.apikey = apikey;
            this.tag = tag;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
