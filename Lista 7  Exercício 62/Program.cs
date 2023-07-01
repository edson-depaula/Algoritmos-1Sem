using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_62
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que imprima uma tabela de conversão de polegadas para
            //centímetros.Deseja - se que na tabela conste valores de 1 polegada até 20 polegadas
            //inteiras.
            //Cada polegada possui 25,4 mm.

            double polegadas = 1;
            double valorpole = 25.4;
            double limite = 20;

            while (polegadas <= limite)
            {
                Console.WriteLine($"O valor de {polegadas} polegadas em milímetros é de {valorpole * polegadas}MM.");
                polegadas++;
            }




        }
    }
}
