using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa p = new Pessoa();
                Aluno a = null;
                a = (Aluno)p;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
