using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for crie um algoritmo que imprima os números pares no intervalo
            //de 1 a 600

            for(int i = 1; i <= 600; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine(i);
                }
            }





        }
    }
}
