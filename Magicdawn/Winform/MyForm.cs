using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Magicdawn.Winform
{
    /// <summary>
    /// Form 我的偏好
    /// </summary>
    public class MyForm : Form
    {
        /// <summary>
        /// 我的Form
        /// </summary>
        public MyForm()
        {
            //允许拖动
            this.AllowDrop = true;
            //字体
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            //起始位置
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
