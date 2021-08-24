using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPOO
{
    class Veiculo
    {
        private string marca;
        private string codigo;
        private string cor;

        public Veiculo(string codigo)
        {
            this.Codigo = codigo;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Cor { get => cor; set => cor = value; }
        protected string Codigo { get => codigo; set => codigo = value; }

        public string MostraVeiculo()
        {
            
            return "Marca do veículo: " + Marca + "\nCor: " + Cor + "\nCódigo do veículo: " + Codigo;
        }
    }
}
