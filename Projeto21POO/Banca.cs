using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto21POO
{
    internal class Banca : Jogador
    {
        public bool DeveComprarCarta(int pontuacaoJogador)
        {
            return ((GetPontuacao() < pontuacaoJogador) && (GetPontuacao() < 21));
        }
    }
}
