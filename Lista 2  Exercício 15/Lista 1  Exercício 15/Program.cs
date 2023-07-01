using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o lado A do paralelepípedo: ");
            double ladoa = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o lado B do paralelepípedo: ");
            double ladob = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o lado C do paralelepípedo: ");
            double ladoc = double.Parse(Console.ReadLine());

            double volumep = ladoa * ladob * ladoc;
            Console.WriteLine($"\n\nO volume é igual a: {volumep}");
         

        }
    }
}
