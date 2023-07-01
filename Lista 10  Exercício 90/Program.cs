using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia 2 vetores de inteiros V1 e V2 de N componentes cada(no máximo 50).
            //Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas mesmas posições

            Console.Write("Digite o tamanho do primeiro array (no máximo 50): ");

            int tamarray1 = 0;

            for (int i = 0; i < 1; i++)
            {
                int n1 = int.Parse(Console.ReadLine());

                if (n1 > 0 && n1 < 51)
                {
                    tamarray1 = n1;
                }
                else
                {
                    do
                    {
                        Console.Write("ERRO! Digite um valor no intervalo estipulado! ");
                        n1 = int.Parse(Console.ReadLine());

                        if (n1 > 0 && n1 < 51)
                        {
                            tamarray1 = n1;
                        }

                    } while (n1 <= 0 || n1 > 50);
                }
            }

            int[] array1 = new int[tamarray1];


            Console.Write("\nDigite o tamanho do segundo array (no máximo 50): ");

            int tamarray2 = 0;

            for (int i = 0; i < 1; i++)
            {
                int n2 = int.Parse(Console.ReadLine());

                if (n2 > 0 && n2 < 51)
                {
                    tamarray2 = n2;
                }
                else
                {
                    do
                    {
                        Console.Write("ERRO! Digite um valor no intervalo estipulado! ");
                        n2 = int.Parse(Console.ReadLine());

                        if (n2 > 0 && n2 < 51)
                        {
                            tamarray2 = n2;
                        }

                    } while (n2 <= 0 || n2 > 50);
                }
            }

            int[] array2 = new int[tamarray2];


            Console.WriteLine("");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do primeiro array (tamanho {tamarray1}): ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor do segundo array (tamanho {tamarray2}): ");
                array2[i] = int.Parse(Console.ReadLine());
            }

           
            int qtd = 0;

            for (int i = 0; i < array1.Length && i < array2.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    qtd++;
                }
            }

            Console.WriteLine($"\nExistem {qtd} vetores iguais na mesma posição");



            //Console.Write("Digite o tamanho do 1º vetor (No máximo 50): ");
            //int tamanhovetorum = int.Parse(Console.ReadLine());

            //int[] vetor1 = new int[tamanhovetorum];


            //if (tamanhovetorum <= 50)
            //{
            //    Console.Write("Digite o tamanho do 2º vetor (No máximo 50): ");
            //    int tamanhovetordois = int.Parse(Console.ReadLine());
            //    Console.Write("\n");

            //    if (tamanhovetordois <= 50)
            //    {
            //        int[] vetor2 = new int[tamanhovetordois];

            //        for (int i = 0; i < vetor1.Length; i++)
            //        {
            //            Console.Write($"Digite o {i + 1}º número do vetor primário: ");
            //            vetor1[i] = int.Parse(Console.ReadLine());
            //        }

            //        Console.Write("\n");

            //        for (int i = 0; i < vetor2.Length; i++)
            //        {
            //            Console.Write($"Digite o {i + 1}º número do vetor secundário: ");
            //            vetor2[i] = int.Parse(Console.ReadLine());
            //        }

            //        int qtd = 0;

            //        for (int i = 0; i < vetor1.Length && i < vetor2.Length; i++)
            //        {
            //            if (vetor1[i] == vetor2[i])
            //            {
            //                qtd++;
            //            }
            //        }

            //        Console.WriteLine($"\nExistem {qtd} vetores iguais na mesma posição");
            //    }

            //    else
            //    {
            //        Console.WriteLine("ERRO!");
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("\nERRO!");
            //}

        }
    }
}
