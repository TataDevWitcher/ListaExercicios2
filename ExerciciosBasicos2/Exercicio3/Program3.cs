using System;
using System.Globalization;

namespace Exercicio3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Números inteiros - Múltiplos ou não?*");

            int valor1, valor2;

            Console.WriteLine("Digite os dois valores respectivamente separados por um espaço: ");
            string[] valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);

            if (valor1 > valor2)
            {
                if(valor1 % valor2 == 0)
                {
                    Console.WriteLine("São múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos!");
                }
            }
            else if (valor1 < valor2)
            {
                if (valor2 % valor1 == 0)
                {
                    Console.WriteLine("São múltiplos!");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos!");
                }
            }
            else
            {
                Console.WriteLine("São valores iguais e múltiplos!");
            }

            //OU
            //if (valor1 % valor2 == 0 || valor2 % valor1 == 0)
            //{
            //    Console.WriteLine("São múltiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Não são múltiplos!");
            //}
        }
    }
}