using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace Magicdawn
{
    /// <summary>
    /// 对Json.NET的简单功能封装
    /// </summary>
    public class JsonHelper
    {
        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
