using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write($"\n\nO valor do salário do funcionário é: R${salario}.");

            double salaument = salario * 1.25;

            Console.Write($"\n\nO novo salário reajustado com mais 25% é igual a: R${salaument}.\n");







        }
    }
}
