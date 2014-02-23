using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn
{
    public class UpdateLayerWindowHelper
    {
        /// <summary>
        /// 通过UpdateLayerWindow往屏幕上画Bitmap
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="bitmap"></param>
        public static void Draw(Form frm, Bitmap bitmap)
        {
            //if (!haveHandle) return;

            if (!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) ||
                !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))
                throw new ApplicationException("图片必须是32位带Alhpa通道的图片...");

            IntPtr oldBits = IntPtr.Zero;
            IntPtr screenDC = Win32.Api.GetDC(IntPtr.Zero);
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr memDc = Win32.Api.CreateCompatibleDC(screenDC);

            try
            {
                Point topLoc = new Point(frm.Left, frm.Top);
                Size bitMapSize = new Size(bitmap.Width, bitmap.Height);
                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();
                Point srcLoc = new Point(0, 0);

                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = Win32.Api.SelectObject(memDc, hBitmap);

                blendFunc.BlendOp = Win32.Consts.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = 255;
                blendFunc.AlphaFormat = Win32.Consts.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;

                Win32.Api.UpdateLayeredWindow(frm.Handle, screenDC, ref topLoc, ref bitMapSize, memDc, ref srcLoc, 0, ref blendFunc, Win32.Consts.ULW_ALPHA);
            }
            finally
            {
                if (hBitmap != IntPtr.Zero)
                {
                    Win32.Api.SelectObject(memDc, oldBits);
                    Win32.Api.DeleteObject(hBitmap);
                }
                Win32.Api.ReleaseDC(IntPtr.Zero, screenDC);
                Win32.Api.DeleteDC(memDc);
            }
        }
    }
}
