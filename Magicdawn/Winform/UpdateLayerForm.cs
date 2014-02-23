/*
 * 2014-2-6 17:36:42
 * 
 * BY Magicdawn
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magicdawn.Winform
{
    /// <summary>
    /// 对UpdateLayerWindow API封装的特定窗体
    /// </summary>
    public class UpdateLayerForm : Form
    {
        public UpdateLayerForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //deal with none border form drag
        protected override void WndProc(ref Message m)
        {
            Magicdawn.FormHelper.NoneBorderFormDrag(this, m);
            base.WndProc(ref m);
        }

        //let the form hide
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= Win32.WinStyle.WS_EX_LAYERED;
                return cp;
            }
        }
    }
}
