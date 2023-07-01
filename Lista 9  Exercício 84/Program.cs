using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que leia um número que será o limite
            //superior de um intervalo e imprimir todos os números ímpares menores do que esse
            //número.Exemplo:
            //Limite superior: 15
            //Saída: 1 3 5 7 9 11 13


            double limite = 0;

            Console.Write("Digite o limite superior: ");
            limite = double.Parse(Console.ReadLine());

            for(int i = 0; i < limite; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
















        }
    }
}
