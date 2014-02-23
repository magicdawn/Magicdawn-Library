using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    public static class UnicodeHelper
    {
        /// <summary>
        /// 将字符串转为Unicode字符
        /// </summary>
        /// <param name="src">原字符串</param>
        /// <param name="keepEnChar">是否保留英文字符,默认保留</param>
        /// <returns>转成功之后的字符</returns>
        public static string Encode(string src, bool keepEnChar = true)
        {
            var sb = new StringBuilder();
            foreach (char c in src)
            {
                //&&优先级高于||
                if (keepEnChar && (
                        c.Between('a', 'z') || c.Between('A', 'Z')
                    ))
                {
                    sb.Append(c);
                }
                else
                {
                    sb.Append("\\u" + ((int)c).ToString("x4"));//转成ASCII,然后转成4位16进制
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 解码Unicode
        /// </summary>
        /// <param name="encodedString">被Encode过的字符串</param>
        /// <returns>解码完成结果</returns>
        public static string Decode(string encodedString)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                encodedString,//input
                @"\\u([0-9a-fA-F]{4})",//regex pattern
                m => ((char)int.Parse(m.Groups[1].Value,
                    System.Globalization.NumberStyles.HexNumber)).ToString()
            );
        }
    }
}
