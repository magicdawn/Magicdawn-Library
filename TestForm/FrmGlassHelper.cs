using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FrmGlassHelper : Form
    {
        public FrmGlassHelper()
        {
            InitializeComponent();
        }

        private void FrmGlassHelper_Load(object sender,EventArgs e)
        {
            //this.BackColor = this.TransparencyKey = Color.FromArgb(250,250,249);
            //var m = new Magicdawn.Margin();
            ////m.Top = m.Bottom = this.ClientRectangle.Height / 2;
            ////m.Left = m.Right = this.ClientRectangle.Width / 2;中间有个小点
            //m.Top = this.ClientRectangle.Height;
            //m.Bottom = -1;
            //this.Resize += (s,e_resize) => {
            //    m.Top = this.ClientRectangle.Height;
            //    Magicdawn.Win32.Api.DwmExtendFrameIntoClientArea(this.Handle,ref m);
            //};
            //Magicdawn.Win32.Api.DwmExtendFrameIntoClientArea(this.Handle,ref m);

            Magicdawn.DragHelper.EnableControlDrag(this.button1);

        }

        private void button1_Click(object sender,EventArgs e)
        {

        }

        private void button1_Click_1(object sender,EventArgs e)
        {
            Magicdawn.FormHelper.EnableAeroForm(this);
            Magicdawn.FormHelper.EnableClientAreaDrag(this);
        }
    }
}
