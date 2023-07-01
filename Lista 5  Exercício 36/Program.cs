using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_36
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o valor do produto a ser descontado em reais: ");
            double valorprod = double.Parse(Console.ReadLine());

            double valordescontado = valorprod * 0.91;

            if (valorprod <= 0)
            {
                Console.Write("\nInsira um valor positivo maior que zero!\n\n");
            } else
            {
                Console.Write($"\nO novo valor do produto com 9% de desconto é: R${valordescontado}.\n\n");
            }




        }
    }
}
