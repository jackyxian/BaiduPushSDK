using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommLib.BdPush
{
    /// <summary>
    /// 作者：冼树华
    /// QQ：56472465
    /// 日期：20150-04-29
    /// 功能：静态工具类
    /// </summary>
    public static class Tool
    {

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">字符串</param>
        /// <returns>string</returns>
        public static string Md5Hash(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }


        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns>uint</returns>
        public static uint getDefauleTimestamp()
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime nowTime = DateTime.Parse(DateTime.Now.ToString());
            TimeSpan toNow = nowTime.Subtract(startTime);
            string timeStamp = "";
            timeStamp = toNow.Ticks.ToString();
            timeStamp = timeStamp.Substring(0, timeStamp.Length - 7);
            return uint.Parse(timeStamp);
        }
    }
}
