using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

/*
 * 2014-2-18 17:03:38
 * 
 * BY Magicdawn
 */

namespace Magicdawn
{
    public static class StringHelper
    {
        #region ExtensionMethod
        //StartWith 从序列中选择,默认区分大小写
        /// <summary>
        /// StartWith 从序列中选择
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ignoreCase">默认区分大小写</param>
        /// <param name="starts"></param>
        /// <returns></returns>
        public static bool StartWithOneOf(this string @this, bool ignoreCase = false,
            params string[] starts)
        {
            foreach (var start in starts)
            {
                if (@this.StartsWith(start, ignoreCase, CultureInfo.CurrentCulture))
                {
                    return true;
                }
            }
            return false;
        }

        //EndWithOneOf 序列,默认区分大小写
        /// <summary>
        /// EndWithOneOf 序列,默认区分大小写
        /// </summary>
        /// <param name="this"></param>
        /// <param name="ignoreCase">默认区分大小写</param>
        /// <param name="ends"></param>
        /// <returns></returns>
        public static bool EndWithOneOf(this string @this, bool ignoreCase = false,
            params string[] ends)
        {
            foreach (var end in ends)
            {
                if (@this.EndsWith(end, ignoreCase, CultureInfo.CurrentCulture))
                {
                    return true;
                }
            }
            return false;
        }

        //将string变为Pascal方式
        public static string ToPascal(this string @this)
        {
            var words = @this.Split(' ');
            if (words.Length == 1)
            {
                //单词
                return WordToPascal(@this);
            }
            else
            {
                //句子
                var sb = new StringBuilder(@this.Length);
                foreach (var word in words)
                {
                    sb.Append(WordToPascal(word));
                    sb.Append(' ');
                }
                return sb.ToString().TrimEnd(' ');
            }


        }
        //将单词变为Pascal方式
        static string WordToPascal(string word)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                if (word.Length == 1)//一个字母
                {
                    return word.ToUpper();
                }
                else
                {
                    return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                }
            }
            else
            {
                return word;
            }
        }
        #endregion
    }
}
