namespace WindowsFormsApplication1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.cmdInstrucoes = new System.Windows.Forms.Label();
            this.cmdNovoJogo = new System.Windows.Forms.Label();
            this.cmdPontuacao = new System.Windows.Forms.Label();
            this.cmdSobre = new System.Windows.Forms.Label();
            this.cmdSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdInstrucoes
            // 
            this.cmdInstrucoes.BackColor = System.Drawing.Color.Transparent;
            this.cmdInstrucoes.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInstrucoes.Location = new System.Drawing.Point(300, 514);
            this.cmdInstrucoes.Name = "cmdInstrucoes";
            this.cmdInstrucoes.Size = new System.Drawing.Size(91, 43);
            this.cmdInstrucoes.TabIndex = 6;
            this.cmdInstrucoes.Click += new System.EventHandler(this.cmdInstrucoes_Click);
            // 
            // cmdNovoJogo
            // 
            this.cmdNovoJogo.BackColor = System.Drawing.Color.Transparent;
            this.cmdNovoJogo.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovoJogo.Location = new System.Drawing.Point(166, 514);
            this.cmdNovoJogo.Name = "cmdNovoJogo";
            this.cmdNovoJogo.Size = new System.Drawing.Size(91, 43);
            this.cmdNovoJogo.TabIndex = 7;
            this.cmdNovoJogo.Click += new System.EventHandler(this.cmdNovoJogo_Click);
            // 
            // cmdPontuacao
            // 
            this.cmdPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.cmdPontuacao.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPontuacao.Location = new System.Drawing.Point(166, 48);
            this.cmdPontuacao.Name = "cmdPontuacao";
            this.cmdPontuacao.Size = new System.Drawing.Size(458, 415);
            this.cmdPontuacao.TabIndex = 9;
            this.cmdPontuacao.Click += new System.EventHandler(this.cmdPontuacao_Click);
            // 
            // cmdSobre
            // 
            this.cmdSobre.BackColor = System.Drawing.Color.Transparent;
            this.cmdSobre.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSobre.Location = new System.Drawing.Point(445, 514);
            this.cmdSobre.Name = "cmdSobre";
            this.cmdSobre.Size = new System.Drawing.Size(91, 43);
            this.cmdSobre.TabIndex = 8;
            this.cmdSobre.Click += new System.EventHandler(this.cmdSobre_Click);
            // 
            // cmdSair
            // 
            this.cmdSair.BackColor = System.Drawing.Color.Transparent;
            this.cmdSair.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSair.Location = new System.Drawing.Point(560, 514);
            this.cmdSair.Name = "cmdSair";
            this.cmdSair.Size = new System.Drawing.Size(91, 43);
            this.cmdSair.TabIndex = 10;
            this.cmdSair.Click += new System.EventHandler(this.cmdSair_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 598);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSair);
            this.Controls.Add(this.cmdPontuacao);
            this.Controls.Add(this.cmdSobre);
            this.Controls.Add(this.cmdNovoJogo);
            this.Controls.Add(this.cmdInstrucoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cmdInstrucoes;
        private System.Windows.Forms.Label cmdNovoJogo;
        private System.Windows.Forms.Label cmdPontuacao;
        private System.Windows.Forms.Label cmdSobre;
        private System.Windows.Forms.Label cmdSair;
    }
}