using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_31
{
    class Program
    {
        static void Main(string[] args)
        {

            //Efetuar a leitura de três valores e apresentar como resultado final a soma dos quadrados dos três valores lidos.
            //Apresentar também se a soma é um número par ou ímpar.

            Console.Write("Insira o primeiro valor: ");
            double privalor = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o segundo valor: ");
            double sevalor = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o terceiro valor: ");
            double tervalor = double.Parse(Console.ReadLine());

            double quadrado = Math.Pow(privalor, 2) + Math.Pow(sevalor, 2) + Math.Pow(tervalor, 2);
            Console.Write($"\nA soma do quadrado dos valores é igual a: {quadrado}.\n");

            Console.WriteLine((quadrado % 2 == 0) ? "\nA soma é um número par.\n" : "\nA soma é um número ímpar.\n");

        }
    }
}
