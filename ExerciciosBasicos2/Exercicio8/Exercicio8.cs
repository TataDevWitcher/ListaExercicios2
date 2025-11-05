using System;
using System.Globalization;

namespace Exercicio8
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Imposto de renda - Lisarb*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|       Renda                 Imposto de Renda  |");
            Console.WriteLine("|de 0.00 a R$ 2000.00              Isento       |");
            Console.WriteLine("|de R$ 2000.01 a R$ 3000.00          8%         |");
            Console.WriteLine("|de R$ 3000.01 a R$ 4500.00         18%         |");
            Console.WriteLine("|acima de R$ 4500.00                28%         |");
            Console.WriteLine("-------------------------------------------------");


            double salario, calculoImposto;
            Console.WriteLine("");
            Console.WriteLine("Insira seu salário para o cálculo do imposto: ");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 2000.00)
            {
                calculoImposto = 0.00;
            }
            else if (salario <= 3000.00)
            {
                calculoImposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                calculoImposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                calculoImposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.0 * 0.08;
            }

            if (calculoImposto == 0.00)
            {
                Console.WriteLine("Imposto isento!");
            }
            else
            {
                Console.WriteLine($"R$ {calculoImposto:F2}");
            }

        }
    }
}