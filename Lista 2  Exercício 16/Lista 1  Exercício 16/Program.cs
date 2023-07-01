using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor da base maior do trapézio em metros: ");
            double basemaior = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o valor da base menor do trapézio em metros: ");
            double basemenor = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a altura do trapézio em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double bases = basemaior + basemenor;
            double basesvezes = bases * altura;
            double basesdiv = basesvezes / 2;

            Console.Write($"\nA área do trapézio é: {basesdiv}m².");



        }
    }
}
