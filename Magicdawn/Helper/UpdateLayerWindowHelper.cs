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
        public static void Draw(Form frm,Bitmap bitmap)
        {
            if(!Bitmap.IsCanonicalPixelFormat(bitmap.PixelFormat) ||
                !Bitmap.IsAlphaPixelFormat(bitmap.PixelFormat))
                throw new ApplicationException("图片必须是32位带Alhpa通道的图片...");

            IntPtr oldBits = IntPtr.Zero;
            IntPtr hBitmap = IntPtr.Zero;
            IntPtr srcDc = Win32.Api.CreateCompatibleDC(Win32.Api.GetDC(IntPtr.Zero));

            try
            {
                Point ptSrc = new Point(0,0);
                Point ptDest = new Point(frm.Left,frm.Top);
                Size size = bitmap.Size;

                Win32.BLENDFUNCTION blendFunc = new Win32.BLENDFUNCTION();               

                hBitmap = bitmap.GetHbitmap(Color.FromArgb(0));
                oldBits = Win32.Api.SelectObject(srcDc,hBitmap);

                blendFunc.BlendOp = Win32.Consts.AC_SRC_OVER;
                blendFunc.SourceConstantAlpha = 255;
                blendFunc.AlphaFormat = Win32.Consts.AC_SRC_ALPHA;
                blendFunc.BlendFlags = 0;

                Win32.Api.UpdateLayeredWindow(
                    frm.Handle,
                    IntPtr.Zero,//screenDC,//destDc
                    ref ptDest,//destPoint
                    ref size,//size

                    srcDc,//srcdc
                    ref ptSrc,//src point

                    0,//crkey
                    ref blendFunc,//pblend
                    Win32.Consts.ULW_ALPHA//dwFlags
                );
            }
            finally
            {
                if(hBitmap != IntPtr.Zero)
                {
                    Win32.Api.SelectObject(srcDc,oldBits);
                    Win32.Api.DeleteObject(hBitmap);
                }
                Win32.Api.DeleteDC(srcDc);
            }
        }
    }
}