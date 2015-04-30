using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommLib.BdPush
{
    public class Notice_Android_Mod
    {
        public string title { get; set; }           //选填；通知标题，可以为空；如果为空则设为appid对应的应用名; 
        public string description { get; set; }     //必填；同志文本内容，不能为空；
        public string notification_builder_id { get; set; }    //选填；android客户端自定义通知样式，如果没有设置默认为0;
        public string notification_basic_style { get; set; }   //选填；只有notification_builder_id为0时有效，可以设置通知的基本样式包括(响铃：0x04;振动：0x02;可清除：0x01;),这是一个flag整形，每一位代表一种样式;
        public string open_type { get; set; }                  //选填： 点击通知后的行为(1：打开Url; 2：自定义行为；3：默认打开应用;);
        public string url { get; set; }             //选填；需要打开的Url地址，open_type为1时才有效; 
        public string pkg_content { get; set; }     //选填；open_type为2时才有效，Android端SDK会把pkg_content字符串转换成Android Intent,通过该Intent打开对应app组件，所以pkg_content字符串格式必须遵循Intent uri格式，最简单的方法可以通过Intent方法toURI()获取
        public string custom_content { get; set; }  //选填：自定义内容，键值对，Json对象形式(可选)；在android客户端，这些键值对将以Intent中的extra进行传递。


        public Notice_Android_Mod(string description)
        {
            this.description = description;
        }

        public Notice_Android_Mod(string title, string description)
        {
            this.description = description;
            this.title = title;
        }


    }
}
