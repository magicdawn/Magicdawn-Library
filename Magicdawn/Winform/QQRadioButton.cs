using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Winform
{
    [ToolboxBitmap(typeof(RadioButton))]
    public class QQRadioButton : RadioButton
    {
        bool IsMouseOn = false;//控制是否高亮

        // Properties
        internal Rectangle ImageRect
        {
            get
            {
                //ImageRect居中
                return new Rectangle(0, (base.Height - 0x11) / 2, 0x11, 0x11);
            }
        }
        internal Rectangle TextRect
        {
            get
            {
                return new Rectangle(0x11, 0, base.Width - 0x11, base.Height);
            }
        }

        // Methods
        public QQRadioButton()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.Selectable |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint,
                true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.UpdateStyles();
            this.BackColor = Color.Transparent;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            this.IsMouseOn = true;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.IsMouseOn = false;
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// UserPaint为true,自绘
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Graphics显示效果:好
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            //文本格式
            TextFormatFlags flags = TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter;
            Color foreColor = base.Enabled ? this.ForeColor : Color.LightGray;

            //绘制文本域
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font,//文本,字体
                this.TextRect, foreColor, flags);//区域,颜色,格式

            var sb = new StringBuilder("QQRadioButton");
            if (this.IsMouseOn)//高亮
            {
                sb.Append("Highlight");
            }
            else//不高亮
            {
                sb.Append("Normal");
            }
            if (this.Checked)//选中
            {
                sb.Append("Checked");
            }
            var img = ControlResource.ResourceManager.GetObject(sb.ToString()) as Image;
            //左侧图像域
            g.DrawImage(img, ImageRect);
        }
    }
}
