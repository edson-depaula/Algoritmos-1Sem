using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_72
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;i <= 5; i++)
            {
                Console.Write("\nDigite um número: ");
                double numero = double.Parse(Console.ReadLine());
                Console.WriteLine($"O quadrado do número {numero} é {Math.Pow(numero, 2)}");
            }











        }
    }
}
