using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o primeiro valor: ");
            double privalor = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o segundo valor: ");
            double sevalor = double.Parse(Console.ReadLine());

            double soma = privalor + sevalor;
            Console.Write($"\n\nO valor da soma é igual a: {soma}.");

            if (soma > 10)
            {
                Console.Write($"\n\n\nOs números digitados foram: {privalor} e {sevalor}.");
                Console.Write($"\n\nO valor da adição é: {soma}.");
                Console.Write($"\n\nO valor da raíz cúbica da adição é: {Math.Pow(soma, 1.0 / 3.0)}.");
            } else
            {
                Console.Write($"\n\n\nOs números digitados foram: {privalor} e {sevalor}.");
                Console.Write($"\n\nO valor da adição foi: {soma}.");
            }







        }
    }
}
