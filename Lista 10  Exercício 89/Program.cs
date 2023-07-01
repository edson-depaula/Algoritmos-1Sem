using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exerício_89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada uma seqüência de n números(vetor de inteiros), imprimi - la na ordem inversa que
            //foi realizada a leitura.

            Console.Write("Digite o tamanho do Array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanho];

            Console.WriteLine("");
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Vetor na ordem inversa: ");
                       //tamanho - 1 para o número ficar igual do índice
            for (int i = tamanho - 1; i >= 0; i --)
            {
                Console.Write($"{numeros[i]} | ");
            }













        }
    }
}
