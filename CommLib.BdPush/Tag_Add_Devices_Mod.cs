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
    /// 功能：向tag中批量添加设备
    /// </summary>
    public class Tag_Add_Devices_Mod : Baidu_Mod
    {
        #region 属性
        public string tag {get;set;} 	        //string 	是 	1~128字节，但不能为‘default’ 	标签名称
        public string channel_ids {get;set;} 	//string 	是 	一组channel_id（最少1个，最多为10个）组成的json数组字符串 	对应一批设备
        #endregion

        #region 构造函数
        public Tag_Add_Devices_Mod(string apikey, string tag, string channel_ids)
        {
            this.apikey = apikey;
            this.tag = tag;
            this.channel_ids = channel_ids;
            this.timestamp = Tool.getDefauleTimestamp();   //默认使用当前时间戳
            this.device_type = 3;           //安卓
        }
        #endregion

    }
}
