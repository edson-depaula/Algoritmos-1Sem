using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que receba dois números e imprima a soma
            //dos valores compreendidos entre esses números

            Console.Write("Insira o primeiro valor: ");
            double pri = double.Parse(Console.ReadLine());

            Console.Write("\nInsira o segundo valor: ");
            double seg = double.Parse(Console.ReadLine());

            double aux = 0;
            double soma = 0;

            if (seg > pri)
            {
                aux = pri;
                pri = seg;
                seg = aux;

                while (pri >= seg)
                {
                    soma += pri;
                    pri++;

                    Console.Write(soma);
                }
            } else
            {
                while (pri >= seg)
                {
                    soma += pri;
                    pri++;

                    Console.Write(soma);
                }
            }




        }
    }
}
