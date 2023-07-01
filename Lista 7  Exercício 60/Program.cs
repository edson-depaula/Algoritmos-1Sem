using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que imprima a soma dos números ímpares de 1 a 200

            double inicio = 1;
            double fim = 200;
            double soma = 0;

            while (inicio <= fim)
            {
                if (inicio % 2 != 0)
                {
                    soma += inicio;
                }
                inicio++;
            }

            Console.WriteLine($"A soma de todos números impares de 1 a 200 é: {soma}");




        }
    }
}
