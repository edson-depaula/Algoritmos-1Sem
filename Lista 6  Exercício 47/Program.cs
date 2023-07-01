using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_47
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo para imprimir a soma de todos números de 0 a 100

            double aux = 0;
            double soma = 0;

            while (aux <= 100)
            {
                soma += aux;
                aux++;
            }

            Console.WriteLine(soma);




        }
    }
}
