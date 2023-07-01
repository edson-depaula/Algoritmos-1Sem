using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes
            //aparece o número 1, 3 e 4, nesta ordem. O vetor terá no máximo 100 posições.Sair do
            //programa quando for digitado - 1.


            Console.Write("Digite o tamanho do vetor (no máximo 100): ");

            int tamarray = 0;

            for (int i = 0; i < 1; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                if (n1 > 0 && n1 < 101)
                {
                    tamarray = n1;
                }
                else
                {
                    do
                    {
                        Console.Write("ERRO! Digite um valor no intervalo estipulado! ");
                        n1 = int.Parse(Console.ReadLine());

                        if (n1 > 0 && n1 < 51)
                        {
                            tamarray = n1;
                        }

                    } while (n1 <= 0 || n1 > 100);
                }
            }

            int[] vetor = new int[tamarray];


            int qtdum = 0;
            int qtdtres = 0;
            int qtdquatro = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] == 1)
                {
                     qtdum++;
                }

                if (vetor[i] == 3)
                {
                     qtdtres++;
                }

                if(vetor[i] == 4)
                {
                    qtdquatro++;
                }
            }



        }
    }
}
