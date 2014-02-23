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
    public partial class FrmDragHelper : Form
    {
        public FrmDragHelper()
        {
            InitializeComponent();
        }

        private void DragHelper_Load(object sender, EventArgs e)
        {
            //开启接受拖拽
            Magicdawn.DragHelper.EnableDragTextTarget(this.textBox1,Magicdawn.EDragTextMode.Replace);

            //自己可以拖拽
            //Magicdawn.DragHelper.EnableDragForTextBox(this.textBox1);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse down ..."+e.Clicks + this.textBox1.SelectedText);
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse up ...");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click...");
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse click ...");
        }
    }
}
