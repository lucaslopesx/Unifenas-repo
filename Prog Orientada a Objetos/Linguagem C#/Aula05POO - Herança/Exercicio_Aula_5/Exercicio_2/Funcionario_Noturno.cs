using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    class Funcionario_Noturno : Funcionario
    {
        private string hora_entrada;
        private string hora_saida;

        public string Hora_entrada { get => hora_entrada; set => hora_entrada = value; }
        public string Hora_saida { get => hora_saida; set => hora_saida = value; }

        public string MostraFuncionarioNoturno()
        {
            string aux = MostraFuncionario() + "\nHorario de entrada : " + Hora_entrada + "\nHorario de saida : " + hora_saida;
            return aux; 
        }
    }
}
