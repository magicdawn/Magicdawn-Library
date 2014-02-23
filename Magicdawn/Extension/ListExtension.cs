using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    /// <summary>
    /// 对List<T>的扩展,可批量添加,删除
    /// </summary>
    public static class ListExtension
    {
        //批量删除
        /// <summary>
        /// 批量删除,对List<T>的扩展
        /// </summary>
        /// <param name="list">当前List<T></param>
        /// <param name="ctls">要删除的项</param>
        public static void Remove<T>(this List<T> list, params T[] items2Removed)
        {
            if (list.Count() <= 0)
            {
                return;
            }
            foreach (var item in items2Removed)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                }
            }
        }

        //批量添加
        /// <summary>
        /// 批量添加,对List<T>的扩展
        /// </summary>
        /// <param name="list">当前List<T></param>
        /// <param name="ctls">要添加的项</param>
        public static void Add<T>(this List<T> list, params T[] items2Add)
        {
            foreach (var item in items2Add)
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                }
            }
        }
    }
}
