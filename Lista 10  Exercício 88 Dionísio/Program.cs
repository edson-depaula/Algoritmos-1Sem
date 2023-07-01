using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_88_Dionísio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escreva uma aplicação no qual o usuário deverá informar 10 números inteiros e maiores que zero em um vetor
            //posteriormente exiba separadamente os números pares e os números ímpares exibidos pelo usuário.


            Console.Write("Digite o tamanho do array: ");
            int tam = int.Parse(Console.ReadLine());


            int[] num = new int[tam];

            //num.lenght pega o tamanho máximo do array
            //o i aqui controla o índice do array(0, 1, 2, 3...)
            for (int i = 0; i < num.Length; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    //o i é quem controla o índice
                    num[i] = n;

                } else
                {
                    do
                    {
                        Console.WriteLine("Erro!!! Digite um número maior que zero!");
                        n = int.Parse(Console.ReadLine());

                        if (n > 0)
                        {
                            //array de posição i(indice) recebe o número
                            num[i] = n; 
                        }
                    } while (n <= 0);
                }

            }


            Console.WriteLine("Números pares...");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.Write($"{num[i]} - ");
                }
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
