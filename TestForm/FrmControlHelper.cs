using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class FrmControlHelper : Form
    {
        public FrmControlHelper()
        {
            InitializeComponent();
        }

        private void FrmControlHelper_Load(object sender, EventArgs e)
        {
            Magicdawn.DragHelper.EnableControlDrag(this.button1);
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            Magicdawn.DragHelper.EnableControlDrag(e.Control);
        }
    }
}
