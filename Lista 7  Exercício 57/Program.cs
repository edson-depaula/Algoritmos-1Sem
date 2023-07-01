using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir todos os números pares , múltiplos de 5 e 7 de 1 até 100.
            //Imprimir também a soma destes números

            double pri = 1;
            double aux = 100;
            double somacinco = 0;
            double somasete = 0;

            while (pri <= aux)
            {
                if (pri % 5 == 0 && pri % 2 == 0)
                {
                    somacinco += pri;
                    Console.WriteLine($"{pri} é multiplo de 5 e par.");
                }

                if (pri % 7 == 0 && pri % 2 == 0)
                {
                    somasete += pri;
                    Console.WriteLine($"{pri} é multiplo de 7 e par.");
                }
                pri++;
            }

            Console.WriteLine($"\nA soma total dos números é: {somasete + somacinco}.");



        }
    }
}
