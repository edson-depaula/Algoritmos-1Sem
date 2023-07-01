using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia uma frase qualquer e imprima a frase e a quantidade de
            //espaços em branco esta frase possui.

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int contador = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    contador++;
                }
            }


            

            Console.WriteLine($"\nA frase é: {frase}. Nela há {contador} espaços.\n");




        }
    }
}
