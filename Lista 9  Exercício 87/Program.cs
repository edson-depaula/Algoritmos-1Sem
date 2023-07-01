using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que imprima a soma dos números pares
            //entre 25 e 200.

            double soma = 0;

            for(int i = 25; i < 200; i++)
            {
                if(i % 2 == 0)
                {
                    //Console.WriteLine(i);
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos números pares entre 25 e 200 é: {soma}.");










        }
    }
}
