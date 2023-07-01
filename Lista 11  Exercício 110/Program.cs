using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_110
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que leia uma frase e imprima somente as vogais.


            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    Console.Write(frase[i]);
                }












            }

        }
    }
}
