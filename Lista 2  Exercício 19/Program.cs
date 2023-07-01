using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o raio da base do cilindro em metros: ");
            double raiobase = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a altura do cilindro em metros: ");
            double altcilindro = double.Parse(Console.ReadLine());

            double areabase = Math.Pow(raiobase, 2) * Math.PI;
            double volume = areabase * altcilindro;

            Console.WriteLine($"\nO volume do cilindro é igual a: {volume}m³");
        





        }
    }
}
