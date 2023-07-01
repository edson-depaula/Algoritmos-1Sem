using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_02_Algo___Edson_Carlos_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que receba vários números inteiros digitados pelo usuário.
            //Estes números devem ser obrigatoriamente maiores que zero.
            //O algoritmos deve ser finalizado quando for digitado um número menor ou igual a zero.
            //Ao final o algoritmo deve informar o maior número digitado pelo usuário

            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 1.\n\n");

            int num = 1;
            int maiornum = 0;
            
            while (num > 0)
            {
                Console.Write("Digite um número qualquer: ");
                num = int.Parse(Console.ReadLine());

                if(num > maiornum)
                {
                    maiornum = num;
                }
                         

            }

            Console.WriteLine($"\nO maior número digitado é o {maiornum}.");













        }
    }
}
