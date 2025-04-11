using System;
using System.Globalization;

namespace Exercicio4
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*Duração de um jogo*");

            int horaInicial, horaFinal;

            Console.WriteLine("Insira o horário inicial e final respectivamente separados por um espaço, desconsiderando os minutos. Apenas horas inteiras: ");
            string[] horarios = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(horarios[0]);
            horaFinal = int.Parse(horarios[1]);

            if(horaInicial < horaFinal)
            {
                int duracao = horaFinal - horaInicial;
                Console.WriteLine($"O jogo durou {duracao} hora(s)!");
            }
            else if(horaFinal < horaInicial)
            {
                int duracao = 24 - horaInicial + horaFinal;
                Console.WriteLine($"O jogo durou {duracao} hora(s)!");

            } else
            {
                Console.WriteLine("O jogo durou 24 horas!");
            }



        }
    }
}