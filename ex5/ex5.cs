using System;

namespace ex5
{
    class ex5
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero:");
                string input = Console.ReadLine();
                numeros[i] = int.Parse(input);
            }

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("O array em ordem decresente: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
