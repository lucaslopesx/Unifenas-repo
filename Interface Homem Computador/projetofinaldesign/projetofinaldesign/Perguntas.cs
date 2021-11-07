using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace projetofinaldesign
{
    class Perguntas
    {
        Connection connection = new Connection();

        public string Categoria { get; set; }
        public string NomeJogador { get; set; }
        public int Astronomia { get; set; }
        public int Botanica { get; set; }
        public int Fisica { get; set; }
        public int Geografia { get; set; }
        public int Quimica { get; set; }
        public int Zoologia { get; set; }
        public int IdPergunta { get; set; }
        public string PerguntaA { get; set; }
        public string PerguntaB { get; set; }
        public string PerguntaC { get; set; }
        public string PerguntaD { get; set; }
        public int Resultado { get; set; }

        public void Consult()
        {
            string sql = $"Select * from {Categoria} where idPergunta = {IdPergunta}";

            connection.Consult(sql);
            if (connection.dr.Read())
            {
                PerguntaA = connection.dr["perguntaA"].ToString();
                PerguntaB = connection.dr["perguntaB"].ToString();
                PerguntaC = connection.dr["perguntaC"].ToString();
                PerguntaD = connection.dr["perguntaD"].ToString();
                Resultado = int.Parse(connection.dr["resultado"].ToString());
                NomeJogador = connection.dr["nomeJogador"].ToString();
            }
            connection.Disconnect();
        }
        public DataSet List()
        {
            string sql = $"Select * from {Categoria}";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListBy()
        {
            string sql = "";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;
        }
    }
}
