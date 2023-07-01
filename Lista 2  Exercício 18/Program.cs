using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o raio da circunferência maior da coroa: ");
            double cirmaior = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o raio da circunferência menor: ");
            double cirmenor = double.Parse(Console.ReadLine());

            double maiaoquad = Math.Pow(cirmaior, 2);
            double menaoquad = Math.Pow(cirmenor, 2);

            double areamaior = Math.PI * maiaoquad;
            double areamenor = Math.PI * menaoquad;

            double areacoroa = areamaior - areamenor;

            Console.Write($"\nA área da coroa é: {areacoroa}.\n");






        }
    }
}
