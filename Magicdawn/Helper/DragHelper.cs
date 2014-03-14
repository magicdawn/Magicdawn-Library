using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 2014-2-8 12:57:59
 * 2014-2-19 16:13:20 修改,更名
 * 
 * BY Magicdawn
 * 
 * 说明:经常处理一些Drag事件
 */
namespace Magicdawn
{
    public static class DragHelper
    {
        /// <summary>
        /// Ctrl键是否按住
        /// </summary>
        public const int CtrlMask = 8;//Ctrl键是否按住

        #region 数据Drag Target

        //获取拖放 文件(一个)
        /// <summary>
        /// 获取拖放 文件(一个)
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string GetDragFile(this DragEventArgs e)
        {
            return GetDragFiles(e)[0];
        }
        //获取拖放的 文件列表
        /// <summary>
        /// 获取拖放的 文件列表
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string[] GetDragFiles(this DragEventArgs e)
        {
            return (string[])e.Data.GetData(DataFormats.FileDrop);
        }

        //设置AllowDrop,处理DragEnter事件
        /// <summary>
        /// 处理DragEnter事件
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="format"></param>
        public static void EnableDragTarget(this Control ctl,string format)
        {
            ctl.AllowDrop = true;//启用AllowDrop
            //sender dragEventArgs
            ctl.DragEnter += (s,e) => {
                /*
                 * 也可以不验证格式,在GetData()时不会出错
                 */
                if(e.Data.GetDataPresent(format))//格式符合要求,
                {
                    if((e.KeyState & CtrlMask) == CtrlMask)//按住Ctrl键了
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.Move;
                    }
                }
            };
        }
        //设置AllowDrop,处理DragEnter事件,同时处理DragDop
        /// <summary>
        /// 设置AllowDrop,处理DragEnter事件,同时处理DragDop
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="format">拖放数据格式</param>
        /// <param name="act">拿到数据后操作,输入参数为data,拿到强制转换即可</param>
        public static void EnableDragTarget(this Control ctl,string format,Action<object> act)
        {
            EnableDragTarget(ctl,format);
            //drag drop
            ctl.DragDrop += (s,e) => {
                act(e.Data.GetData(format));
            };
        }

        //为某控件启用从其他地方Drag Text过来功能
        /// <summary>
        /// 为某控件启用从其他地方Drag Text过来功能
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="mode"></param>
        public static void EnableDragTextTarget(this Control ctl,EDragTextMode mode
            = EDragTextMode.Replace)
        {
            EnableDragTarget(ctl,DataFormats.Text);//drag enter

            ctl.DragDrop += (s,e) => {
                string txt = (string)e.Data.GetData(DataFormats.Text);
                switch(mode)
                {
                    case EDragTextMode.Append:
                        ctl.Text += txt;
                        break;
                    case EDragTextMode.AppendLine:
                        ctl.Text += txt + "\r\n";
                        break;
                    case EDragTextMode.Prepend:
                        ctl.Text = txt + ctl.Text;
                        break;
                    case EDragTextMode.PrependLine:
                        ctl.Text = txt + "\r\n" + ctl.Text;
                        break;
                    case EDragTextMode.Replace:
                        ctl.Text = txt;
                        break;
                    default:
                        break;
                }
            };
        }
        //自定义文本到达时的操作
        /// <summary>
        /// 为某控件启用从其他地方Drag Text过来功能,可自定义文本到达时的操作
        /// </summary>
        /// <param name="ctl">控件</param>
        /// <param name="act">自定义文本到达时的操作</param>
        public static void EnableDragTextTarget(this Control ctl,Action<string> act)
        {
            EnableDragTarget(ctl,DataFormats.Text,data => act((string)(data)));
        }

        //文件拖拽操作
        public static void EnbaleDragFileTarget(this Control ctl,Action<string> act)
        {
            //启用拖放
            EnableDragTarget(ctl,DataFormats.FileDrop);
            ctl.DragDrop += (s,e) => {
                act(e.GetDragFile());
            };
        }
        //文件列表
        public static void EnableDragFilesTarget(this Control ctl,Action<string[]> act)
        {
            EnableDragTarget(ctl,DataFormats.FileDrop);
            ctl.DragDrop += (s,e) => {
                act(e.GetDragFiles());
            };
        }
        #endregion

        #region 数据Drag Source
        //将控件设置为 拖放源(Drag Source)
        public static void EnableDragSource(this Control ctl,Func<Control,object> getData)
        {
            ctl.MouseDown += (s,e) => {
                if(e.Button == MouseButtons.Left)
                {
                    ctl.DoDragDrop(getData(ctl),DragDropEffects.All);
                }
            };
        }
        #endregion

        #region 位置Drag
        //控件的位置可拖动,非数据
        public static void EnableControlDrag(this Control ctl)
        {
            ctl.BringToFront();
            Point p = new Point();
            ctl.MouseDown += (s,e) => {
                if(e.Button == MouseButtons.Left)
                {
                    p = e.Location;
                }
            };
            ctl.MouseMove += (s,e) => {
                if(e.Button == MouseButtons.Left)
                {
                    //mouseposition偏移之后的是屏幕坐标,转换为父控件 的client坐标
                    ctl.Location = ctl.Parent.PointToClient(Control.MousePosition.Minus(p));
                }
            };
        }
        #endregion
    }
}
