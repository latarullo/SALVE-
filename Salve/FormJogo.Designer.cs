namespace WindowsFormsApplication1
{
    partial class FormJogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJogo));
            this.tmrVirada = new System.Windows.Forms.Timer(this.components);
            this.tmrVisualizacao = new System.Windows.Forms.Timer(this.components);
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrVirada
            // 
            this.tmrVirada.Tick += new System.EventHandler(this.tmrVirada_Tick);
            // 
            // tmrVisualizacao
            // 
            this.tmrVisualizacao.Interval = 5000;
            this.tmrVisualizacao.Tick += new System.EventHandler(this.tmrVisualizacao_Tick);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.Location = new System.Drawing.Point(11, 47);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(107, 23);
            this.lblPontuacao.TabIndex = 4;
            this.lblPontuacao.Text = "0";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Transparent;
            this.cmdSair.Location = new System.Drawing.Point(36, 6);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(71, 25);
            this.cmdSair.TabIndex = 6;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 136);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.lblPontuacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJogo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer tmrVirada;
        public System.Windows.Forms.Timer tmrVisualizacao;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label cmdSair;
        private System.Windows.Forms.Label label1;


    }
}

