using System;
using System.Globalization;

namespace Exercicio5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Cálculo da cafeteria*");
            Console.WriteLine("Obs.: Use o . como separador de casas decimais");

            int codigoItem, qtdeItem;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|  Código       Especificação        Preço   |");
            Console.WriteLine("|    1          Cachorro quente      R$4.00  |");
            Console.WriteLine("|    2          X-salada             R$4.50  |");
            Console.WriteLine("|    3          X-bacon              R$5.00  |");
            Console.WriteLine("|    4          Torrada simples      R$2.00  |");
            Console.WriteLine("|    5          Refrigerante         R$1.50  |");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Insira o código do item e a quantidade consumida respecrivamente, separados por um espaço: ");
            string[] Itens = Console.ReadLine().Split(' ');
            codigoItem = int.Parse(Itens[0]);
            qtdeItem = int.Parse(Itens[1]);

            double total;
            if (codigoItem == 1)
            {
                total = qtdeItem * 4.0;
                Console.WriteLine($"O valor total é {total:F2}!");
            }
            else if (codigoItem == 2)
            {
                total = qtdeItem * 4.5;
                Console.WriteLine($"O valor total é {total:F2}!");
            }
            else if (codigoItem == 3)
            {
                total = qtdeItem * 5.0;
                Console.WriteLine($"O valor total é {total:F2}!");
            }
            else if (codigoItem == 4)
            {
                total = qtdeItem * 2.0;
                Console.WriteLine($"O valor total é {total:F2}!");
            }
            else if (codigoItem == 5)
            {
                total = qtdeItem * 1.5;
                Console.WriteLine($"O valor total é {total:F2}!");
            }
            else
            {
                Console.WriteLine("Código inexistente!");
            }
        }
    }
}