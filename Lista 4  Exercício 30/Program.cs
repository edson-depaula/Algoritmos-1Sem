using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira uma temperatura em Celsius: ");
            double tempcelsius = double.Parse(Console.ReadLine());

            double fahrenheit = tempcelsius * (9.0 / 5.0) + 32;
            Console.Write($"\n\nA temperatura {tempcelsius}°C em Fahrenheit é igual a: {fahrenheit}°F.\n\n");




        }
    }
}
