using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia uma string e a imprima cada letra separada por um traço[-].

            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            Console.WriteLine($"O texto tem {palavra.Length} caracteres.");

            for(int i = 0; i < palavra.Length; i++)
            {
                Console.Write(palavra[i] + " - ");
            }







        }
    }
}
