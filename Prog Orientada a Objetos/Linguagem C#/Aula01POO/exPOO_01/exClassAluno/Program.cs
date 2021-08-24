using System;

namespace exClassAluno
{

    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] nota;
        public Aluno()
        {
            nota = new double[4];
        }
        public void GravaAluno()
        {
            
            Console.WriteLine("=======GRAVANDO ALUNO=======");
            Console.Write("Digite o numero da matricula do aluno: ");
            matricula = Console.ReadLine();
            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a " + (i+1) + "a nota do aluno: ");
                nota[i] = double.Parse(Console.ReadLine());
            }
        }
        public void MostraAluno()
        {
            Console.WriteLine("=======DADOS DO ALUNO=======");
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("--NOTAS--");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i+1) + "a: "+ nota[i].ToString("0.00"));
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.WriteLine("Gravar aluno!!!");
            Console.WriteLine("pressione qualquer tecla para continuar");
            Console.ReadKey();
            a1.GravaAluno();

            Console.WriteLine("Mostrar Aluno!!!");
            Console.WriteLine("pressione qualquer tecla para continuar");
            Console.ReadKey();
            a1.MostraAluno();
        }
    }
}
