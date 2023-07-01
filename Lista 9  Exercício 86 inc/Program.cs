using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que leia um número e imprima todos os
            //números de 1 até o número lido e o seu produto.Exemplo:
            //número: 3   
            //Saída: 1 2 3
            //6(produto)

            Console.Write("Digite um número limite: ");
            double lim = double.Parse(Console.ReadLine());

            int aux = 1;

            //double produto = 0;

            for(int i = 1; i <= lim; i++)
            {
                Console.Write($"{i} | ");
               
                aux *= i;

            }

            Console.WriteLine(aux);












        }
    }
}
