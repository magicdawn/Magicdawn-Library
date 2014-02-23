using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magicdawn;

namespace TestForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FtpClient fc = new FtpClient("127.0.0.1", "magicdawn", "");
            fc.RemotePath = "FTP客户端创建";
            if (fc.CheckFileExist("test.txt"))
            {
                MessageBox.Show("存在");
            }
            else
                MessageBox.Show("不存在");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FtpClient fc = new FtpClient("127.0.0.1", "magicdawn", "");
            fc.UseEncode = System.Text.Encoding.UTF8;
            var list = fc.GetFileDetails();
            foreach (var item in list)
            {
                textBox1.Text += (item + "\r\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToStringX());
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnGlassForm_Click(object sender, EventArgs e)
        {
            //GlassHelper.CreateGlassForm(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.TranslateTransform(350, 200);

            g.DrawCoordinate(new CoordinateOption {
                Fx = 0,
                Fy = 0,
                ArrowBrush = Brushes.BlueViolet
            });


            base.OnPaint(e);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FrmDragHelper().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FrmProcessHelper().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FrmAnimate().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FrmLittleIdea().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new FrmControlHelper().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ClientRectangle.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.DisplayRectangle.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.PointToClient(Control.MousePosition).ToString());
        }
    }
}