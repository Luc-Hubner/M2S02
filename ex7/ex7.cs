using System;

namespace ex7
{
    class ex7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            string input = Console.ReadLine();
            int numero = int.Parse(input);

            Console.WriteLine("numero invertido: " + reverterNumero(numero)); 

        }

        static int reverterNumero(int n)
        {
            int reverse = 0;
            while (n != 0)
            {
                int rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return reverse;
        }
    }
}
