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
    public partial class FrmLittleIdea : Magicdawn.Winform.MyForm
    {
        private FrmMain frmMain;

        public FrmLittleIdea()
        {
            InitializeComponent();
        }

        public FrmLittleIdea(FrmMain frmMain)
        {
            // TODO: Complete member initialization
            this.Owner = frmMain;
        }
    }
}
