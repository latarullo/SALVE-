using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace WindowsFormsApplication1
{
    class Mesa
    {
        Random r = new Random();
        public List<Carta> cartas;
        private List<Carta> aux;

        public int cartasViradas = 0;
        public Carta ultimaCartaVirada;
        public Carta cartaViradaAtual;
        public FormJogo form1;

        public Mesa(FormJogo form1)
        {
            this.form1 = form1;
            cartas = new List<Carta>();

            incluirCartas();
            embaralhar();
        }

        public void incluirCartas()
        {
            while (cartas.Count > 0)
            {
                cartas.RemoveAt(0);
            }

            XmlTextReader reader = new XmlTextReader("Dados.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "carta")
                    {
                        string tipoCarta = reader.GetAttribute("tipoCarta");
                        string nomeCarta = reader.GetAttribute("nomeCarta");
                        string imagemCarta = reader.GetAttribute("imagemCarta");
                        string imagemInfo = reader.GetAttribute("imagemInfo");
                        string imagemFloresta = reader.GetAttribute("imagemFloresta");

                        int xFloresta = int.Parse(reader.GetAttribute("xFloresta"));
                        int yFloresta = int.Parse(reader.GetAttribute("yFloresta"));

                        cartas.Add(new Carta(tipoCarta, nomeCarta, imagemCarta, imagemInfo, imagemFloresta, xFloresta, yFloresta, this));
                        if (tipoCarta == "normal")
                        {
                            cartas.Add(new Carta(tipoCarta, nomeCarta, imagemCarta, imagemInfo, imagemFloresta, xFloresta, yFloresta, this));
                        }
                    }
                }
            }

            reader.Close();
        }

        public void embaralhar()
        {
            int xIndice;
            aux = new List<Carta>();

            while (cartas.Count > 0)
            {
                xIndice = r.Next(cartas.Count);
                aux.Add(cartas[xIndice]);
                cartas.RemoveAt(xIndice);
            }

            cartas = aux;
            aux = null;
        }
    }
}