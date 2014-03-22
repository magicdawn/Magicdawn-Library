using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class CharExtension
{
    /// <summary>
    /// 是否是中文字符
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    public static bool IsChineseCharacter(this char @this)
    {
        var low = '\u4E00';
        var high = '\u9FA5';
        return @this.Between(low,high);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="charSeq"></param>
    /// <returns></returns>
    public static string GetString(this IEnumerable<char> charSeq)
    {
        //哈哈
        return new string(charSeq.ToArray());
    }
}