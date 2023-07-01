using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que percorra todos os números de 1 até 100. Para os números
            //múltiplos de 4, imprima a palavra “PI” e para os outros imprima o próprio número.

            double aux = 0;
            double fim = 100;

            while (aux <= fim)
            {
                if (aux % 4 == 0)
                {
                    Console.WriteLine("PI");
                }

                if(aux != 4 || aux != 8 || aux != 12 || aux != 16 || aux != 20 || aux != 24 || aux !=28
                    || aux != 32 || aux != 36 || aux != 40 || aux != 44 || aux != 48 || aux != 52
                    || aux != 56 || aux != 60 || aux != 64 || aux != 68 || aux != 72 || aux != 76
                    || aux != 80 || aux != 84 || aux != 88 || aux != 92 || aux != 96 || aux != 100)
                {
                    Console.WriteLine($"{aux}");
                }
                
                aux++;

            }
















        }
    }
}
