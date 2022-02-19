using System;

namespace ex10
{
    class ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um salario: ");
            string input = Console.ReadLine();
            double salario = double.Parse(input);

            double percentualAumento;

            switch (salario)
            {
                case >= 1500:
                    percentualAumento = 0.05;
                    break;

                case >= 700:
                    percentualAumento = 0.10;
                    break;

                case >= 280:
                    percentualAumento = 0.15;
                    break;

                default://case < 280:
                    percentualAumento = 0.20;
                    break;
            }

            double salarioNovo = salario + (salario * percentualAumento);
            double aumento = salarioNovo - salario;
            

            Console.WriteLine("Salario anterior: " + salario);
            Console.WriteLine("Porcentagem do aumento: " + percentualAumento);
            Console.WriteLine("Aumento: " + aumento);
            Console.WriteLine("Novo Salario: " + salarioNovo);
        }
    }
}
