using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace Magicdawn
{
    //一些控件的扩展方法
    /// <summary>
    /// 一些控件的扩展方法
    /// </summary>
    public static class ControlExtension
    {
        #region 显示,隐藏
        /// <summary>
        /// 切换 显示,隐藏
        /// </summary>
        /// <param name="@this">要操作的控件</param>
        public static void Toggle(this Control @this)
        {
            @this.Visible = !@this.Visible;
        }
        #endregion

        #region 激活,失效
        /// <summary>
        /// 激活
        /// </summary>
        /// <param name="@this">要操作的控件</param>
        public static void Enable(this Control @this)
        {
            @this.Enabled = true;
        }

        /// <summary>
        /// 失效
        /// </summary>
        /// <param name="@this">要操作的控件</param>
        public static void Disable(this Control @this)
        {
            @this.Enabled = false;
        }

        /// <summary>
        /// 切换 激活,失效
        /// </summary>
        /// <param name="@this">要操作的控件</param>
        public static void ToggleEnable(this Control @this)
        {
            @this.Enabled = !@this.Enabled;
        }
        #endregion

        #region 事件处理

        #region click
        /// <summary>
        /// 绑定Click事件
        /// </summary>
        /// <param name="@this">要绑定Click事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void click(this Control @this, Action<Control, EventArgs> act)//两个参数
        {
            @this.Click += (sender, e) => {
                act(@this, e);
            };
        }

        /// <summary>
        /// 绑定Click事件
        /// </summary>
        /// <param name="@this">要绑定Click事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void click(this Control @this, Action<Control> act)//一个参数
        {
            @this.Click += (sender, e) => {
                act(@this);
            };
        }

        /// <summary>
        /// 绑定Click事件
        /// </summary>
        /// <param name="@this">要绑定Click事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void click(this Control @this, Action act)//没有参数
        {
            @this.Click += (sender, e) => {
                act();
            };
        }
        #endregion

        #region mouseEnter
        /// <summary>
        /// 绑定MouseEnter事件,两个参数
        /// </summary>
        /// <param name="@this">要绑定MouseEnter事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void mouseEnter(this Control @this, Action<Control, EventArgs> act)//正常两个参数
        {
            @this.MouseEnter += (sender, e) => {
                act(@this, e);
            };
        }

        /// <summary>
        /// 绑定MouseEnter事件,一个参数
        /// </summary>
        /// <param name="@this">要绑定MouseEnter事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void mouseEnter(this Control @this, Action<Control> act)
        {
            @this.Click += (sender, e) => {
                act(@this);
            };
        }

        /// <summary>
        /// 绑定MouseEnter事件,不用参数
        /// </summary>
        /// <param name="@this">要绑定MouseEnter事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void mouseEnter(this Control @this, Action act)
        {
            @this.Click += (sender, e) => {
                act();
            };
        }
        #endregion

        #region mouseLeave
        /// <summary>
        /// 绑定MouseLeave事件,两个参数
        /// </summary>
        /// <param name="@this">要绑定MouseLeave事件的控件</param>
        /// <param name="act">两个参数的Action</param>
        public static void mouseLeave(this Control @this, Action<Control, EventArgs> act)
        {
            @this.MouseLeave += (sender, e) => {
                act(@this, e);
            };
        }
        /// <summary>
        /// 绑定MouseLeave事件,一个参数
        /// </summary>
        /// <param name="@this">要绑定MouseLeave事件的控件</param>
        /// <param name="act">一个参数的Action</param>
        public static void mouseLeave(this Control @this, Action<Control> act)
        {
            @this.MouseLeave += (sender, e) => {
                act(@this);
            };
        }
        /// <summary>
        /// 绑定MouseLeave事件
        /// </summary>
        /// <param name="@this">要绑定MouseLeave事件的控件</param>
        /// <param name="act">无参数的Action</param>
        public static void mouseLeave(this Control @this, Action act)
        {
            @this.MouseLeave += (sender, e) => {
                act();
            };
        }
        #endregion
        #endregion

        #region 工具
        //递归拿到一个Control的所有子控件
        /// <summary>
        /// 递归拿到一个Control的所有子控件
        /// </summary>
        /// <param name="@this">要操作的控件</param>
        /// <returns>子控件,泛型List</returns>
        public static List<Control> GetAllControls(this Control @this)
        {
            List<Control> ctls = new List<Control>();
            foreach (Control subControl in @this.Controls)
            {
                ctls.Add(subControl);//添加一个
                if (subControl.Controls.Count > 0)
                {
                    ctls.AddRange(GetAllControls(subControl));
                }

            }
            return ctls;
        }
        #endregion
    }
}
