using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class FormMenu : Form
    {
        public SoundPlayer player = new SoundPlayer("./sound/menu.wav");

        public FormMenu()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja realmente sair?", "Confirmar Saída", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmdNovoJogo_Click(object sender, EventArgs e)
        {
            player.Stop();
            new FormJogo(this).Show();
        }

        private void cmdInstrucoes_Click(object sender, EventArgs e)
        {
            new FormInstrucoes().Show();
        }

        private void cmdPontuacao_Click(object sender, EventArgs e)
        {
            player.Stop();
            //MessageBox.Show("Recordes do jogo!\nA idéia é criar uma tela para isso também com a opção de filtro por nível", "Pontuação");
        }

        private void cmdSobre_Click(object sender, EventArgs e)
        {
            player.Stop();
            FormSobre fs = new FormSobre(this);

            fs.BackgroundImage = Image.FromFile("./img/telas/sobre.jpg");
            fs.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}
