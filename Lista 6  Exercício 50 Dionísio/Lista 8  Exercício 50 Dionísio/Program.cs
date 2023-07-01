using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_50_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número: ");
            double pri = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            double seg = int.Parse(Console.ReadLine());


            double aux = 0;
            double soma = 0;

            if (pri > seg)
            {
                aux = pri;
                pri = seg;
                seg = aux;

            }

            while (pri <= seg)
            {
                //soma = soma + num1;
                soma += pri;
                //pri += 1;
                pri++;

            }

            //Colocar para imprimir fora do laço
            Console.WriteLine($"\nO valor da soma é: {soma}.");

            

        }
    }
}
