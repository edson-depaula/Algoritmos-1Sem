using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_88b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Considere um vetor de 10 números inteiros positivos maiores que zero e um único
            //número inteiro, também positivo e maior que zero. Faça um programa para:
            //a. ler pelo teclado o vetor;
            //b. ler pelo teclado o número X;
            //c. dizer quantos números no vetor são maiores que X , menores que X e iguais a
            //X.

            int[] num = new int[10];

            //aqui ele grava no array
                                //num.Length pega a quantia de casinhas
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                int n = int.Parse(Console.ReadLine());
                //A cada entrada de dados vai ser gravada em uma casinha diferente

                if (n > 0)
                {
                    num[i] = n;
                } else
                {
                    do
                    {
                        Console.WriteLine("ERRO! Digite um número maior que zero");
                        n = int.Parse(Console.ReadLine());

                        if(n > 0)
                        {
                            num[i] = n;
                        }

                    } while (n <= 0);
                }
                
            }

            Console.Write("\nDigite o número de comparação: ");
            int numcomp = 0;

            for(int i = 0; i < 1; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if(n > 0)
                {
                    numcomp = n;
                } else
                {
                    do
                    {
                        Console.Write("ERRO! Digite um número maior que zero! ");
                        n = int.Parse(Console.ReadLine());

                        if (n > 0)
                        {
                            numcomp = n;
                        }
                    } while (n <= 0);
                }
            }


            Console.Write("\nNúmeros do vetor maiores que o Nº de comparação:");
            for(int i = 0; i < num.Length; i++)
            {
                if(num[i] > numcomp)
                {
                    Console.Write($" {num[i]} |");
                }
            }

            Console.Write("\n\nNúmeros do vetor menores que o Nº de comparação:");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < numcomp)
                {
                    Console.Write($" {num[i]} |");
                }
            }

            Console.Write("\n\nNúmeros do vetor iguais ao Nº de comparação:");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == numcomp)
                {
                    Console.Write($" {num[i]} |");
                }
            }
        }
    }
}
