using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;


namespace Magicdawn
{
    public class HttpHelper
    {
        #region 属性
        public string UserAgent { get; set; }//浏览器类型
        public Encoding ResponseEncoding { get; set; }//响应编码
        #endregion

        //构造函数
        public HttpHelper()
        {
            this.UserAgent = Browser.Chrome;//默认为Chrome
            this.ResponseEncoding = Encoding.UTF8;//默认UTF8编码
        }

        //实际访问
        public string Request(string url)
        {
            string html;
            try
            {
                var req = WebRequest.Create(url) as HttpWebRequest;
                req.UserAgent = this.UserAgent;

                var res = req.GetResponse() as HttpWebResponse;
                var resStream = res.GetResponseStream();

                using (var sr = new StreamReader(resStream, this.ResponseEncoding))
                {
                    html = sr.ReadToEnd();
                }
            }
            catch (WebException)
            {
                html = string.Empty;
            }
            return html;
        }

        public MatchCollection Request(string url, string regexPattern)
        {
            return Regex.Matches(this.Request(url), regexPattern);
        }
    }
}
