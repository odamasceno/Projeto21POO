using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto21POO
{
    public partial class Form1 : Form
    {
        private Jogo jogo;
        private bool jogoEncerrado = false;

        public Form1()
        {
            InitializeComponent();
            jogo = new Jogo();
        }

        public void IniciarPartida()
        {
            jogo.IniciaJogo();
            jogoEncerrado = false;
            AtualizarMesa(false);
        }

        public void AtualizarMesa(bool revelar_banca)
        {

            flowLayoutPanelJogador.Controls.Clear();
            flowLayoutPanelBanca.Controls.Clear();

            foreach (Carta c in jogo.GetJogador().GetMao())
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = c.GetImagem();

                flowLayoutPanelJogador.Controls.Add(pic);
            }

            for (int i = 0; i < jogo.GetBanca().GetMao().Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(100, 140);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                if (i == 1 && !revelar_banca && jogo.GetBanca().GetMao().Count == 2)
                {
                    pic.Image = Image.FromFile("deck_2\\back.png");
                }
                else
                {
                    pic.Image = jogo.GetBanca().GetMao()[i].GetImagem();
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

        private void FinalizarPartida(int resultado)
        {
            jogoEncerrado = true;
            AtualizarMesa(true);

            if (resultado == 1)
            {
                MessageBox.Show("Parabéns! Você venceu a banca!", "Fim de Jogo");
            }
            else
            {
                MessageBox.Show("A banca venceu!", "Fim de Jogo");
            }
        }

        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            TelaJogo(); 
            IniciarPartida();
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado) return;

            jogo.PedirCartaJogador();
            AtualizarMesa(false);

            int resultado = jogo.VerificarFimDeJogo(false);
            if (resultado != 0)
            {
                FinalizarPartida(resultado);
            }
        }

        private void ButtonParar_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado) return;

            jogo.JogarBanca();

            int resultado = jogo.VerificarFimDeJogo(true);
            FinalizarPartida(resultado);
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            IniciarPartida();
        }
    }
}