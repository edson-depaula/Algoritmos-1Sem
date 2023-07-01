using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Algoritmos_Edson_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 2.\n\n");

            //Criar um  algoritmo que leia um número negativo que  será o limite
            //inferior de  um intervalo e o decremento.
            //Imprimir todos os números no intervalo de 0 até esse número.

            Console.Write("Digite o limite inferior: ");
            double limiteinf = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do decremento: ");
            double decremento = double.Parse(Console.ReadLine());

            if (decremento >= 0 || limiteinf >= 0)
            {
                Console.WriteLine("\nDigite valores menores que zero!");
            }
            else
            {
                double aux = 0;
                while (aux >= limiteinf)
                {
                    Console.Write($"{aux} | ");
                    aux += decremento;

                }
            }



        }
    }
}
