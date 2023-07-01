using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_37
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um valor qualquer: ");
            double numqualquer = double.Parse(Console.ReadLine());
            double quadqualquer = Math.Pow(numqualquer, 2);

            Console.Write($"\nO quadrado do número é igual a: {quadqualquer}.\n");

            if (quadqualquer > 10)
            {
                Console.Write("\nO novo numero é maior que 10.");
                Console.Write($"\n\nE sua raíz cúbica é: {Math.Pow(quadqualquer, 1.0 / 3.0)}.\n");

            } else if (quadqualquer == 10)
            {
                Console.Write("\nO novo número é igual a 10.");
            } else
            {
                Console.Write("\nO novo número é menor que 10.");
            }




        }
    }
}
