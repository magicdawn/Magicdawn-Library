using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Winform
{
    /// <summary>
    /// 只支持数字输入的TextBox
    /// </summary>
    [System.Drawing.ToolboxBitmap(typeof(TextBox))]
    public class NumberTextBox : TextBox
    {
        /// <summary>
        /// 重写OnKeyDown
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            var val = e.KeyValue;
            if ((val > '0' && val < '9') || //是数字
                (val == (int)Keys.Enter) ||//支持回车键
                (val == (int)Keys.Back)//支持删除
            )
            {
                base.OnKeyDown(e);
            }
            else
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
