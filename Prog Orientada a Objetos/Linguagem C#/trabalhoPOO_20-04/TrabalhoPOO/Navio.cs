using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPOO
{
    class Navio : Veiculo
    {
        public Navio(string codigo, float compT) : base(codigo)
        {
            this.compTotal = compT;
        }

        private string tipoNavio;
        private float compTotal;
        private float cargaMax;

        public string TipoNavio { get => tipoNavio; set => tipoNavio = value; }
        public float CompTotal { get => compTotal; set => compTotal = value; }
        public float CargaMax { get => cargaMax; set => cargaMax = value; }

        public string MostraNavio()
        {
            return "Dados do navio\n" + MostraVeiculo() + "\nTipo do navio: " + tipoNavio + "\nComprimento total: " + compTotal + "\nCarga Máxima: " + CargaMax;
        }
    }
}
