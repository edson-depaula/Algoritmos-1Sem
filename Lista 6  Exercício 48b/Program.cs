using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_48b
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que receba um número obrigatoriamente mneor que dez e
            //imprima todos os números de 20 até o número digitado

            Console.Write("Digite um número menor que dez: ");
            double num = double.Parse(Console.ReadLine());

            if (num < 10)
            {

                int aux = 20;

                while (aux >= num)
                {
                    Console.Write($"{aux} | ");
                    aux--;
                }
                    

                
            } else
            {
                Console.Write("\nDigite um número menor que dez!\n");
            }



        }
    }
}
