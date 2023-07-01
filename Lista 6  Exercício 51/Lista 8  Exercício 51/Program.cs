using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_51
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número: ");
            double pri = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            double seg = int.Parse(Console.ReadLine());

            double aux = 0;
            double soma = 0;

            if (pri > seg)
            {
                aux = pri;
                pri = seg;
                seg = aux;
            }

            while (pri <= seg)
            {
                if (pri %2 == 0)
                {
                    soma += pri;
                }
                
                pri++;
            }

            Console.Write($"\nA soma é {soma}.\n");




        }
    }
}
