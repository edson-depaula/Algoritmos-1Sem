using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_88
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva uma aplicação no qual o usuário deverá informar 10 números inteiro e maiores
            //que Zero em um vetor.Posteriormente exiba separadamente os números pares e os números ímpares exibidos
            //pelo usuário

            Console.Write("Digite o tamanho do array: ");
            int tam = int.Parse(Console.ReadLine());

            int[] num = new int[tam];

            //aqui ele grava no array

            for(int i = 0; i < num.Length; i++)
            {
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

            //aqui ele percorre o array

            Console.WriteLine("Numeros pares...");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                Console.Write($"{num[i]} - ");
            }

            Console.WriteLine("\nNúmeros impares...");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 != 0)
                {
                    Console.Write($"{num[i]} - ");
                }
            }










        }
    }
}
