using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01_validacao
{
    class TData
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia { get => dia; set => dia = (value>0 && value<32?value:0); }
        public int Mes { get => mes; set => mes = (value > 0 && value < 13 ? value : 0; }
        public int Ano { get => ano; set => ano = value; }


        public string MDataBar()
        {
            string msg;

            msg = dia < 10 ? "0" + dia.ToString() : Dia.ToString();
            msg += mes < 10 ? "/0" + mes.ToString() : "/" + mes.ToString();
            msg += "/" + ano.ToString();
                 
            return msg;
        }
        public string MDataExt()
        {
            string msg = "";
            string[] vetMes = { "Janeiro", "Fevereiro", "Março", 
                "Abril", "Maio", "Junho", "Julho", "Agosto", 
                "Outubro", "Novembro", "Dezembro" };
            msg = dia + " de " + vetMes[mes] + " de " + ano;
            return msg;
        }
    }
}
