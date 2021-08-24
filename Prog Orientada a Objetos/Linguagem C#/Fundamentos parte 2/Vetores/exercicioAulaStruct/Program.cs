using System;

namespace exercicioAulaStruct
{
    class Program
    {

        struct Aluno
        {
            public string matricula, nome;
            public float[] nota;
        }
        
        static void Gravar(ref Aluno a)
        {
            int j = 1;
            Console.Write("Digite o nome do aluno: ");
            a.nome = Console.ReadLine();

            Console.Write("Digite a matricula do aluno: ");
            a.matricula = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite a " + j + " nota: ");
                a.nota[i] = float.Parse(Console.ReadLine());
                j++;
            }
        }

        static void Mostrar(Aluno a)
        {
            Console.Clear();
            int j = 1;
            Console.WriteLine("Nome: " + a.nome);
            Console.WriteLine("Matricula: " + a.matricula);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nota" + j + ": " + a.nota[i]);
            }
        }
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno(); 
            a1.nota = new float[4];
            Console.WriteLine("");
            Gravar(ref a1);
            Mostrar(a1);

        }
    }
}
