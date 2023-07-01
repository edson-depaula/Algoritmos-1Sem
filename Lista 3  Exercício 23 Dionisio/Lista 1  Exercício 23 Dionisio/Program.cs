using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_23_Dionisio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um número qualquer: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(Math.Pow(numero, 2));
            } else
            {
                Console.WriteLine(Math.Pow(numero, 3));
            }



        }
    }
}
