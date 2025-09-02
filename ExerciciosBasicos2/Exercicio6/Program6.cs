using System;
using System.Globalization;

namespace Exercicio6
{
    class Program6
    {
        static void Main (string[] args)
        {
            Console.WriteLine("*Intervalos de números*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais.");

            double valor;

            Console.WriteLine("Digite um valor inteiro: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valor >= 0.0 && valor <= 25.0)
            {
                Console.WriteLine("O valor está dentro do intervalo [0, 25].");
            }
            else if (valor >= 25.0 && valor <= 50.0)
            {
                Console.WriteLine("O valor está dentro do intervalo [25, 50].");
            }
            else if (valor >= 50.0 && valor <= 75.0)
            {
                Console.WriteLine("O valor está dentro do intervalo [50, 75].");
            }
            else if (valor >= 75.0 && valor <= 100.0)
            {
                Console.WriteLine("O valor está dentro do intervalo [75, 100].");
            }
            else
            {
                Console.WriteLine("O valor está fora do intervalo!");
            }

            //Outra forma de executar
            //if (valor < 0.0 || valor > 100.0)
            //{
            //    Console.WriteLine("O valor está fora do intervalo!");
            //}
            //else if (valor <= 25.0)
            //{
            //    Console.WriteLine("O valor está dentro do intervalo [0, 25].");
            //}
            //else if (valor <= 50.0)
            //{
            //    Console.WriteLine("O valor está dentro do intervalo (25, 50].");
            //}
            //else if (valor <= 75.0)
            //{
            //    Console.WriteLine("O valor está dentro do intervalo (50, 75].");
            //}
            //else
            //{
            //    Console.WriteLine("O valor está dentro do intervalo (75, 100].");
            //}

        }
    }
}