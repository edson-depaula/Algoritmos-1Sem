using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler uma frase e contar quantos caracteres são espaços em brancos.Lembre - se que
            //uma frase é um conjunto de caracteres(vetor).

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            int contador = 0;

            for(int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    contador++;
                }
            }

            Console.WriteLine($"\nHá {contador} espaços na frase.");







        }
    }
}
