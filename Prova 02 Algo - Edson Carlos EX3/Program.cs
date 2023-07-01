using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_02_Algo___Edson_Carlos_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ainda no exercício anterior imprima a frase digitada pelo usuario sem espaços em branco.
            //imprimir também a quantidade de espaços em branco de frase.

            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 3.\n\n");

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int qtdcons = 0;
            int qtdvog = 0;
            int qtdesp = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    qtdesp++;
                }

                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    qtdvog++;
                }
            }

            qtdcons = frase.Length - qtdvog - qtdesp;

            Console.WriteLine($"\nA quantidade de consoantes é: {qtdcons}.\n");

            Console.Write("Frase sem os espaços em branco: ");
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    Console.Write(frase[i]);
                }
            }
            Console.WriteLine("");

            Console.WriteLine($"\nA quantidade de espaços em branco é: {qtdesp}.");








        }
    }
}
