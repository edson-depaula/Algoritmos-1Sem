using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_28_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("DIgite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("DIgite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("DIgite o terceiro número: ");
            int n3 = int.Parse(Console.ReadLine());


            if (n1 > 0)
            {
                Console.WriteLine($"O número n1 {n1} é positivo.");
            } else if (n1 < 0)
            {
                Console.WriteLine($"O número n1 {n1} é negativo.");
            } else
            {
                Console.WriteLine($"O número n1 {n1} é nulo.");
            }



            if (n2 > 0)
            {
                Console.WriteLine($"O número n2 {n2} é positivo.");
            }
            else if (n2 < 0)
            {
                Console.WriteLine($"O número n2 {n2} é negativo.");
            }
            else
            {
                Console.WriteLine($"O número n2 {n2} é nulo.");
            }

            

            if (n3 > 0)
            {
                Console.WriteLine($"\n\nO número n3 {n3} é positivo.");
            }
            else if (n3 < 0)
            {
                Console.WriteLine($"\nO número n1 {n3} é negativo.");
            }
            else
            {
                Console.WriteLine($"\nO número n1 {n3} é nulo.");
            }



            int maiornumero = 0;

            if (n1>n2)
            {
                maiornumero = n1;
            } else if (n2>n3)
            {
                maiornumero = n2;
            } else
            {
                maiornumero = n3;
            }

            Console.Write($"\n\nO maior número é {maiornumero}.");


        }
    }
}
