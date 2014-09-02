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
        //encoding默认为UTF8
        public static string Request(string url,
            Encoding encoding = null,string[] headers = null,
            Action<HttpWebRequest> beforeRequest = null)
        {
            if(encoding == null) encoding = Encoding.UTF8;
            try
            {
                var req = WebRequest.Create(url) as HttpWebRequest;
                if(headers != null) //自定义header
                {
                    foreach(var header in headers)
                    {
                        req.Headers.Add(header);
                    }
                }
                if(beforeRequest != null)
                    beforeRequest(req); //request之前对req修改
                var res = req.GetResponse() as HttpWebResponse;
                var resStream = res.GetResponseStream();

                using(var sr = new StreamReader(resStream,encoding))
                {
                    return sr.ReadToEnd();
                }
            }
            catch(WebException ex)
            {
                return string.Empty;
            }
        }

        public static string DownloadString(string url)
        {
            var client = Magicdawn.Util.Singleton<WebClient>.Instance;
            return client.DownloadString(url);
        }
    }
}
