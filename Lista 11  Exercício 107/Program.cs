using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba do usuário uma string.Posteriormente programa deve
            //imprimir a string sem suas vogais.

            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            for(int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != 'a' && texto[i] != 'e' && texto[i] != 'i' && texto[i] != 'o' && texto[i] != 'u')
                {
                    Console.Write(texto[i]);
                }
            }










        }
    }
}
