using System;

namespace ConsoleApp1.ExercicioTresListaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                    soma += i;
            }

            Console.WriteLine("A soma é: " + soma);

            Console.ReadKey();
        }
    }
}
