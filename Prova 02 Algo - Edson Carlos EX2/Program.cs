using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_02_Algo___Edson_Carlos_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que leia uma frase qualquer digitada pelo usuário e imprima a
            //quantidade de consoantes que a frase possui

            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 2.\n\n");

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int qtdcons = 0;
            int qtdvog = 0;
            int qtdesp = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if(frase[i] == ' ')
                {
                    qtdesp++;
                }

                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    qtdvog++;
                }
            }

            qtdcons = frase.Length - qtdvog - qtdesp;

            Console.WriteLine($"A quantidade de consoantes é: {qtdcons}.");








        }
    }
}
