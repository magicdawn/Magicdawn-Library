using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn
{
    /// <summary>
    /// Win7 Aero 毛玻璃效果,
    /// </summary>
    public class GlassHelper
    {
        public static bool CreateGlassForm(Form frm, Rectangle rect)
        {
            //不可用,没成功,返回
            //if (!Win32.DwmIsCompositionEnabled())
            {
                return false;
            }

            IntPtr hWnd = frm.Handle;
            if (hWnd == IntPtr.Zero)
            {
                throw new InvalidOperationException("窗口必须先Show才能设置毛玻璃效果~");
            }

            frm.AllowTransparency = true;
            frm.TransparencyKey = frm.BackColor;
            Area area = new Area(rect);
            //Win32.DwmExtendFrameIntoClientArea(hWnd, ref area);
            return true;
        }

        public static bool CreateGlassForm(Form frm)
        {
            return CreateGlassForm(frm, frm.ClientRectangle);//默认为ClientRectangle
        }
    }

    /// <summary>
    /// 要弄的区域
    /// </summary>
    public struct Area
    {
        public int Top;
        public int Bottom;
        public int Left;
        public int Right;

        public Area(Rectangle rect)
        {
            this.Top = rect.Location.X;
            this.Left = rect.Location.Y;

            this.Bottom = this.Top + rect.Height;
            this.Right = this.Left + rect.Width;
        }
    }
}
