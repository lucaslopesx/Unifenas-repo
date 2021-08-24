using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_escola
{
    class Funcionario:Pessoa
    {
        string cargo;
        string dataNascimento;

        public string Cargo { get => cargo; set => cargo = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public string MostraFunc()
        {
            string msg;
            return msg = MostraPessoa() + "\nCargo: " + Cargo + "\nData Nascimento: " + DataNascimento;
        }
    }
}
