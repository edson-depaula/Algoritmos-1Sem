using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Construir um algoritmo que leia dois valores numéricos e efetue sua adição. 
            //Caso o resultado da adição seja maior que 10, exibir os números digitados, o
            //valor da adição e a raiz cúbica da adição.
            //Caso contrário exibir somente os valores digitados e o valor da adição.

            Console.Write("Insira o primeiro valor: ");
            double privalor = double.Parse(Console.ReadLine());

            Console.Write("\n\nInsira o segundo valor: ");
            double sevalor = double.Parse(Console.ReadLine());

            double adicao = privalor + sevalor;
            double raizcub = Math.Pow(adicao, 1.0 / 3.0);

            if (adicao > 10)
            {
                Console.Write($"\n\nOs números digitados foram: {privalor} e {sevalor}.");
                Console.Write($"\n\nO valor da adição foi: {adicao}.");
                Console.Write($"\n\nA raiz cúbica da adição é {raizcub}.\n");
            } else
            {
                Console.Write($"\n\nOs valores digitados foram: {privalor} e {sevalor}.");
                Console.Write($"\n\nO valor da adição é: {adicao}.\n");
            }




        }
    }
}
