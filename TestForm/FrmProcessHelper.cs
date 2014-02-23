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
    public partial class FrmProcessHelper : Form
    {
        public FrmProcessHelper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Magicdawn.ProcessHelper.GetIdByName("smynesc");
            MessageBox.Show(id.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = Magicdawn.MemoryHelper.ReadByte(0x06D30092);

            MessageBox.Show(data.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Magicdawn.MemoryHelper.WriteInt(0x06D30092, (int)this.numericUpDown1.Value);
        }
    }
}
