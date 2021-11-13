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
        public byte[] Foto { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        private Connection connection = new Connection();

        public void Insert()
        {
            string sql = $"Insert into DadosAgenda (Nome, Telefone, Cidade, Foto) values ('{Nome}', '{Telefone}', '{Cidade}', @image)";
            connection.Execute(sql, Foto);
        }
        public void Update()
        {
           string sql = $"update DadosAgenda set Telefone = '{Telefone}', Cidade = '{Cidade}', Foto = @image where Codigo = {Codigo}";
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
            connection.Consult(sql);
            if (connection.dr.Read())
            {
                Telefone = connection.dr["Telefone"].ToString();
                Cidade = connection.dr["Cidade"].ToString();
            }
            connection.Disconnect();
        }

        public void ConsultData()
        {
            string sql = $"Select * from DadosAgenda where Codigo = {Codigo}";
            connection.Consult(sql);
            if (connection.dr.Read())
            {
                Foto = (byte[])connection.dr["Foto"];
            }
            else
            {
                Foto = null;
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
