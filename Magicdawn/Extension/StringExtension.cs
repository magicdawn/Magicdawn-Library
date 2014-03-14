using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public static class StringExtension
{
    //StartWith 从序列中选择,默认区分大小写
    /// <summary>
    /// StartWith 从序列中选择
    /// </summary>
    /// <param name="this"></param>
    /// <param name="starts"></param>
    /// <returns></returns>
    public static bool StartWithOneOf(this string @this,
        params string[] starts)
    {
        foreach(var start in starts)
        {
            if(@this.StartsWith(start))
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
    /// <param name="ends"></param>
    /// <returns></returns>
    public static bool EndWithOneOf(this string @this,
        params string[] ends)
    {
        foreach(var end in ends)
        {
            if(@this.EndsWith(end))
            {
                return true;
            }
        }
        return false;
    }
}