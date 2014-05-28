using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn
{
    public class DrawHelper
    {
        #region OLD
        // Methods
        public static GraphicsPath CreateRoundPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180f, 90f);
            path.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - (cornerRadius * 2), rect.Y);
            path.AddArc((rect.X + rect.Width) - (cornerRadius * 2), rect.Y, cornerRadius * 2, cornerRadius * 2, 270f, 90f);
            path.AddLine(rect.Right, rect.Y + (cornerRadius * 2), rect.Right, (rect.Y + rect.Height) - (cornerRadius * 2));
            path.AddArc((int)((rect.X + rect.Width) - (cornerRadius * 2)), (int)((rect.Y + rect.Height) - (cornerRadius * 2)), (int)(cornerRadius * 2), (int)(cornerRadius * 2), 0f, 90f);
            path.AddLine(rect.Right - (cornerRadius * 2), rect.Bottom, rect.X + (cornerRadius * 2), rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90f, 90f);
            path.AddLine(rect.X, rect.Bottom - (cornerRadius * 2), rect.X, rect.Y + (cornerRadius * 2));
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath CreateRoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float width = r.Width;
            float height = r.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            path.AddLine(x + r1, y, (x + width) - r2, y);
            path.AddBezier((x + width) - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
            path.AddLine((float)(x + width), (float)(y + r2), (float)(x + width), (float)((y + height) - r3));
            path.AddBezier((float)(x + width), (float)((y + height) - r3), (float)(x + width), (float)(y + height), (float)((x + width) - r3), (float)(y + height), (float)((x + width) - r3), (float)(y + height));
            path.AddLine((float)((x + width) - r3), (float)(y + height), (float)(x + r4), (float)(y + height));
            path.AddBezier(x + r4, y + height, x, y + height, x, (y + height) - r4, x, (y + height) - r4);
            path.AddLine(x, (y + height) - r4, x, y + r1);
            return path;
        }

        public static void DrawImage(Graphics g, Image image,
            int x1, int y1, int width1, int height1,
            int x2, int y2, int width2, int height2)
        {
            g.DrawImage(image,
                new Rectangle(x1, y1, width1, height1),//destination rectangle
                x2, y2, width2, height2,//src    x,y    width,height
                GraphicsUnit.Pixel);
        }

        public static void RenderBackground(Graphics g,
            Rectangle rect, int cut, Image img)
        {
            Rectangle[,] rects = new Rectangle[3, 3];//目标区域,相对于窗体来说
            Point[,] Points = new Point[3, 3];//image起始点

            //top-left
            g.DrawImage(img,
                new Rectangle(rect.X, rect.Y, cut, cut),
                0, 0, cut, cut, GraphicsUnit.Pixel);

            //top-center
            g.DrawImage(img,
                new Rectangle(rect.X + cut, rect.Y, rect.Width - (cut * 2), cut),
                cut, 0, img.Width - (cut * 2), cut,
                GraphicsUnit.Pixel);

            //top-right
            g.DrawImage(img,
                new Rectangle((rect.X + rect.Width) - cut, rect.Y, cut, cut),
                img.Width - cut, 0, cut, cut,
                GraphicsUnit.Pixel);

            //center-left
            g.DrawImage(img,
                new Rectangle(rect.X, rect.Y + cut, cut, rect.Height - (cut * 2)),
                0, cut, cut, img.Height - (cut * 2),
                GraphicsUnit.Pixel);

            //
            g.DrawImage(img,
                new Rectangle(rect.X, (rect.Y + rect.Height) - cut, cut, cut), 0,
                img.Height - cut, cut, cut,
                GraphicsUnit.Pixel);

            //
            g.DrawImage(img,
                new Rectangle((rect.X + rect.Width) - cut, rect.Y + cut,
                    cut, rect.Height - (cut * 2)),
                img.Width - cut, cut, cut, img.Height - (cut * 2),
                GraphicsUnit.Pixel);

            //
            g.DrawImage(img,
                new Rectangle((rect.X + rect.Width) - cut, (rect.Y + rect.Height) - cut, cut, cut),
                img.Width - cut, img.Height - cut, cut, cut,
                GraphicsUnit.Pixel);

            //
            g.DrawImage(img,
                new Rectangle(rect.X + cut, (rect.Y + rect.Height) - cut, rect.Width - (cut * 2), cut),
                cut, img.Height - cut, img.Width - (cut * 2), cut,
                GraphicsUnit.Pixel);

            ////center-center
            //g.DrawImage(img,
            //    new Rectangle(rect.X + cut, rect.Y + cut, rect.Width - (cut * 2), rect.Height - (cut * 2)),
            //    cut, cut, img.Width - (cut * 2), img.Height - (cut * 2),
            //    GraphicsUnit.Pixel);
        }

        //用颜色画边框
        public static void DrawBorder(Graphics g,
            int x, int y, int width, int height,//位置,大小
            Color color,
            int borderWidth,
            int innerBorderWidth = 1)//内边框宽度
        {
            using (var brush = new SolidBrush(color))
            {
                //上
                g.FillRectangle(brush,
                    x - borderWidth, y - borderWidth, //起点
                    width + 2 * borderWidth, borderWidth + innerBorderWidth); //宽度,高度

                //下
                g.FillRectangle(brush,
                    x - borderWidth, y + height - innerBorderWidth,
                    width + 2 * borderWidth, borderWidth + innerBorderWidth);

                //左
                g.FillRectangle(brush,
                    x - borderWidth, y,
                    borderWidth + innerBorderWidth, height);
                //右
                g.FillRectangle(brush,
                    x + width - innerBorderWidth, y,
                    borderWidth + innerBorderWidth, height);

            }
        }
        #endregion

        //得到一个background 再画上去
        public static void DrawBackGround(Control ctl,Image src)
        {
            using (var g = ctl.CreateGraphics())
            {
                var bkg = GetBackground(src,ctl.Width, ctl.Height, 5);//src->bkg
                g.DrawImage(bkg, 0, 0, ctl.Width, ctl.Height);
            }
        }

        //将width x height的Rectangle按cut切成九块
        private static Rectangle[,] GetRectangles(int width, int height, int cut)
        {
            return new Rectangle[3, 3]{
                {
                    new Rectangle(0,0,cut,cut),
                    new Rectangle(cut,0,width-2*cut,cut),
                    new Rectangle(width-cut,0,cut,cut)
                },
                {
                    new Rectangle(0,cut,cut,height-2*cut),
                    new Rectangle(cut,cut,width-2*cut,height-2*cut),
                    new Rectangle(width-cut,cut,cut,height-2*cut)
                },
                {
                    new Rectangle(0,height-cut,cut,cut),
                    new Rectangle(cut,height-cut,width-2*cut,cut),
                    new Rectangle(width-cut,height-cut,cut,cut)
                }
            };
        }

        //根据大小获取image
        public static Image GetBackground(Image src,int width, int height, int cut)
        {
            Image bkg = new Bitmap(width, height);//src->bkg

            Rectangle[,] destRects = GetRectangles(width, height, cut);//对bkg来说
            Rectangle[,] srcRects=GetRectangles(src.Width,src.Height,cut);//对小图

            using (var g=Graphics.FromImage(bkg))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        g.DrawImage(src,destRects[i,j],srcRects[i,j],GraphicsUnit.Pixel);
                    }
                }
            }
            return bkg;
        }
    }
}