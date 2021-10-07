using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFuncionario
{
    class Funcionario
    {
        int idFuncionario;
        string nomeFuncionario;
        string dataNascimento;
        double salario;

        public Funcionario()
        {
        }

        public void CalculaSalario()
        {
            salario = salario * 3;
        }
        public void GravaDados(string nomeFuncionario, double salario, string dataNascimento)
        {
            this.nomeFuncionario = nomeFuncionario;
            this.salario = salario;
            this.dataNascimento = dataNascimento;
        }

        public string MostraDados()
        {
            string aux = $"IdFuncionario: {idFuncionario} \nNome do funcionario: {nomeFuncionario}\nSalario: {salario.ToString()} \nData de nascimento {dataNascimento}";
            return aux;
        }
    }
}
