namespace validaCPF
{
    class TEndereco
    {
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;

        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }

        public string MostraEndereco()
        {
            string msg = "";

            msg += "\nRua: " + rua + ", " + numero + "\nBairro: " + bairro;
            msg += "\nCidade: " + cidade + ", " + estado;

            return msg;
        }
    }
}
