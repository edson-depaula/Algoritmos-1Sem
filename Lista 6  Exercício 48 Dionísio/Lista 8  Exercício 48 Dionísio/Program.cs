using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_48_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número maior que zero: ");
            double num = double.Parse(Console.ReadLine());

            if (num>0)
            {
                int aux = 0;

                while (aux <= num)
                {
                    Console.Write($"{aux} | ");
                    aux++;
                }


            } else
            {
                Console.WriteLine("\nOpsss!!! Digite um valor maior que zero!\n");
            }








        }
    }
}
