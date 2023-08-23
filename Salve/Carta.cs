using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Carta : System.Windows.Forms.Label
    {
        private static Image imgVerso = Image.FromFile(Carta.PATH_VERSO_CARTA);
        public static Mesa mesa;

        public const int WIDTH_CARTA = 90;
        public const int HEIGHT_CARTA = 75;
        public const string PATH_VERSO_CARTA = "./img/cartas/caixa.png";

        private Image imgCarta;
        private Image imgFloresta;

        public bool virada = false;
        public bool parEncontrado = false;

        public string imagemCarta;
        public string imagemInfo;
        public string imagemFloresta;

        public string nomeCarta;
        public string tipoCarta;

        public int xFloresta;
        public int yFloresta;

        public Carta(string tipoCarta, string nomeCarta, string imagemCarta, string imagemInfo, string imagemFloresta, int xFloresta, int yFloresta, Mesa m)
        {
            this.tipoCarta = tipoCarta;
            this.nomeCarta = nomeCarta;
            this.imagemCarta = imagemCarta;
            this.imagemInfo = imagemInfo;
            this.imagemFloresta = imagemFloresta;
            this.xFloresta = xFloresta;
            this.yFloresta = yFloresta;
            Carta.mesa = m;

            this.imgCarta = Image.FromFile(imagemCarta);
            this.imgFloresta = Image.FromFile(imagemFloresta);

            this.Image = Carta.imgVerso;
            this.Width = Carta.WIDTH_CARTA;
            this.Height = Carta.HEIGHT_CARTA;
            this.BackColor = Color.Transparent;
            parEncontrado = false;
            this.Visible = true;

            this.Click += new EventHandler(Carta_Click);
        }

        public void remover()
        {
            this.parEncontrado = true;
            this.Visible = false;
        }

        public void virar()
        {
            if (!this.parEncontrado)
            {
                if (this.virada)
                {
                    this.Image = Carta.imgVerso;
                }
                else
                {
                    this.Image = imgCarta;
                }
                this.virada = !this.virada;
            }
        }

        private void Carta_Click(object sender, System.EventArgs e)
        {
            Carta c = (Carta)sender;

            if (c.tipoCarta == "especial")
            {
                mesa.form1.player.Stop();
                mesa.form1.player.SoundLocation = "./sound/virada.wav";
                mesa.form1.player.Play();
                c.virar();
                if (Carta.mesa.ultimaCartaVirada != null)
                {
                    Carta.mesa.ultimaCartaVirada.virar();
                }
                Carta.mesa.cartaViradaAtual = c;
                Carta.mesa.form1.Enabled = false;
                Carta.mesa.form1.tmrVirada.Enabled = true;
                return;
            }

            if (Carta.mesa.ultimaCartaVirada != c)
            {
                mesa.form1.player.Stop();
                mesa.form1.player.SoundLocation = "./sound/virada.wav";
                mesa.form1.player.Play();
                c.virar();
                Carta.mesa.cartaViradaAtual = c;

                if (Carta.mesa.ultimaCartaVirada == null)
                {
                    Carta.mesa.ultimaCartaVirada = Carta.mesa.cartaViradaAtual;
                }
                else
                {
                    Carta.mesa.form1.Enabled = false;
                    Carta.mesa.form1.tmrVirada.Enabled = true;
                }

            }
        }
    }
}