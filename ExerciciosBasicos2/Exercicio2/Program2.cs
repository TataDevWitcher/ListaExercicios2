using System;
using System.Globalization;

namespace Exercicio2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Números inteiros - Par ou ímpar?*");

            int numero;
            Console.WriteLine("Insira um número inteiro e descubra o que ele é: ");
            numero = int.Parse(Console.ReadLine());

            if(numero%2 == 0)
            {
                Console.WriteLine($"O número {numero} é Par!");
            }
            else
            {
                Console.WriteLine($"O número {numero} é Ímpar!");
            }
        }
    }
}