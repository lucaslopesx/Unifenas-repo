namespace Questao1
{
    class Vacina
    {
        string nome;
        string nome_vacina;
        bool dose1;
        bool dose2;
        bool dose3;

        public string Nome { get => nome; set => nome = value; }
        public string Nome_vacina { get => nome_vacina; set => nome_vacina = value; }
        public bool Dose1 { get => dose1; set => dose1 = value; }
        public bool Dose2 { get => dose2; set => dose2 = value; }
        public bool Dose3 { get => dose3; set => dose3 = value; }
    }
}
