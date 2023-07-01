using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_104_Dionísio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que leia uma string e a imprima cada letra separada por um traço

            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine(texto);
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.Length); //quantidade de caracteres

            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i] + " - ");
            }







        }
    }
}
