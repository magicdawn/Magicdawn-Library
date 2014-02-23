using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Magicdawn;

/*
 * 2014-2-13 15:23:09修改
 * 
 * BY Magicdawn
 */
namespace Magicdawn
{
    public class FormHelper
    {
        #region 无边框拖动
        /*
         * 主要三种做法
         * 
         * 1.在WinProc里截获WM_LBUTTONDOWN消息
         *   接着给窗体发送WM_SYSCOMMAND,以及附加参数,移动消息
         *   比较保险,效率还行
         *   
         * 2.WinProc里截获WM_Lbutton消息
         *   将Message.Msg替换成WM_NCHIxxx 消息
         *   将wparam替换成HTCAPTION 标题栏
         *   效率最高,但是不能响应 鼠标Click,MouseDown事件了
         *   
         * 3.根据MouseDown MouseMove偏移来改变窗体的Location
         *   效率最低,最安全
         */

        //WM_SYSCOMMAND做法,需要在WinProc里调用
        /// <summary>
        /// 发送WM_SYSCOMMAND消息做法,需要在WinProc里调用
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="m"></param>
        public static void NoneBorderFormDrag(Form frm, Message m)
        {
            try
            {
                if (m.Msg == Win32.WinMsg.WM_LBUTTONDOWN)
                {
                    Win32.Api.ReleaseCapture();
                    Win32.Api.SendMessage(frm.Handle,
                        Win32.WinMsg.WM_SYSCOMMAND,//msg
                        Win32.Consts.SC_MOVE | Win32.Consts.HTCAPTION,//wParam,也可以两个相加
                        0);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //快速版本,修改Msg实现
        /// <summary>
        /// Quick高效版本,替换Msg,不会引发 鼠标单击事件
        /// </summary>
        /// <param name="frm">窗体</param>
        /// <param name="m">Message消息</param>
        public static void NoneBorderFormDragQuick(Form frm, ref Message m)
        {
            if (m.Msg == Win32.WinMsg.WM_LBUTTONDOWN)
            {
                m.Msg = Win32.WinMsg.WM_NCLBUTTONDOWN;//修改为非客户区域,左键
                m.WParam = new IntPtr(Win32.Consts.HTCAPTION);
            }
        }

        //事件版本
        /// <summary>
        /// MouseDown,MouseMove事件版本,需要在Form_Load里使用
        /// </summary>
        /// <param name="frm"></param>
        public static void NonborderFormDragWithEvent(Control frm)
        {
            Point p = new Point();
            frm.MouseDown += (down_sender, down_e) => {
                if (down_e.Button == MouseButtons.Left)
                {
                    p = down_e.Location;
                }
            };
            frm.MouseMove += (move_sender, move_e) => {
                if (move_e.Button == MouseButtons.Left)
                {
                    frm.Location = Control.MousePosition.Minus(p);
                }
            };
        }

        #endregion

        #region 控件相关
        //设置某一控件在父控件中居中
        /// <summary>
        /// 设置某一控件在父控件中居中
        /// </summary>
        /// <param name="this"></param>
        /// <param name="parent"></param>
        public static void SetCenter(Control @this, Control parent = null)
        {
            @this.Location = GetCenterLocation(@this, parent);
        }

        /// <summary>
        /// 一个控件在父控件中居中时,此控件的Location
        /// </summary>
        /// <param name="this"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static Point GetCenterLocation(Control @this, Control parent = null)
        {
            if (parent == null)
            {
                parent = @this.Parent;
            }
            var x = (parent.Width - @this.Width) / 2;
            var y = (parent.Height - @this.Height) / 2;
            return new Point(x, y);
        }
        #endregion
    }
}
