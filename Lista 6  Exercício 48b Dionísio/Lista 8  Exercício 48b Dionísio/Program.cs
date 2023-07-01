using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_48b_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número menor que dez: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                int aux = 20;

                while (aux >= num)
                {
                    Console.Write($"{aux} | ");
                    aux--;
                }
            } else
            {
                Console.WriteLine("\nOpsss! O número deve ser menor que dez!");
            }




        }
    }
}
