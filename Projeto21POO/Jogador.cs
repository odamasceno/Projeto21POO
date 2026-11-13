using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto21POO
{
    internal class Jogador
    {
        private List<Carta> Mao;
        private int Pontuacao;

        public Jogador()
        {
            SetMao(new List<Carta>());
            SetPontuacao(0);
        }

        public List<Carta> GetMao()
        {
            return Mao;
        }

        public void SetMao(List<Carta> Mao)
        {
            this.Mao = Mao;
        }

        public int GetPontuacao()
        {
            return Pontuacao;
        }

        public void SetPontuacao(int Pontuacao)
        {
            if(Pontuacao >= 0)
            {
                this.Pontuacao = Pontuacao;
            }
            else
            {
                throw new Exception("Pontuação invalida");
            }
        }


        public void ReceberCarta(Carta novaCarta)
        {
            if (novaCarta != null)
            {
                GetMao().Add(novaCarta);
                DeterminaPontuacao();
            }
        }

        public void DeterminaPontuacao()
        {
            int somaTemp = 0;
            int quantidadeAses = 0;

            foreach (Carta c in GetMao())
            {
                if (c.GetNumero() == "A")
                {
                    quantidadeAses++;
                    somaTemp += 11;
                }
                else
                {
                    somaTemp += c.GetValor();
                }
            }

            while (somaTemp > 21 && quantidadeAses > 0)
            {
                somaTemp -= 10;
                quantidadeAses--;
            }

            SetPontuacao(somaTemp);
        }

    }
}
