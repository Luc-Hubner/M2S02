using System;

namespace M2S02
{
    class ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho do raio do circulo? ");
            string input = Console.ReadLine();
            float raio = float.Parse(input);

            double result = raio * 3.14;
            Console.WriteLine("a area do circulo é: " + result);
        }
    }
}
