using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que imprima uma tabela de conversão de
            //polegadas para centímetros.Deseja - se que na tabela conste valores desde 1 polegada até
            //20 polegadas inteiras.Cada polegada vale 2,54 cm

            double cm = 2.54;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"O valor de {i} polegada(s) em CM é {cm * i}CM.");
            }
















        }
    }
}
