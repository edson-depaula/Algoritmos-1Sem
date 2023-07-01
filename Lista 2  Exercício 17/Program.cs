using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a área da base do prisma: ");
            double areabase = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a altura do prisma: ");
            double alturapris = double.Parse(Console.ReadLine());

            double volume = areabase * alturapris;

            Console.Write($"\nO volume do prisma triangular é: {volume}m³\n");




        }
    }
}
