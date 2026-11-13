using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto21POO
{
    internal class Carta
    {
        private string Naipe;
        private string Numero;
        private int Valor;
        private Image Imagem;

        public Carta(string naipe, string numero)
        {
            SetNaipe(naipe);
            SetNumero(numero);

            switch (numero)
            {
                case "A":
                    SetValor(1);
                    break;
                case "J":
                case "Q":
                case "K":
                    SetValor(10);
                    break;
                default:
                    SetValor(Convert.ToInt32(numero));
                    break;
            }

            CarregarImagem();
        }

        public string GetNaipe()
        {
            return Naipe;
        }

        public void SetNaipe(string Naipe)
        {
            List<string> possiveis = new List<string> { "Paus", "Ouros", "Copas", "Espadas" };
            if (possiveis.Contains(Naipe))
            {
                this.Naipe = Naipe;
            }
            else
            {
                throw new Exception("Naipe Invalido");
            }
        }

        public string GetNumero()
        {
            return Numero;
        }

        public void SetNumero(string Numero)
        {
            List<string> possiveis = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            if (possiveis.Contains(Numero))
            {
                this.Numero = Numero;
            }
            else
            {
                throw new Exception("Numero Invalido");
            }
        }

        public int GetValor()
        {
            return Valor;
        }

        public void SetValor(int Valor)
        {
            if ((Valor >= 1) && (Valor <= 11))
            {
                this.Valor = Valor;
            }
            else
            {
                throw new Exception("Valor Invalido");
            }
        }

        public Image GetImagem()
        {
            return Imagem;
        }

        public void SetImagem(Image Imagem)
        {
            this.Imagem = Imagem;
        }

        private void CarregarImagem()
        {
            string nomeArquivo = $"{this.Naipe}_{this.Numero}.png";
            try
            {
                string caminho = $"Cartas\\deck_2\\{nomeArquivo}";
                this.Imagem = Image.FromFile(caminho);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
                throw;
            }

        }
    }
}