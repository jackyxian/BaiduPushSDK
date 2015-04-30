using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CommLib.BdPush
{
    /// <summary>
    /// 作者：冼树华
    /// QQ：56472465
    /// 日期：20150-04-29
    /// 功能：百度推送帮助类
    /// </summary>
    public class Baidu_Helper
    {
        #region 枚举参数
        /// <summary>
        /// 设备类型
        /// </summary>
        public enum Device_Type : uint { Android = 3, IOS = 4 };

        /// <summary>
        /// 推送类型
        /// </summary>
        public enum Push_Type : uint { Signle = 1, Multiple = 2, All = 3 };

        /// <summary>
        /// 消息类型
        /// </summary>
        public enum Message_Type : uint { Message = 0, Notice = 1 }

        /// <summary>
        /// 部署状态
        /// </summary>
        public enum Deploy_Status : uint { Develope = 1, Product = 2 }

        //0：tag组播； 1：广播； 2：批量单播； 3：标签组合； 4：精准推送； 5：LBS推送； 6：系统保留； 7：单播；
        public enum Query_Type : uint
        {
            TagPush = 0, Push = 1, BatchPush = 2, TagsPush = 3,  
            PrecisionPush = 4, LBSPush = 5, SysKeep = 6, SignalPush = 7
        }
        #endregion

        #region http传输方式
        public static readonly string HTTP_POST = "post";   //post传输
        public static readonly string HTTP_GET = "get";     //get传输
        #endregion

        #region 相关URL的方法参数
        public static readonly string PUSH_SIGNLE_DEVICE = "push/single_device";                    //推送消息到单台设备
        public static readonly string PUSH_ALL = "push/all";                                        //推送广播消息
        public static readonly string PUSH_TAGS = "push/tags";                                      //推送组播消息
        public static readonly string PUSH_BATCH_DEVICE = "push/batch_device";                      //推送消息到给定的一组设备(批量单播)
        public static readonly string REPORT_QUERY_MSG_STATUS = "report/query_msg_status";          //查询消息的发送状态
        public static readonly string REPORT_QUERY_TIMER_RECORDS = "report/query_timer_records";    //查询定时消息的发送记录
        public static readonly string REPORT_QUERY_TOPIC_RECORDS = "report/query_topic_records";    //查询指定分类主题的发送记录
        public static readonly string APP_QUERY_TAGS = "app/query_tags";                            //查询标签组列表
        public static readonly string APP_CREATE_TAG = "app/create_tag";                            //创建标签组
        public static readonly string APP_DEL_TAG = "app/del_tag";                                  //删除标签组
        public static readonly string TAG_ADD_DEVICES = "tag/add_devices";                          //添加设备到标签组
        public static readonly string TAG_DEL_DEVICES = "tag/del_devices";                          //将设备从标签组中移除
        public static readonly string TAG_DEVICE_NUM = "tag/device_num";                            //查询标签组设备数量
        public static readonly string TIMER_QUERY_LIST = "timer/query_list";                        //查询定时任务列表
        public static readonly string TIMER_CANCEL = "timer/cancel";                                //取消定时任务
        public static readonly string TOPIC_QUERY_LIST = "topic/query_list";                        //查询分类主题列表
        public static readonly string REPORT_STATISTIC_MSG = "report/statistic_msg";                //当前应用的消息统计信息
        public static readonly string REPORT_STATISTIC_DEVICE = "report/statistic_device";          //当前应用的设备统计信息
        public static readonly string REPORT_STATISTIC_TOPIC = "report/statistic_topic";            //查询分类主题统计信息
        #endregion


        #region 获取签名
        private static string CreateSign(string httpMethod, string url, string secretKey, Baidu_Mod mod)
        {
            string sign = "";
            if (mod != null)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();

                //将键值对按照key的升级排列
                var props = mod.GetType().GetProperties().OrderBy(p => p.Name);
                string pValue = "";
                foreach (var p in props)
                {
                    if (p.GetValue(mod, null) != null)
                    {
                        pValue = p.GetValue(mod, null).ToString(); 
                        if (pValue != "0")//unint为0是不添加，如广播消息的预定发送时间
                            dic.Add(p.Name, p.GetValue(mod, null).ToString());
                    }
                }
                //生成sign时，不能包含sign标签，所有移除
                dic.Remove("sign");

                var preData = new StringBuilder();
                foreach (var l in dic)
                {
                    preData.Append(l.Key);
                    preData.Append("=");
                    preData.Append(l.Value);

                }

                //按要求拼接字符串，并urlencode编码
                var str = HttpUtility.UrlEncode(httpMethod.ToUpper() + url + preData.ToString() + secretKey);

                var strSignUpper = new StringBuilder();
                int perIndex = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    var c = str[i].ToString();
                    if (str[i] == '%')
                    {
                        perIndex = i;
                    }
                    if (i - perIndex == 1 || i - perIndex == 2)
                    {
                        c = c.ToUpper();
                    }
                    strSignUpper.Append(c);
                }

                // 获取sign的值
                sign =  Tool.Md5Hash(strSignUpper.ToString()).ToLower();
      
            }
            return sign;
        }
        #endregion

        #region 创建参数集合
        private static   Dictionary<string, string> GetParamerCollection(Baidu_Mod mod, string sign)
        {
            Dictionary<string, string> paramerCollection = new Dictionary<string, string>();

            var props = mod.GetType().GetProperties();
            string pValue = "";
            foreach (var p in props)
            {
                if (p.GetValue(mod, null) != null)
                {
                    pValue = p.GetValue(mod, null).ToString();
                    if (pValue != "0")//unint为0是不添加，如广播消息的预定发送时间
                        paramerCollection.Add(p.Name, p.GetValue(mod, null).ToString());
                }
            }
       

            paramerCollection.Add("sign", sign);

            return paramerCollection;
 
        }
        #endregion

        #region 发送消息到百度
        public static async Task<string>  SendBaidu(string httpMethod, string url, string secretKey, Baidu_Mod mod)
        {
            //获取签名
            string strSign = CreateSign(httpMethod, url, secretKey, mod);    
            
            string responseContent = "";                //返回字符串

            //使用本机代理fiddler进行测试
            //var handler = new HttpClientHandler()
            //{
            //    Proxy = new WebProxy("http://127.0.0.1:8888", false, new string[] { }),
            //    UseProxy = true
            //};

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);                                                                                  //设置WebAPI的地址+类+方法
                client.DefaultRequestHeaders.Accept.Clear();                                                                        //清空缓存  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"){CharSet="utf-8"});  //返回值为json和utf-8编码

                //响应消息
                HttpResponseMessage response = null;                                                                
                
                //判断使用不同的HttpMethod，生成不同的参数，获取相关返回数据
                if (HttpMethod.Get.Method.ToLower().Equals(httpMethod.ToLower()))                                   //get方法（暂不提供）
                {

                }
                else if (HttpMethod.Post.Method.ToLower().Equals(httpMethod.ToLower()))                             //post方法
                {
                    //生成post的参数，并且设置charset为utf-8
                    Dictionary<string, string> requestDictionary = GetParamerCollection(mod, strSign);
                    var contents = new FormUrlEncodedContent(requestDictionary);                                    
                    contents.Headers.ContentType.CharSet = "utf-8";
                    await contents.LoadIntoBufferAsync();    
                                                       
                    response = await client.PostAsync(url, contents);                                                       
                }

                //返回值
                responseContent = await response.Content.ReadAsStringAsync();                                   


            }// http完结

            return responseContent;
         
        }
        #endregion


        #region https证书验证
        // 
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }
        #endregion


    }
}
