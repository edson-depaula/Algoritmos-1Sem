using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_81
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for entre com 10 números e imprimir a metade de cada número

            double limite = 10;

            for (int i = 0; i < limite; i++)
            {
                Console.Write("\nDigite um número: ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"Sua metade é: {num / 2}.");
            }











        }
    }
}
