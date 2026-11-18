using System;

namespace Projeto21POO
{
    internal class JogoComAposta : Jogo
    {
        private int ValDisp;
        private int Aposta;

        public JogoComAposta(int saldoInicial = 100)
        {
            SetValDisp(saldoInicial);
            this.Aposta = 0;
        }

        public int GetValDisp()
        {
            return ValDisp;
        }

        public void SetValDisp(int val)
        {
            if (val < 0)
            {
                throw new Exception("Saldo disponível não pode ser negativo.");
            }
            ValDisp = val;
        }

        public int GetAposta()
        {
            return Aposta;
        }

        public void SetAposta(int aposta)
        {
            if (aposta <= 0)
            {
                throw new Exception("A aposta deve ser maior que zero!");
            }
            if (aposta > GetValDisp())
            {
                throw new Exception("Saldo insuficiente para essa aposta!");
            }
            this.Aposta = aposta;
        }

        public void Apostar(int valor)
        {
            SetAposta(valor);
            SetValDisp(GetValDisp() - valor);
        }

        public void ReceberPremio()
        {
            SetValDisp(GetValDisp() + (GetAposta() * 2));
            this.Aposta = 0;
        }

        public void PerderAposta()
        {
            this.Aposta = 0;
        }

        public bool Faliu()
        {
            return GetValDisp() <= 0 && GetAposta() == 0;
        }

        public override int VerificarFimDeJogo(bool jogadorParou)
        {
            int resultado = base.VerificarFimDeJogo(jogadorParou);

            if (resultado == 1)
            {
                ReceberPremio();
            }
            else if (resultado == 2)
            {
                PerderAposta();
            }

            return resultado;
        }
    }
}