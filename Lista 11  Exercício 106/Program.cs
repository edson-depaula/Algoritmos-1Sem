using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_11__Exercício_106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //faça um programa que receba uma palavra e a imprima de trás pra frente

            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(texto);
            Console.WriteLine("");

            for (int i = texto.Length-1; i >= 0; i--)
            {
                Console.Write(texto[i]);
            }
            Console.WriteLine("\n");





        }
    }
}
