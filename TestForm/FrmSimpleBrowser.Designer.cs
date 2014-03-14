namespace TestForm
{
    partial class FrmSimpleBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleBrowser1 = new Magicdawn.Winform.SimpleBrowser();
            this.SuspendLayout();
            // 
            // simpleBrowser1
            // 
            this.simpleBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleBrowser1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleBrowser1.Location = new System.Drawing.Point(0, 0);
            this.simpleBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.simpleBrowser1.Name = "simpleBrowser1";
            this.simpleBrowser1.Size = new System.Drawing.Size(607, 389);
            this.simpleBrowser1.TabIndex = 0;
            // 
            // FrmSimpleBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 389);
            this.Controls.Add(this.simpleBrowser1);
            this.Name = "FrmSimpleBrowser";
            this.Text = "FrmSimpleBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private Magicdawn.Winform.SimpleBrowser simpleBrowser1;
    }
}