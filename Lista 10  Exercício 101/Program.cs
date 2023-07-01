using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
            //um somente para números pares, e outro somente para números ímpares. Após, exiba os valores dos dois vetores na tela, em sequência.Obs.: As posições que não receberem valores exibirão o número zero. Não se preocupe
            //com isso por enquanto.

            int[] pares = new int[10];
            int[] impares = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Digite um número: ");
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    pares[i] = n;
                }
                else
                {
                    impares[i] = n;
                }
            }

            
            Console.Write("\nNúmeros pares: ");
            for(int i = 0; i < pares.Length; i++)
            {
                Console.Write(pares[i] + " | ");
            }

            Console.Write("\nNúmeros impares: ");
            for (int i = 0; i < impares.Length; i++)
            {
                Console.Write(impares[i] + " | ");
            }





        }
    }
}
