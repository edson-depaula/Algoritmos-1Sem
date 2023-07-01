using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_27_inc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("insira um número positivo e maior que zero: ");
            double numqualquer = double.Parse(Console.ReadLine());

            double segundapot = Math.Pow(numqualquer, 2);
            double quartapot = Math.Pow(numqualquer, 4);
            double terceirapot = Math.Pow(numqualquer, 3);
            double setimapot = Math.Pow(numqualquer, 7);
            double raizdonum = Math.Sqrt(numqualquer);

            if (quartapot % 2 == 0)
            {
                if (quartapot % 5 == 0)
                {
                    Console.Write($"\nO número digitado foi {numqualquer}.");
                    Console.Write($"\n\nSeu valor elevado a segunda potência é: {segundapot}.");
                    Console.Write($"\n\nSeu valor elevado ao cubo é: {terceirapot}.");
                    Console.Write($"\n\nSeu valor elevado a sétima é: {setimapot}.\n\n");

                }
                else { Console.Write("\n\nO número não satisfaz as duas condições. É par, mas não multiplo de 5.\n\n"); }
            }
            else {
                Console.Write($"\n\nO número digitado foi {numqualquer}. Sua raíz quadrada é {raizdonum}.\n\n");
           
            }




        }
    }
}
