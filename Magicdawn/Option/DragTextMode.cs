using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Magicdawn
{
    /// <summary>
    /// DragHelper.EnableDragText时用到的Mode
    /// <para>表示是Append到Control</para>
    /// <para>还是清空原文本,Replace之</para>
    /// </summary>
    public enum EDragTextMode
    {
        /// <summary>
        /// 追加
        /// </summary>
        Append,

        /// <summary>
        /// 追加内容,并换行
        /// </summary>
        AppendLine,

        /// <summary>
        /// 在最开始追加
        /// </summary>
        Prepend,

        /// <summary>
        /// 在最开始追加,并换行
        /// </summary>
        PrependLine,

        /// <summary>
        /// 替换
        /// </summary>
        Replace,
    }
}
