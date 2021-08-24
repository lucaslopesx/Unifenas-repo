using System;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x;
                int y;
                Console.Write("x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y: ");
                y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("Resultado: ", z.ToString());
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Erro Inesperado");
            }
            finally
            {
                Console.WriteLine("Obrigado por utilizar nossos serviços!!!!");
            }
            Console.ReadKey();
        }
    }
}
