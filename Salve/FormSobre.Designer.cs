namespace WindowsFormsApplication1
{
    partial class FormSobre
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
            if (disposing && (components != null))
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
            this.cmdVoltar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.Transparent;
            this.cmdVoltar.Location = new System.Drawing.Point(660, 35);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(100, 23);
            this.cmdVoltar.TabIndex = 1;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.ControlBox = false;
            this.Controls.Add(this.cmdVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSobre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cmdVoltar;

    }
}