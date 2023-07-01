using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_73
{
    class Program
    {
        static void Main(string[] args)
        {
            //utilizando a estrutura for crie um algoritm que imprima todos os
            //números pares no intervalo de 1 a 10


            Console.Write("Digite o tamanho do array: ");
            int tam = int.Parse(Console.ReadLine());

            int[] numeros = new int[tam];
            //tam nos colchetes para o array ficar com o tamanho que o user digitar
            //caso contrário só declarar nos colchetes

            //lengh para egar a quantidade de posições do array, pq vc não sabe
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"O número {numeros[i]} ao quadrado é {Math.Pow(numeros[i], 2)}.");
            }








        }
    }
}
