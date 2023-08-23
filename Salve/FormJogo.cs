using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Collections;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class FormJogo : Form
    {
        public SoundPlayer player = new SoundPlayer();
        Mesa mesa;
        long pontuacao;
        public FormMenu formMenu;

        public FormJogo(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniciarNovoJogo();
        }

        public void iniciarNovoJogo()
        {
            mesa = new Mesa(this);
            removerControles(true);
            this.desenharMesa();
            pontuacao = 0;
            this.lblPontuacao.Text = pontuacao.ToString();
            player.SoundLocation = "./sound/embaralhar.wav";
            player.Play();
        }

        public void removerControles(bool removeBichos)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Name == "" || (removeBichos && this.Controls[i].Name == "animalNaFloresta"))
                {
                    this.Controls.RemoveAt(i);
                    i = 0;
                }
            }
        }
        public void desenharMesa()
        {
            removerControles(false);

            int left = 200;
            int top = 40;

            const int CARTAS_POR_LINHA = 6;

            foreach (Carta c in mesa.cartas)
            {
                if (!c.parEncontrado)
                {
                    this.Controls.Add(c);
                    c.Left = left;
                    c.Top = top;

                    left += Carta.WIDTH_CARTA + 5;
                    if (left > 200 + (Carta.WIDTH_CARTA + 5) * CARTAS_POR_LINHA - 1)
                    {
                        left = 200;
                        top += Carta.HEIGHT_CARTA + 5;
                    }
                }
            }
        }

        private void tratarRegrasEspeciais()
        {
            if (mesa.cartaViradaAtual.nomeCarta == "embaralhar")
            {
                player.SoundLocation = "./sound/embaralhar.wav";
                player.Play();

                mesa.embaralhar();
                this.desenharMesa();
                pontuacao += 200;
            }

            if (mesa.cartaViradaAtual.nomeCarta == "visualizar")
            {
                player.SoundLocation = "./sound/visualizar.wav";
                player.Play();

                foreach (Carta c in mesa.cartas)
                {
                    c.Enabled = false;
                    if (!c.parEncontrado)
                    {
                        if (!c.virada)
                        {
                            c.virar();
                        }
                    }
                }
                pontuacao += 150;
                this.tmrVisualizacao.Interval = 5000;
                this.tmrVisualizacao.Enabled = true;
            }

            if (mesa.cartaViradaAtual.nomeCarta == "sacanear")
            {
                player.SoundLocation = "./sound/sacanear.wav";
                player.Play();

                removerControles(true);
                mesa.incluirCartas();
                foreach (Carta c in mesa.cartas)
                {
                    if (c.nomeCarta == "sacanear")
                    {
                        c.remover();
                    }
                }
                mesa.embaralhar();
                this.desenharMesa();
                pontuacao -= 100;
            }

            this.lblPontuacao.Text = pontuacao.ToString();
        }

        public bool usuarioVenceu()
        {
            foreach (Carta c in mesa.cartas)
            {
                if (c.tipoCarta == "normal")
                {
                    if (!c.parEncontrado)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void tmrVirada_Tick(object sender, EventArgs e)
        {
            this.tmrVirada.Enabled = false;

            if (mesa.cartaViradaAtual.tipoCarta == "especial")
            {
                tratarRegrasEspeciais();

                mesa.cartaViradaAtual.remover();
                mesa.ultimaCartaVirada = null;
                mesa.cartaViradaAtual = null;
                Carta.mesa.form1.Enabled = true;
                return;
            }


            if (mesa.ultimaCartaVirada.nomeCarta == mesa.cartaViradaAtual.nomeCarta)
            {
                player.SoundLocation = "./sound/acerto.wav";
                player.Play();

                FormAcerto frmAcerto = new FormAcerto(this);
                frmAcerto.BackgroundImage = Image.FromFile(mesa.cartaViradaAtual.imagemInfo);
                frmAcerto.Show();

                mesa.ultimaCartaVirada.remover();
                mesa.cartaViradaAtual.remover();

                Label l = new Label();
                l.Name = "animalNaFloresta";
                l.Image = Image.FromFile(mesa.cartaViradaAtual.imagemFloresta);
                l.Width = Carta.WIDTH_CARTA;
                l.Height = Carta.HEIGHT_CARTA;
                l.Left = mesa.cartaViradaAtual.xFloresta;
                l.Top = mesa.cartaViradaAtual.yFloresta;
                l.BackColor = Color.Transparent;
                l.Visible = true;

                this.Controls.Add(l);

                pontuacao += 300;
            }
            else
            {
                player.SoundLocation = "./sound/erro.wav";
                player.Play();

                mesa.ultimaCartaVirada.virar();
                mesa.cartaViradaAtual.virar();
                pontuacao -= 25;
            }

            this.lblPontuacao.Text = pontuacao.ToString();

            Carta.mesa.form1.Enabled = true;
            mesa.ultimaCartaVirada = null;
            mesa.cartaViradaAtual = null;
        }



        private void tmrVisualizacao_Tick(object sender, EventArgs e)
        {
            this.tmrVisualizacao.Enabled = false;
            foreach (Carta c in mesa.cartas)
            {
                c.Enabled = true;
                if (!c.parEncontrado)
                {
                    if (c.virada)
                    {
                        c.virar();
                    }
                }
            }

        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formMenu.Focus();
            this.formMenu.player.SoundLocation = "./sound/menu.wav";
            this.formMenu.player.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;

            foreach (Carta c in mesa.cartas)
            {

                //c.Enabled = false;
                if (!c.parEncontrado)
                {
                    if (!c.virada)
                    {
                        c.virar();
                    }
                }
                pontuacao += 150;
            }
            this.tmrVisualizacao.Interval = 5000;
            this.tmrVisualizacao.Enabled = true;
            return;

            foreach (Carta c in mesa.cartas)
            {
                Label l = new Label();
                l.Image = Image.FromFile(c.imagemFloresta);
                l.Width = Carta.WIDTH_CARTA;
                l.Height = Carta.HEIGHT_CARTA;
                l.Left = c.xFloresta;
                l.Top = c.yFloresta;
                l.BackColor = Color.Transparent;
                l.Visible = true;
                this.Controls.Add(l);
            }

            return;
        }

    }
}