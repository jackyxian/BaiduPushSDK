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
    /// 功能：查询某个tag关联的设备数量
    /// </summary>
    public class Tag_Device_Num : Baidu_Send
    {
        
        #region 构造函数
        public Tag_Device_Num(string secret_key, Baidu_Mod mod)
        {
            this.httpMehtod = Baidu_Helper.HTTP_POST;
            this.url = "http://api.tuisong.baidu.com/rest/3.0/" + Baidu_Helper.TAG_DEVICE_NUM;
            this.secret_key = secret_key;
            this.mod = mod;
        }
        public Tag_Device_Num(string httpMehtod, string secret_key, Baidu_Mod mod)
        {
            this.httpMehtod = httpMehtod;
            this.url = "http://api.tuisong.baidu.com/rest/3.0/" + Baidu_Helper.TAG_DEVICE_NUM;
            this.secret_key = secret_key;
            this.mod = mod;
        }
        #endregion

        #region 重写PushMessage方法
        public override string PushMessage()
        {
            string strResult = "";

            //1.创建异步任务
            Task<string> task = Baidu_Helper.SendBaidu(this.httpMehtod, this.url, this.secret_key, this.mod);

            //2.等待任务完成
            task.Wait();

            //3.异步任务完成
            if (task.IsCompleted)
            {
                strResult = task.Result.ToString();
            }

            return strResult;
        }
        #endregion

    }
}
