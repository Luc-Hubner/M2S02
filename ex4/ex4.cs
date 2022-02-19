using System;

namespace ex4
{
    class ex4
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Digite um numero:");
                string input = Console.ReadLine();
                numeros[i] = int.Parse(input);
            }

            int menorNumero = menorN(numeros);
            Console.WriteLine("O menor numero digitado foi: " + menorNumero);

        }

        static int menorN(int[] arr)
        {
            int primeiroElem = arr[0];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < primeiroElem)
                    primeiroElem = arr[i];

            return primeiroElem;
        }
    }
}
