using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que imprima todos os números de 1 ate
            //100 e a soma deles.

            double soma = 0;

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                soma += i;
            }

            Console.WriteLine($"A soma dos números de 1 a 100 é: {soma}.");



        }
    }
}
