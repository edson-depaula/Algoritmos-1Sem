using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um número: ");
            double numqualquer = double.Parse(Console.ReadLine());

            Console.WriteLine((numqualquer % 2 == 0) ? $"\n{numqualquer} é par, {Math.Pow(numqualquer, 2)} é seu valor elevado a 2.\n\n" :
                $"\n{numqualquer} é impar, {Math.Pow(numqualquer, 3)} é seu valor elevado a 3.\n\n");



        }
    }
}
