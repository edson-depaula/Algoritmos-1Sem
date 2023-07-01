using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que entre com cinco números e imprimir o
            //quadrado de cada número.

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"O quadrado do número {num} é {Math.Pow(num, 2)}.\n");
            }














        }
    }
}
