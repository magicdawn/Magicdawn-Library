using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Magicdawn
{
    /// <summary>
    /// 颜色Color相关
    /// </summary>
    public static class ColorHelper
    {
        /// <summary>
        /// 根据字符串来转换成Color实例
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        public static Color CreateFromString(string colorString)
        {
            var converter = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Color));
            return (Color)converter.ConvertFromString(colorString);
        }
    }
}
