﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_34
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor da diagonal maior do losango: ");
            double dmaior = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da diagonal menor do losango: ");
            double dmenor = double.Parse(Console.ReadLine());

            double area = (dmaior * dmenor) / 2;

            if (dmaior <= 0)
            {
                Console.Write("\nValores inválidos!");
            } else if (dmenor <= 0)
            {
                Console.Write("\nValores inválidos!");
            } else
            {
                Console.Write($"A área deste losango é {area}!");
            }

            Console.ReadLine();



        }
    }
}
