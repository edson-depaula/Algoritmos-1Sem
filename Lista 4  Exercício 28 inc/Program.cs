using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exibir os três números informando se eles são positivos, negativos ou nulos. 
            //Informar o maior número.


            Console.Write("Digite o primeiro número: ");
            double prinum = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            double senum = double.Parse(Console.ReadLine());

            Console.Write("\nDigite o terceiro número: ");
            double ternum = double.Parse(Console.ReadLine());

            if (prinum > 0)
            {
                Console.Write("\n\nO primeiro número é maior que zero (positivo).\n\n");
            } else { }

            if (prinum < 0)
            {
                Console.Write("\n\nO primeiro número é menor que zero (negativo).\n\n");
            } else { }

            if (prinum == 0)
            {
                Console.Write("\n\nO primeiro número é igual a zero (nulo).\n\n");
            } else { }


            if (senum > 0)
            {
                Console.Write("\nO segundo número é maior que zero (positivo).\n\n");
            } else { }

            if (senum < 0)
            {
                Console.Write("\nO segundo número é menor que zero (negativo).\n\n");
            } else { }

            if (senum == 0)
            {
                Console.Write("\nO segundo número é igual a zero (nulo).\n\n");
            } else { }


            if (ternum > 0)
            {
                Console.Write("\nO terceiro número é maior que zero (positivo).\n\n");
            } else { }

            if (ternum < 0)
            {
                Console.Write("\nO terceiro número é menor que zero (negativo).\n\n");
            } else { }

            if (ternum == 0)
            {
                Console.Write("\nO terceiro número é igua a zero (nulo).\n\n");
            } else { }

            




            //if (prinum > senum) & ternum
            //{
            //    Console.Write($"\n\nO primeiro número: {prinum} é o maior.");
            //} else { }

            //if (senum )




            //Console.ReadLine();
            


        }
    }
}
