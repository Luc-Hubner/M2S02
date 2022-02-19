using System;

namespace ex2
{
    class ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a temperatura em graus Celsius? ");
            string input = Console.ReadLine();
            float grausC = float.Parse(input);

            float grausF = (grausC * 9 / 5) + 32;
            Console.WriteLine("são: " + grausF + " fahrenheit");
        }
    }
}
