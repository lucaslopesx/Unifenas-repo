using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFuncionario
{
    class Departamento
    {
        int codDepartamento;
        string nomeDepartamento;

        public int CodDepartamento { get => codDepartamento; set => codDepartamento = value; }
        public string NomeDepartamento { get => nomeDepartamento; set => nomeDepartamento = value; }

        public void GravaDados(int cod, string nomeDep)
        {
            this.CodDepartamento = cod;
            this.NomeDepartamento = nomeDep;
        }

        public string MostraDados()
        {
            return $"Código do departamento: {CodDepartamento}\nNome do departamento: {NomeDepartamento}";
        }
    }
}
