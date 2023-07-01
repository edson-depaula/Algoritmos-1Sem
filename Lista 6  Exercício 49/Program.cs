using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_49
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o primeiro valor: ");
            double pri = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            double seg = double.Parse(Console.ReadLine());


            if (pri > seg)
            {
                double aux = pri;
                pri = seg;
                seg = aux;
            }

            while (seg >= pri)
            {
                Console.Write($"{pri} | ");
                pri++;
            }







        }
    }
}
