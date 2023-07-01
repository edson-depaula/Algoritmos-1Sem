using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_26
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                if(numero % 2 == 0)
                {
                    Console.WriteLine("\nPar");
                } else {
                    Console.WriteLine("\nImpar");
                }

            } else {
                Console.WriteLine("O número deve ser maior que zero!!!");

            }



        }
    }
}


