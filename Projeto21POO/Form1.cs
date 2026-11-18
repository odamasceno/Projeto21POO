using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto21POO
{
    public partial class Form1 : Form
    {
        private Jogo jogo;
        private bool jogoEncerrado = false;
        private Image imagemVersoCarta;

        public Form1()
        {
            InitializeComponent();
            jogo = new Jogo();

            try
            {
                imagemVersoCarta = Image.FromFile("Cartas\\deck_2\\back.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem do verso: " + ex.Message);
            }
        }

        public void IniciarPartida()
        {
            try
            {
                jogo.IniciaJogo();
                jogoEncerrado = false;
                ButtonComprar.Enabled = true;
                ButtonParar.Enabled = true;
                AtualizarMesa(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar partida: " + ex.Message);
            }
        }

        private void LimparPainel(FlowLayoutPanel painel)
        {
            foreach (Control ctrl in painel.Controls)
            {
                ctrl.Dispose();
            }
            painel.Controls.Clear();
        }

        public void AtualizarMesa(bool revelar_banca)
        {
            LimparPainel(flowLayoutPanelJogador);
            LimparPainel(flowLayoutPanelBanca);

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
                    pic.Image = imagemVersoCarta;
                }
                else
                {
                    pic.Image = jogo.GetBanca().GetMao()[i].GetImagem();
                }

                flowLayoutPanelBanca.Controls.Add(pic);
            }

            lblPontosJogador.Text = $"Pontuação Jogador: {jogo.GetJogador().GetPontuacao()}";

            if (revelar_banca)
            {
                lblPontosBanca.Text = $"Pontuação Banca: {jogo.GetBanca().GetPontuacao()}";
            }
            else if (jogo.GetBanca().GetMao().Count > 0)
            {
                Carta primeiraCarta = jogo.GetBanca().GetMao()[0];
                int valorVisivel = (primeiraCarta.GetNumero() == "A") ? 11 : primeiraCarta.GetValor();
                lblPontosBanca.Text = $"Pontuação Banca: {valorVisivel} + ?";
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
            ButtonComprar.Enabled = false;
            ButtonParar.Enabled = false;
            AtualizarMesa(true);

            //if (jogo is JogoComAposta jogoAposta)
            //{
            //    if(resultado == 1)
            //    {

            //    }
            //}
            if (resultado == 1)
            {
                MessageBox.Show("Parabéns! Você venceu a banca!", "Fim de Jogo");
            }
            else
            {
                MessageBox.Show("A banca venceu!", "Fim de Jogo");
            }
            if (jogo is JogoComAposta jogoAposta && jogoAposta.Faliu())
            {
                MessageBox.Show("Infelizmente você perdeu sua vida");
            }
        }

        private void CarregarVerso(string nomeArquivo)
        {
            try
            {
                if (imagemVersoCarta != null)
                {
                    imagemVersoCarta.Dispose();
                }
                imagemVersoCarta = Image.FromFile($"Cartas\\deck_2\\{nomeArquivo}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem do verso: " + ex.Message);
            }
        }

        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            jogo = new Jogo();
            CarregarVerso("back.png");
            panelAposta.Visible = false;
            TelaJogo();
            IniciarPartida();
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado) 
            {
                return; 
            }

            jogo.PedirCartaJogador();
            AtualizarMesa(false);

            int resultado = jogo.VerificarFimDeJogo(false);
            if (resultado != 0)
            {
                FinalizarPartida(resultado);
            }
        }

        private async void ButtonParar_Click(object sender, EventArgs e)
        {
            if (jogoEncerrado)
            {
                return;
            }

            ButtonComprar.Enabled = false;
            ButtonParar.Enabled = false;

            AtualizarMesa(true);
            await Task.Delay(800);

            int pontosJogador = jogo.GetJogador().GetPontuacao();

            while (jogo.GetBanca().DeveComprarCarta(pontosJogador))
            {
                jogo.JogarBanca();
                AtualizarMesa(true);
                await Task.Delay(800);
            }

            int resultado = jogo.VerificarFimDeJogo(true);
            FinalizarPartida(resultado);
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            if (jogo is JogoComAposta)
            {
                PrepararMomentoDeAposta();
            }
            else
            {
                IniciarPartida();
            }
        }

        private void BarArtisticoButton_Click(object sender, EventArgs e)
        {
            int idade = ChecagemDeIdade();
            if (idade != 0)
            {
                jogo = new JogoComAposta(idade);
                CarregarVerso("back-purple.png");
                panelAposta.Visible = true;
                TelaJogo();
                PrepararMomentoDeAposta();
            }
        }

        private int ChecagemDeIdade()
        {
            if(numIdade.Value < 18)
            {
                MessageBox.Show("Voce precisa ter 18 Anos ou mais para apostar!");
                return 0;
            }
            else
            {
                MessageBox.Show("Voce apostará seus anos de vida restantes!");
                return Math.Abs(Convert.ToInt32(numIdade.Value - numIdade.Maximum));
            }
        }

        private void PrepararMomentoDeAposta()
        {
            LimparPainel(flowLayoutPanelJogador);
            LimparPainel(flowLayoutPanelBanca);

            lblPontosJogador.Text = "Faça sua aposta para iniciar!";
            lblPontosBanca.Text = "";

            ButtonComprar.Enabled = false;
            ButtonParar.Enabled = false;

            ButtonApostar.Enabled = true;
            numValorAposta.Enabled = true;

            AtualizarInterfaceAposta();
        }

        private void ButtonApostar_Click(object sender, EventArgs e)
        {
            if (jogo is JogoComAposta jogoAposta)
            {
                try
                {
                    int valor = (int)numValorAposta.Value;

                    jogoAposta.Apostar(valor);

                    ButtonApostar.Enabled = false;
                    numValorAposta.Enabled = false;

                    AtualizarInterfaceAposta();
                    IniciarPartida();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aposta Inválida");
                }
            }
        }

        private void AtualizarInterfaceAposta()
        {
            if (jogo is JogoComAposta jogoAposta)
            {
                lblSaldo.Text = $"Saldo: {jogoAposta.GetValDisp()} anos";
                lblApostaAtual.Text = $"Aposta: {jogoAposta.GetAposta()} ano(s)";
            }
        }
    }
}