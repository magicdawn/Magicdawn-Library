using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Magicdawn
{
    public static class UrlHelper
    {
        public static string Encode(string url)
        {
            return HttpUtility.UrlEncode(url);
        }
        public static string Decode(string encodedUrl)
        {
            return HttpUtility.UrlDecode(encodedUrl);
        }
    }
}
