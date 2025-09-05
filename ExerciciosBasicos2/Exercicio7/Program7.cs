using System;
using System.Globalization;

namespace Exercicio7 
{
    class Program7
    {
        static void Main (string[] args)
        {
            Console.WriteLine("*Intervalos de números*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais.");

            double coordenadax, coordenaday;

            Console.WriteLine("Insira dois valores. X e Y, respectivamente separados por um espaço: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            coordenadax = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            coordenaday = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if(coordenadax == 0.0  && coordenaday == 0.0)
            {
                Console.WriteLine("As coordenadas se encontram na origem");
            }
            else if (coordenadax == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (coordenaday == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (coordenadax > 0.0 && coordenaday > 0.0)
            {
                Console.WriteLine("As coordenadas se encontram no Quadrante 1!");
            }
            else if (coordenadax < 0.0 && coordenaday > 0.0)
            {
                Console.WriteLine("As coordenadas se encontram no Quadrante 2!");
            }
            else if (coordenadax > 0.0 && coordenaday < 0.0)
            {
                Console.WriteLine("As coordenadas se encontram no Quadrante 4!");
            }
            else
            {
                Console.WriteLine("As coordenadas se encontram no Quadrante 3!");
            }

        }
    }
}