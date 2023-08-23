using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAcerto : Form
    {
        FormJogo formJogo;

        public FormAcerto(FormJogo fj)
        {
            this.formJogo = fj;
            InitializeComponent();
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            if (formJogo.usuarioVenceu())
            {
                formJogo.player.SoundLocation = "./sound/venceu.wav";
                formJogo.player.Play();

                if (MessageBox.Show("Parabéns, você venceu. Deseja jogar novamente?", "Fim de jogo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    formJogo.player.Stop();
                    this.Close();
                    formJogo.Focus();
                    formJogo.iniciarNovoJogo();
                    return;
                }
                else
                {
                    formJogo.player.Stop();
                    this.Close();
                    formJogo.Close();
                    formJogo.formMenu.Focus();
                    formJogo.formMenu.player.SoundLocation = "./sound/menu.wav";
                    formJogo.formMenu.player.PlayLooping();
                }
            }
            this.Close();
        }

        private void FormAcerto_Load(object sender, EventArgs e)
        {

        }
    }
}
