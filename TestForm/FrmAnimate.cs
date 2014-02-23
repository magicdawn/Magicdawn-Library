using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magicdawn;
namespace TestForm
{
    public partial class FrmAnimate : Form
    {
        public FrmAnimate()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void FrmAnimate_Load(object sender, EventArgs e)
        {
            Magicdawn.FormHelper.NonborderFormDragWithEvent(this);
        }

        private void FrmAnimate_Shown(object sender, EventArgs e)
        {
            //Task.Run(() => {
            //    AnimateHelper.SlideForm(this);
            //}).ContinueWith((t) => {
            //    AnimateHelper.SlideFromLeft(this.listView1);
            //}).ContinueWith((t) => {
            //    AnimateHelper.SlideFromRight(this.listBox1);
            //}).ContinueWith((t) => {
            //    
            //}).ContinueWith((t) => {
            //    
            //});
            Task.Run(() => { 
                AnimateHelper.SlideFormSync(this);
                AnimateHelper.SlideLeftSync(this.listView1);
                AnimateHelper.SlideRightSync(this.listBox1);
                AnimateHelper.SlideTopSync(this.label1);
                AnimateHelper.SlideBottomSync(this.button1);
            });
        }

        private void FrmAnimate_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(this.listView1.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimateHelper.AnimateSync(this.listView1, new Magicdawn.AnimateOption {
                X = this.listView1.Location.X + 300,
                Speed = 300
            });
        }
    }
}
