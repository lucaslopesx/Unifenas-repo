using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ProjetoAgendaBD
{
    class DadosAgenda
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        private Connection connection = new Connection();

        public void Insert()
        {
            string sql = $"Insert into DadosAgenda (Nome, Telefone, Cidade) values ('{Nome}', '{Telefone}', '{Cidade}')";
            connection.Execute(sql);
        }
        public void Update()
        {
           string sql = $"update DadosAgenda set Telefone = '{Telefone}', Cidade = '{Cidade}' where Codigo = {Codigo}";
            connection.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"delete from DadosAgenda where Codigo = {Codigo}";
            connection.Execute(sql);
        }
        public void Consult()
        {
            string sql = $"Select * from DadosAgenda where Codigo = {Codigo}";
            //string sql = $"Select * from DadosAgenda where Nome LIKE '{Nome}%'";
            connection.Consult(sql);
            if (connection.dr.Read())
            {
                Telefone = connection.dr["Telefone"].ToString();
                Cidade= connection.dr["Cidade"].ToString();
            }
            connection.Disconnect();
        }
        public DataSet List()
        {
            string sql = "Select * from DadosAgenda";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListByName()
        {
            string sql = $"Select * from DadosAgenda where Nome LIKE '{Nome}%'";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;

        }
        public DataSet ListByCity()
        {
            string sql = $"Select * from DadosAgenda where Cidade LIKE '{Cidade}%'";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;
        }

    }
}
