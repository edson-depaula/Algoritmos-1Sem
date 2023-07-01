using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir em ordem decrescente todos os números múltiplos de 3 e de 5
            //compreendidos entre 30 e 300.

            double aux = 300;
            double inic = 30;

            while (aux > inic)
            {
                if (aux % 3 == 0 && aux % 5 == 0)
                {
                    Console.WriteLine($"O número {aux} é multiplo de 3 e 5.");                  
                }
                aux--;
            }




        }
    }
}
