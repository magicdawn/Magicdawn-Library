using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using DevComponents.DotNetBar.Validator;

/*
 * 2014-2-6 20:27:23 问题:
 * 
 * 1.设定UserPaint为true时,onpaint至画边框
 *      去掉base.Onpaint,只画边框,无文字,聚焦后有 默认文字
 *      不去掉base, 无论先base 还是后base ,情况与前面相同
 * 2.只能取非UserPaint方法
 *      鼠标移上不引发Onpaint事件
 *      在WndProc里Hook
 *      
 * 2014-2-7 15:00:32
 * 用DevExpress的Highlighter组件解决高亮问题
 * 
 * 2014-2-8 15:18:09
 * Drag
 */
namespace Magicdawn.Winform
{
    /// <summary>
    /// 加入各种功能的TextBox
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]//工具箱上使用TextBox的图标
    [Designer(typeof(DawnTextBoxDesigner))]//将设计器与控件关联
    public class DawnTextBox : TextBox
    {
        Highlighter highlighter = null;
        public DawnTextBox()
        {
            //初始化的属性
            this.EnterSound = false;

            this.EnableWaterText = true;//默认启用水印
            this.WaterText = string.Empty;//默认空
            this.WaterColor = Color.Gray;//水印文字 默认灰

            //this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnableHighlightBorder = true;//启用高亮边框
            this.HighlightBorderColor = eHighlightColor.Orange;//默认orange
        }

        #region 回车有无声音
        /// <summary>
        /// 按回车键时有木有声音
        /// </summary>
        [Description("按回车键时有无声音,默认无"),
        DefaultValue(false),
        Category("自定义属性")]
        public bool EnterSound { get; set; }

        //windows acceptbutton-and-cancelbutton 找不到acceptbutton所以弹出警告
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!this.EnterSound && //没有回车声
                !this.Multiline && //单行模式
                keyData == Keys.Enter) //回车键
            {
                this.OnOk();//触发Ok事件
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// 扩展出Ok事件,回车时触发(必须设置EnterSound为False)
        /// </summary>
        [Description("扩展出Ok事件,回车时触发(必须设置EnterSound为False)")]
        public event EventHandler Ok;

        /// <summary>
        /// On函数,.NET做法
        /// </summary>
        private void OnOk()
        {
            if (this.Ok != null)
            {
                Ok(this, new EventArgs());
            }
        }
        #endregion

        #region 文字水印,归到外观
        [Description("是否启用文字水印"), Category("外观"), DefaultValue(true)]
        public bool EnableWaterText { get; set; }
        [Description("水印文字"), Category("外观")]
        public string WaterText { get; set; }
        [Description("水印文字的颜色,默认Gray"),
        Category("外观"),
        DefaultValue(typeof(Color), "Gray")]
        public Color WaterColor { get; set; }

        //默认有
        //然后获得焦点,去掉
        ////失去焦点,再画上
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 15) //WM_Paint消息
            {
                this.DrawText();//文字
            }
        }

        //画文字
        private void DrawText()
        {
            //水印文字
            if (this.EnableWaterText &&
                string.IsNullOrWhiteSpace(this.Text) && //输入的文字不为空
                !string.IsNullOrWhiteSpace(this.WaterText) && //水印文字不为空
                !this.Focused) //当前文本框聚焦
            {
                TextFormatFlags flags = TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis;//文本如何显示
                if (this.RightToLeft == RightToLeft.Yes)
                {
                    flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                } using (Graphics graphics = this.CreateGraphics())
                {

                    TextRenderer.DrawText(graphics, this.WaterText,
                        new Font(this.Font, FontStyle.Italic),
                        this.ClientRectangle,
                        this.WaterColor, flags);
                }
            }

        }
        #endregion

        #region 高亮边框
        [Description("是否启用高亮"),
        Category("外观"),
        DefaultValue(true)]
        public bool EnableHighlightBorder { get; set; }

        [Description("边框高亮所用的颜色"),
        Category("外观"),
        DefaultValue(eHighlightColor.Orange)]
        public eHighlightColor HighlightBorderColor { get; set; }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (EnableHighlightBorder)
            {
                highlighter.SetHighlightColor(this, this.HighlightBorderColor);
            }

        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (EnableHighlightBorder)
            {
                highlighter.SetHighlightColor(this, eHighlightColor.None);
            }
        }
        protected override void OnParentChanged(EventArgs e)
        {
            this.highlighter = new Highlighter {
                ContainerControl = this.FindForm()
            };
            base.OnParentChanged(e);
        }
        #endregion

        #region 拖拽相关
        public bool EnableDrag { get; set; }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.MouseDown += (s, e_down) => {
                if (this.SelectionLength > 0 &&
                    e_down.Button == MouseButtons.Left &&
                    e_down.Clicks == 1)
                {
                    this.DoDragDrop(this.SelectedText, DragDropEffects.All);
                }
            };
            base.OnMouseDown(e);
        }
        #endregion
    }
}
