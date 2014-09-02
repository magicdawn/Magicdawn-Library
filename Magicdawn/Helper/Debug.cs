using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Magicdawn
{
    /// <summary>
    /// debug工具类
    /// </summary>
    public class DebugHelper //与System.Diagnostics.Debug同名错误
    {
        #region 执行时间
        static Stopwatch watch = Util.Singleton<Stopwatch>.Instance;
        public static TimeSpan GetExecuteTime(Action act,bool log = true,string desc = null)
        {
            watch.Reset();
            if(log)
            {
                ConsoleX.Log(">>>>>正在执行 " + desc ?? "");
            }
            watch.Start();
            act();
            watch.Stop();
            if(log)
            {
                ConsoleX.Success("耗时 : {0}",watch.Elapsed);
                ConsoleX.Log("<<<<<完成计时");
            }
            return watch.Elapsed;
        }
        #endregion
    }
}
