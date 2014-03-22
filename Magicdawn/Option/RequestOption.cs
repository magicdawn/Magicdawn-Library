using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    public class RequestOption
    {
        //userAgent,编码
        public string UserAgent { get; set; }
        public Encoding ResponseEncoding { get; set; }

        public RequestOption()
        {
            UserAgent = Browser.Chrome;
            ResponseEncoding = Encoding.UTF8;
        }

    }
}
