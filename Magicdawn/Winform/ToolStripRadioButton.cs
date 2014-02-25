using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

/*
 * 通过Checked属性 Click事件来模拟RadioButon
 * 
 * 如果CheckOnClick为true,那一个Group里面,
 *  再次点击一个已经checked,应该没有反应才对
 *  
 * so应该自己来管理checked状态
 */

namespace Magicdawn.Winform
{
    /// <summary>
    /// ToolStrip上的单选按钮,设置GroupName为一组
    /// </summary>
    public class ToolStripRadioButton : ToolStripButton
    {
        [Description("同一GroupName下的RadioButton只能单选"), Category("自定义属性")]
        public string GroupName { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //将本身checked为true,然后其他的false
            if (!this.Checked)//如果当前项已是选中项,就什么都不做
            {
                this.Checked = true;
                var others = from ToolStripItem c in this.Owner.Items
                             where c is ToolStripRadioButton //RadioButton on strip
                             let rdb = c as ToolStripRadioButton//中转
                             where rdb != this && //除去自己
                             rdb.GroupName == this.GroupName//等于当前的GroupName
                             select rdb;
                //其他组成员 设为false
                foreach (var c in others)
                {
                    c.Checked = false;
                }
            }
        }
    }
}
