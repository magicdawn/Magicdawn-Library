using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn.Util
{
    /// <summary>
    /// 自定义 格式化器(CustomFormatter)基类
    /// </summary>
    /// <typeparam name="T">要处理的类型</typeparam>
    public abstract class CustomFormatter<T> : ICustomFormatter,IFormatProvider
    {
        //IFormatProvider.GetFormat
        public object GetFormat(Type formatType)
        {
            if(formatType == typeof(ICustomFormatter))
            {
                //要的就是CustomFormatter
                return this;
            }
            else
            {
                return System.Globalization.CultureInfo.CurrentCulture.GetFormat(formatType);
            }
        }

        //ICustomFormatter.Format
        public string Format(string format,object arg,IFormatProvider formatProvider)
        {
            if(arg.GetType() == typeof(T) &&
                format != null
              )//是char
            {
                return FormatCustom(format,(T)arg);
            }
            return FormatRegular(format,arg);
        }

        //处理常规字符
        public string FormatRegular(string format,object arg)
        {
            if(arg == null)
            {
                return string.Empty;
            }
            else
            {
                if(arg is IFormattable)//arg 实现了IFormattable接口
                {
                    //formatprovider
                    return (arg as IFormattable).ToString(format,null);
                }
                else
                {
                    return arg.ToString();
                }
            }
        }

        //处理 自定义格式 类型,如果不重写,也返回FormatRegular
        /// <summary>
        /// 用于 处理自定义 格式的详细方法,处理 自定义格式 类型,如果不重写,也返回FormatRegular
        /// </summary>
        /// <param name="format">格式</param>
        /// <param name="arg">数据</param>
        /// <returns>处理结果</returns>
        public virtual string FormatCustom(string format,T arg)
        {
            return FormatRegular(format,arg);
        }
    }
}
