using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que some todos os números abaixo de 1000 que são múltiplos
            //de 3 e de 5.

            double aux = 1000;
            double pri = 0;
            double somatres = 0;
            double somacinco = 0;

            while (pri < aux)
            {
                if (pri % 3 == 0)
                {
                    somatres += pri;
                }             
                
                if (pri % 5 == 0)
                {
                    somacinco += pri;
                }

                pri++;
            }

            double somat = somatres + somacinco;

            Console.WriteLine($"A soma dos multiplos de três e cinco é: {somat}.");


        }
    }
}
