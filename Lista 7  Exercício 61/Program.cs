using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir todos os números ímpares de 1000 até 150 em ordem decrescente.

            double inicio = 1000;
            double fim = 150;

            while (inicio >= fim)
            {
                Console.WriteLine($"{inicio}");
                inicio--;
            }







        }
    }
}
