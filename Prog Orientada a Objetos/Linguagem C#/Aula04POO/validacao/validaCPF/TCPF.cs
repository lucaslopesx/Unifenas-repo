﻿using System;
using System.Collections.Generic;
using System.Text;

namespace validaCPF
{
    class TCPF
    {
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
        }

        public bool ValidaCpf(string cpf)
        {
            this.cpf = cpf;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public string MostraCPF()
        {
            string msg = "";
            long auxCPF = long.Parse(cpf);
            string CPFFormatado = String.Format(@"CPF: {0:000\.000\.000\-00}", auxCPF);
            msg = CPFFormatado;
            return msg;
        }
    }
}
