using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Magicdawn;
using System.Diagnostics;

/*
 * 2014-2-13 15:23:09修改
 * 2014-3-6 20:27:46 增加Aero效果,增加ClientAreaDrag客户区拖动
 * 
 * BY Magicdawn
 */
namespace Magicdawn
{
    /// <summary>
    /// 对于WinForm的Form辅助类
    /// </summary>
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
        public static void NoneBorderFormDrag(Form frm,Message m)
        {
            try
            {
                if(m.Msg == Win32.WinMsg.WM_LBUTTONDOWN)
                {
                    Win32.Api.ReleaseCapture();
                    Win32.Api.SendMessage(frm.Handle,
                        Win32.WinMsg.WM_SYSCOMMAND,//msg
                        Win32.Consts.SC_MOVE | Win32.Consts.HTCAPTION,//wParam,也可以两个相加
                        0);
                }
            }
            catch(Exception ex)
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
        public static void NoneBorderFormDragQuick(Form frm,ref Message m)
        {
            if(m.Msg == Win32.WinMsg.WM_LBUTTONDOWN)
            {
                m.Msg = Win32.WinMsg.WM_NCLBUTTONDOWN;//修改为非客户区域,左键
                m.WParam = new IntPtr(Win32.Consts.HTCAPTION);
            }
        }

        //事件版本
        /// <summary>
        /// MouseDown,MouseMove事件版本,需要在Form_Load里使用
        /// </summary>
        /// <param name="ctl"></param>
        public static void NonborderFormDragWithEvent(Control ctl)
        {
            Point p = new Point(0,0);
            ctl.MouseDown += (down_sender,down_e) => {
                if(down_e.Button == MouseButtons.Left)
                {
                    p = down_e.Location;
                    //Debug.WriteLine("mouse down p " + p);
                }
            };
            ctl.MouseMove += (move_sender,move_e) => {
                if(move_e.Button == MouseButtons.Left)
                {
                    if(ctl is Form)
                    {
                        ctl.Location = Control.MousePosition.Minus(p);
                    }
                    else
                    {
                        ctl.FindForm().Location = Control.MousePosition
                            .Minus(p)//平移p
                            .Minus(ctl.Location);//平移控件的location
                    }

                    //Debug.WriteLine("mouse move p " + p);
                    //Debug.WriteLine("control.mouse" + Control.MousePosition);
                    //Console.WriteLine("frm loc" + ctl.Location);
                }
            };
        }

        #endregion

        #region 有边框,非标题栏区域拖动,对于有标题的控件,如GroupBox等都适用
        /// <summary>
        /// 有边框,使非标题栏区域拖动,对于有标题的控件,如GroupBox等都适用
        /// </summary>
        /// <param name="frm">要设置的窗体</param>
        public static void EnableClientAreaDrag(Form frm)
        {
            Point p = new Point();
            frm.MouseDown += (down_sender,down_e) => {
                if(down_e.Button == MouseButtons.Left)
                {
                    //p为当前鼠标 至 窗体左上角位置
                    p = frm.PointToScreen(down_e.Location).Minus(frm.Location);
                }
            };
            frm.MouseMove += (move_sender,move_e) => {
                if(move_e.Button == MouseButtons.Left)
                {
                    frm.Location = Control.MousePosition.Minus(p);
                }
            };
        }
        #endregion

        #region 使整个窗体呈现毛玻璃Aero效果
        /// <summary>
        /// 设置窗体Aero效果
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        public static bool EnableAeroForm(Form frm)
        {
            //http://hi.baidu.com/44498/item/9019813042b89d352f0f810e
            //http://tieba.baidu.com/p/1807435732
            if(Environment.OSVersion.Version.Major < 6)
            {
                throw new NotSupportedException("只支持Windows Vista及以上版本的Windows系统");
            }
            var isEnabled = false;
            Win32.Api.DwmIsCompositionEnabled(ref isEnabled);
            if(!isEnabled)
            {
                throw new NotSupportedException("当前系统不支持Aero效果");
            }
            try
            {
                //设置颜色
                frm.BackColor = frm.TransparencyKey = Color.FromArgb(250,250,249);
                var m = new Margin {
                    Top = frm.ClientRectangle.Height,
                    Bottom = -1
                };
                Win32.Api.DwmExtendFrameIntoClientArea(frm.Handle,ref m);

                //resize仍然可以运行
                frm.Resize += delegate {
                    m.Top = frm.ClientRectangle.Height;
                    Win32.Api.DwmExtendFrameIntoClientArea(frm.Handle,ref m);
                };
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        #endregion

        #region 设置窗体,I prefer

        #endregion
    }

    //系统绘制玻璃效果距离窗体边框的大小
    /// <summary>
    /// 系统绘制玻璃效果距离窗体边框的大小
    /// </summary>
    public struct Margin
    {
        //顺序有关系
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
    }
}
