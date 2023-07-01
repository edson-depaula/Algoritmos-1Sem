using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia uma variável e some 5 ao número caso ele seja par
            //ou some 8 caso seja ímpar.Deve - se imprimir o resultado desta operação.

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                num += 5;
                Console.WriteLine($"\nO número é par, e somado com 5 é: {num}.");
            }

            if (num % 2 != 0)
            {
                num += 8;
                Console.WriteLine($"\nO número é impar, e somado com 8 é: {num}.");
            }










        }
    }
}
