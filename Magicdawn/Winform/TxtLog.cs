using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace Magicdawn.Winform
{
    /// <summary>
    /// 用于日志记录的文本框
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]//工具箱上使用TextBox的图标
    public class TxtLog : TextBox
    {
        public TxtLog()
        {
            this.ScrollBars = ScrollBars.Vertical;//竖直滚动条
            this.Multiline = true;//多行
        }

        #region Log方法
        /// <summary>
        /// Log不换行
        /// </summary>
        /// <param name="txt"></param>
        public void Log(string txt)
        {
            this.AppendText(txt);//AppendText 会
            this.ScrollToCaret(); 
        }
        /// <summary>
        /// 换行
        /// </summary>
        /// <param name="txt"></param>
        public void LogLine(string txt)
        {
            this.Log(txt + "\r\n");
        }
        /// <summary>
        /// 不换行Object重载
        /// </summary>
        /// <param name="o"></param>
        public void Log(object o)
        {
            this.Log(o.ToString());
        }
        /// <summary>
        /// 换行Object重载
        /// </summary>
        /// <param name="o"></param>
        public void LogLine(object o)
        {
            this.LogLine(o.ToString());
        }
        #endregion
    }
}
