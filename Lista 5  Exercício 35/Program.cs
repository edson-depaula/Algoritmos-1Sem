using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_35
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a diagonal maior do losango em metros: ");
            double dmaior = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a diagonal menor do losango em metros: ");
            double dmenor = double.Parse(Console.ReadLine());

            double lado = Math.Sqrt(Math.Pow(dmaior, 2) + Math.Pow(dmenor, 2));

            if (dmaior <= 0)
            {
                Console.Write("\n\nDigite um número positivo!\n\n");
            } else if (dmenor <= 0)
            {
                Console.Write("\n\nDigite um número positivo!\n\n");
            } else
            {
                Console.Write($"\n\nO valor do lado do losango é igual a: {lado}m.\n\n");
            }







        }
    }
}
