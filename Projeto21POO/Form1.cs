using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto21POO
{
    public partial class Form1 : Form
    {
        private Baralho baralho;
        private Jogador jogador;
        private Jogador banca;

        public Form1()
        {
            InitializeComponent();
        }

        public void IniciaJogo()
        {
            List<string> NumerosPossiveis = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            List<string> NaipesPossiveis = new List<string> { "Paus", "Ouros", "Copas", "Espadas" };

            baralho = new Baralho(NumerosPossiveis, NaipesPossiveis);

            baralho.ConstroiBaralho();
            baralho.Embaralha();

            jogador = new Jogador();
            banca = new Jogador();

            for (int i = 0; i < 2; i++)
            {
                jogador.ReceberCarta(baralho.RetiraCarta());
                banca.ReceberCarta(baralho.RetiraCarta());
            }
            AtualizarMesa();
        }

        public void AtualizarMesa()
        {

            flowLayoutPanelJogador.Controls.Clear();
            flowLayoutPanelBanca.Controls.Clear();

            foreach (Carta c in jogador.GetMao())
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = c.GetImagem();

                flowLayoutPanelJogador.Controls.Add(pic);
            }

            for (int i = 0; i < banca.GetMao().Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                if (i == 1 && banca.GetMao().Count == 2)
                {
                    pic.Image = Image.FromFile("Cartas\\deck_2\\back.png");
                }
                else
                {
                    pic.Image = banca.GetMao()[i].GetImagem();
                }

                flowLayoutPanelBanca.Controls.Add(pic);
            }


            this.Refresh();
        }

        public void TelaJogo()
        {
            panelMenu.Visible = false;

            panelJogo.Visible = true;
        }

        //tem que ver se o jogador perdeu
        public void ChecagemRegras() { }

        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            TelaJogo(); 
            IniciaJogo();
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            jogador.ReceberCarta(baralho.RetiraCarta());
            AtualizarMesa();
            //Verifica se perdeu aqui
        }


    }
}