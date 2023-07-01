using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Algoritmos_Edson_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 3.\n\n");

            //Faça um programa que receba vários números, calcule e mostre:
            //A quantidade de números digitados múltiplos de 7 
            //A soma dos números ímpares e múltiplos de 7.
            //Finalize a entrada de dados caso o usuário informe um valor menor ou igual a 0(zero)

            int num = 1;
            int qtdmulsete = 0;
            double somatot = 0;

            while (num > 0)
            {
                Console.Write("Digite um número qualquer: ");
                num = int.Parse(Console.ReadLine());

                //tem que ser só if pois senão ele não testará a outra condição e dará errado

                if (num % 7 == 0 && num > 0)
                {
                    qtdmulsete ++;
                }

                if (num % 2 != 0 && num % 7 == 0)
                {
                    somatot += num;
                }


            }

            Console.WriteLine($"\nQuantidade de múltiplos de 7 digitados: {qtdmulsete}.");
            Console.WriteLine($"A soma de números impares E multiplos de 7 é: {somatot}.");
            



        } 
    }
}
