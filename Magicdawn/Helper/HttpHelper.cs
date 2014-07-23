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
        public static string Request(string url,Encoding encoding = null)
        {
            if(encoding == null) encoding = Encoding.UTF8;
            try
            {
                var req = WebRequest.Create(url) as HttpWebRequest;
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
            var client = Magicdawn.Util.Singleton<WebClient>.GetInstance();
            return client.DownloadString(url);
        }
    }
}
