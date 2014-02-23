﻿using System;
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
    public class DawnForm : Form
    {
        public DawnForm()
        {
            //允许拖动
            this.AllowDrop = true;
            //字体
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            //起始位置
            this.StartPosition = FormStartPosition.CenterScreen;
            //无最大化
            this.MaximizeBox = false;
            //border style
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
