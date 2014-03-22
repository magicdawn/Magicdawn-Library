using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

public static class StringExtension
{
    //有一个满足返回就true
    /// <summary>
    /// 有一个满足返回就true
    /// </summary>
    /// <param name="current"></param>
    /// <param name="validator"></param>
    /// <param name="list"></param>
    /// <returns></returns>
    public static bool OneOf(this string current,Predicate<string> validator,params string[] list)
    {
        foreach(string one in list)
        {
            if(validator(one))
            {
                return true;
            }
        }
        return false;
    }

    //StartWith 从序列中选择,默认区分大小写
    /// <summary>
    /// StartWith 从序列中选择
    /// </summary>
    /// <param name="this"></param>
    /// <param name="starts"></param>
    /// <returns></returns>
    public static bool StartWithOneOf(this string current,
        params string[] starts)
    {
        return current.OneOf(current.StartsWith,starts);
    }

    //EndWithOneOf 序列,默认区分大小写
    /// <summary>
    /// EndWithOneOf 序列,默认区分大小写
    /// </summary>
    /// <param name="this"></param>
    /// <param name="ends"></param>
    /// <returns></returns>
    public static bool EndWithOneOf(this string current,
        params string[] ends)
    {
        return current.OneOf(current.EndsWith,ends);
    }

    //有一个相等就返回true
    /// <summary>
    /// 有一个相等就返回true
    /// </summary>
    /// <param name="current"></param>
    /// <param name="equals"></param>
    /// <returns></returns>
    public static bool EqualOneOf(this string current,params string[] equals)
    {
        return current.OneOf(current.Equals,equals);
    }

    /// <summary>
    /// current包含list的任意一个,返回true
    /// </summary>
    /// <param name="current"></param>
    /// <param name="list"></param>
    /// <returns></returns>
    public static bool ContainOneOf(this string current,params string[] list)
    {
        return current.OneOf(current.Contains,list);
    }
}