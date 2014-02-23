using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magicdawn.Winform
{
    public class LittleIdea : DawnForm
    {
        private Label lblMin;
        private Label lblClose;

        public LittleIdea()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.lblClose = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            //this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(319, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 20);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(296, 2);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(17, 21);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "-";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LittleIdea
            //
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblClose);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void WndProc(ref Message m)
        {
            Magicdawn.FormHelper.NoneBorderFormDrag(this, m);
            base.WndProc(ref m);
        }
    }
}
