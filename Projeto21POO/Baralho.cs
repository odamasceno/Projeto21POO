using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto21POO
{
    internal class Baralho
    {
        private List<string> NumerosPossiveis;
        private List<string> NaipesPossiveis;
        private List<Carta> Cartas;
        private Random rnd = new Random();

        public Baralho(List<string> NumerosPossiveis, List<string> NaipesPossiveis)
        {
            SetNumerosPossiveis(NumerosPossiveis);
            SetNaipesPossiveis(NaipesPossiveis);
            SetCartas(new List<Carta>());
        }

        public List<string> GetNumerosPossiveis()
        {
            return NumerosPossiveis;
        }

        public void SetNumerosPossiveis(List<string> NumerosPossiveis)
        {
            this.NumerosPossiveis = NumerosPossiveis;
        }

        public List<string> GetNaipesPossiveis()
        {
            return NaipesPossiveis;
        }

        public void SetNaipesPossiveis(List<string> NaipesPossiveis)
        {
            this.NaipesPossiveis = NaipesPossiveis;
        }

        public List<Carta> GetCartas()
        {
            return Cartas;
        }

        public void SetCartas(List<Carta> cartas)
        {
            this.Cartas = cartas;
        }

        public void ConstroiBaralho()
        {
            Cartas.Clear();
            foreach (var numero in NumerosPossiveis)
            {
                foreach (var naipe in NaipesPossiveis)
                {
                    Carta nova = new Carta(naipe, numero);
                    Cartas.Add(nova);
                }
            }
        }

        public void Embaralha()
        {
            Cartas = Cartas.OrderBy(c => rnd.Next()).ToList();
        }

        public Carta RetiraCarta()
        {
            if (Cartas.Count == 0)
            {
                throw new Exception("O baralho ficou sem cartas!");
            }

            Carta carta = Cartas[0];
            Cartas.RemoveAt(0);

            return carta;
        }
    }
}