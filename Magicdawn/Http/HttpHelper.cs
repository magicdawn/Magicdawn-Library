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
        //不设置UserAgent,不设置Encoding
        public static string Request(string url,RequestOption option = null)
        {
            option = option ?? new RequestOption();
            try
            {
                var req = WebRequest.Create(url) as HttpWebRequest;

                var res = req.GetResponse() as HttpWebResponse;
                var resStream = res.GetResponseStream();

                using(var sr = new StreamReader(resStream))
                {
                    return sr.ReadToEnd();
                }
            }
            catch(WebException)
            {
                return string.Empty;
            }
        }
    }
}
