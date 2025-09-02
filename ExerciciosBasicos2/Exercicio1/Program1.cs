using System;
using System.Globalization;

namespace Exercicio1
{
    class Program1
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("*Números inteiros - Negativo ou positivo?*");

            int numeroInt;

            Console.WriteLine("Informe um número inteiro e saberá se é positivo ou negativo: ");
            numeroInt = int.Parse(Console.ReadLine());

            if(numeroInt < 0)
            {
                Console.WriteLine($"O número {numeroInt} é negativo!");
            }
            else if(numeroInt > 0)
            {
                Console.WriteLine($"O número {numeroInt} é positvo!");
            }
            else
            {
                Console.WriteLine($"O número {numeroInt} é neutro!");
            }
        }
    }

}
