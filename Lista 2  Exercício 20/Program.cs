using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o raio da esfera em metros: ");
            double entraio = double.Parse(Console.ReadLine());

            double raioaoquad = Math.Pow(entraio, 2);
            double raioaocubo = Math.Pow(entraio, 3);
            double area = Math.PI * raioaoquad * 4;
            double svolume = Math.PI * raioaocubo;
            double volume = svolume * 4.0 / 3.0;

            Console.Write($"\nA área da esfera é igual a: {area}.");
            Console.Write($"\n\nO volume da esfera é igual a: {volume}.\n\n\n");





        }
    }
}
