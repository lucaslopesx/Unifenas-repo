using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFuncionario
{
    class Funcionario
    {
        int idFuncionario = 0;
        string nomeFuncionario;
        string dataNascimento;
        double salario;
        int codDepartamento;

        public Funcionario()
        {
        }

        public double Salario { get => salario; set => salario = value; }
        public int CodDepartamento { get => codDepartamento; set => codDepartamento = value; }

        public void CalculaSalario()
        {
            Salario = Salario * 3;
        }
        public void GravaDados(string nomeFuncionario, double salario, string dataNascimento)
        {
            this.nomeFuncionario = nomeFuncionario;
            this.Salario = salario;
            this.dataNascimento = dataNascimento;
        }

        public string MostraDados()
        {
            string aux = $"IdFuncionario: {idFuncionario} \nNome do funcionario: {nomeFuncionario}\nSalario: {Salario.ToString()} \nData de nascimento {dataNascimento}";
            return aux;
        }
    }
}
