using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPOO
{
    class Automovel : Veiculo
    {
        public Automovel(string codigo, string tipoV) : base(codigo)
        {
            this.tipoVeiculo = tipoV;
        }

        string tipoVeiculo;
        int qntdPortas;
        string tipoComb;

        
        public int QntdPortas { get => qntdPortas; set => qntdPortas = value; }
        public string TipoComb { get => tipoComb; set => tipoComb = value; }
        public string TipoVeiculo { get => tipoVeiculo; set => tipoVeiculo = value; }

        public string MostraAutomovel()
        {
            return "Dados do automóvel\n" + MostraVeiculo() + "\nTipo do Automóvel: " + tipoVeiculo + "\nQuantidade de portas: " + QntdPortas + "\nTipo de Combustível: " + TipoComb;
        }
    }
}
