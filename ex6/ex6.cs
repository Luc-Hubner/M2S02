using System;

namespace ex6
{
    class ex6
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite o primeiro lado do triangulo :");
            string input = Console.ReadLine();
            int ladoT1 = int.Parse(input);

            Console.WriteLine("Digite o segundo lado do triangulo :");
            input = Console.ReadLine();
            int ladoT2 = int.Parse(input);

            Console.WriteLine("Digite o terceiro lado do triangulo :");
            input = Console.ReadLine();
            int ladoT3 = int.Parse(input);


            if (trianguloPossivel(ladoT1, ladoT2, ladoT3))
            {
                if (ladoT1 == ladoT2 && ladoT2 == ladoT3)
                {
                    Console.WriteLine("Este triangulo é: Equilátero");
                }
                else if (ladoT1 == ladoT2 || ladoT2 == ladoT3 || ladoT1 == ladoT3)
                {
                    Console.WriteLine("Este triangulo é: Isósceles");
                }
                else if (ladoT1 != ladoT2 && ladoT2 != ladoT3 && ladoT1 != ladoT3)
                {
                    Console.WriteLine("Este triangulo é: Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não é possivel formar um triangulo com estes numeros");
            }
        }
        static bool trianguloPossivel(int lado1, int lado2, int lado3)
        {

            if (lado1 + lado2 > lado3 || lado1 + lado3 > lado2 || lado2 + lado3 > lado1)
            {
                return true;
            }
            return false;
        }
    }
}
