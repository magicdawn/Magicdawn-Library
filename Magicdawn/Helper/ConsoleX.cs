using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    public class ConsoleX //ConsoleHelper太长
    {
        static ConsoleColor old;
        public static void SaveColor()
        {
            old = Console.ForegroundColor;
        }
        public static ConsoleColor LoadColor()
        {
            Console.ForegroundColor = old;
            return old;
        }

        /// <summary>
        /// 在act里面不用担心影响后面的ForegroundColor/BackgroundColor
        /// </summary>
        /// <param name="act"></param>
        public static void Colorful(Action act)
        {
            ConsoleX.SaveColor();
            act();
            ConsoleX.LoadColor();
        }

        /// <summary>
        /// 输出彩色文字
        /// </summary>
        /// <param name="content"></param>
        /// <param name="color"></param>
        public static void Write(string content,ConsoleColor color)
        {
            SaveColor();
            Console.ForegroundColor = color;
            Console.Write(content);
            LoadColor();
        }
        public static void WriteLine(string content,ConsoleColor color)
        {
            SaveColor();
            Console.ForegroundColor = color;
            Console.WriteLine(content);
            LoadColor();
        }

        #region 基本Log warn error
        //success log   warn    error 
        //green   white yellow  red
        public static void Success(string content)
        {
            WriteLine(content,ConsoleColor.Green);
        }
        public static void Success(string format,params object[] args)
        {
            Success(format.format(args));
        }

        public static void Log(string content)
        {
            WriteLine(content,ConsoleColor.White);
        }
        public static void Log(string format,params object[] args)
        {
            Log(format.format(args));
        }

        public static void Warn(string content)
        {
            WriteLine(content,ConsoleColor.Yellow);
        }
        public static void Warn(string format,params object[] args)
        {
            Warn(format.format(args));
        }

        public static void Error(string content)
        {
            WriteLine(content,ConsoleColor.Red);
        }
        public static void Error(string format,params object[] args)
        {
            Error(format.format(args));
        }
        #endregion
    }
}
