using System;
using System.Collections.Generic;
using System.Text;

namespace projetoEstoque
{
    class Estoque
    {
        private string nomeProd;
        private int quantidade;
        private string nomeLocalEstoque;

        public Estoque(string nomeLocalEstoque)
        {
            this.nomeLocalEstoque = nomeLocalEstoque;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string NomeProd { get => nomeProd; set => nomeProd = value; }

        public string MostraEstoque()
        {
            string aux = "";
            aux += "Local: " + nomeLocalEstoque + "\n Nome produto: " + nomeProd + "\n Quantidade: " + quantidade;
            return aux;
        }
    }
}
