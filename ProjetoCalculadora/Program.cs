using System;

namespace ProjetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;

            Console.Write("Digite o multiplicando: ");
            multiplicando = Convert.ToInt32(Console.ReadLine());

            for (int multiplicador = 0; multiplicador <= 10; multiplicador ++)
            {
                Console.WriteLine(string.Format("\t\t\t{0}\t*\t{1}\t=\t{2}", multiplicando, multiplicador, multiplicando * multiplicador));
            }
            Console.WriteLine("Aperte alguma tecla!");
            Console.ReadKey();


        }
    }
}
