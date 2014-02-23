using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    /// <summary>
    /// 对基本数据类型的扩充,int float等都实现了IComparable接口
    /// </summary>
    public static class BasicTypeExtension
    {
        /// <summary>
        /// 当前值,介于两参数之间
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="current">当前值</param>
        /// <param name="low">低档值</param>
        /// <param name="high">高档值</param>
        /// <returns>介于两者之间</returns>
        public static bool Between<T>(this T current, T low, T high)
            where T : IComparable<T>
        {
            //compare方法,
            //小于 <0
            //等于 =0
            //大于 >0
            return current.CompareTo(low) * current.CompareTo(high) <= 0;
        }
    }
}
