using Projeto01_validacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace validaCPF
{
    class Cliente
    {
        private TCPF objeto_cpf;
        private string nome;
        private TEndereco objeto_endereco;
        private TData objeto_data;

        public string Nome { get => nome; set => nome = value; }
        public TCPF Objeto_cpf { get => objeto_cpf; set => objeto_cpf = value; }
        public TEndereco Objeto_endereco { get => objeto_endereco; set => objeto_endereco = value; }
        public TData Objeto_data { get => objeto_data; set => objeto_data = value; }

        public Cliente()
        {
            objeto_cpf = new TCPF();
            objeto_endereco = new TEndereco();
            objeto_data = new TData();
        }

        public string mostraData()
        {
            string x = objeto_data.MDataBar();
            return x;
        }
    }
}
