using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    /// <summary>
    /// 2014-2-5 15:21:10这种格式
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        /// 我常用的转成2014-1-20 15:01:44这种格式
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static string ToStringX(this DateTime datetime)
        {
            return datetime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}