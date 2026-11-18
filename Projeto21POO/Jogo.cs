using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto21POO
{
    internal class Jogo
    {
        private Baralho baralho;
        private Jogador jogador;
        private Banca banca;

        public void IniciaJogo()
        {
            List<string> NumerosPossiveis = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            List<string> NaipesPossiveis = new List<string> { "Paus", "Ouros", "Copas", "Espadas" };

            baralho = new Baralho(NumerosPossiveis, NaipesPossiveis);

            baralho.ConstroiBaralho();
            baralho.Embaralha();

            jogador = new Jogador();
            banca = new Banca();

            for (int i = 0; i < 2; i++)
            {
                jogador.ReceberCarta(baralho.RetiraCarta());
                banca.ReceberCarta(baralho.RetiraCarta());
            }
        }

        public Jogador GetJogador() => jogador;
        public Banca GetBanca() => banca;
        public Baralho GetBaralho() => baralho;

        public Carta PedirCartaJogador()
        {
            Carta nova = baralho.RetiraCarta();
            jogador.ReceberCarta(nova);
            return nova;
        }

        public Carta JogarBanca()
        {
            Carta nova = baralho.RetiraCarta();
            banca.ReceberCarta(nova);
            return nova;
        }

        public virtual int VerificarFimDeJogo(bool jogadorParou)
        {
            if (jogador.GetPontuacao() > 21)
            {
                return 2;
            }

            if (jogadorParou)
            {
                if (banca.GetPontuacao() > 21)
                {
                    return 1;
                }

                if (banca.GetPontuacao() >= jogador.GetPontuacao())
                {
                    return 2; 
                }
                else
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
