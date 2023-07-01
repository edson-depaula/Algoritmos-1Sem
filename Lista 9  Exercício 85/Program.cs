using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_85
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que leia um número que servirá para
            //controlar os números pares que serão impressos a partir de 2.Exemplo:
            //Quantos: 4
            //Saída: 2 4 6 8

            Console.Write("Quantos números pares serão impressos? ");
            double qtd = double.Parse(Console.ReadLine());

            double aux = 2;
            double nums = 0;

            for(int i = 0; i < qtd; i++)
            {
                Console.Write($"{nums += aux} | ");
            }










        }
    }
}
