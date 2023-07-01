using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que calcule e mostre a soma dos 50 primeiros números pares
            //positivos.
            
            double pri = 0;
            double aux = 100;
            double soma = 0;

            while (pri <= aux)
            {
                if (pri % 2 == 0)
                {
                    soma += pri;
                }

                pri++;
            }

            Console.WriteLine($"A soma dos primeiros 50 números pares é: {soma}");
        }
    }
}
