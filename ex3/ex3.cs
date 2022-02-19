using System;

namespace ex3
{
    class ex3
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero:");
                string input = Console.ReadLine();
                numeros[i] = int.Parse(input);
            }

            int maiorNumero = maiorN(numeros);
            Console.WriteLine("O maior numero digitado foi: "+ maiorNumero);

        }

        static int maiorN(int[] arr)
        {
            int primeiroElem = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > primeiroElem)
                    primeiroElem = arr[i];

            return primeiroElem;
        }
    }
}
