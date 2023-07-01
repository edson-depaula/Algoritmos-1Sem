using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro valor!!");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor!!");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor!!");
            double num3 = double.Parse(Console.ReadLine());


            if (num1 >= 0)
            {

                if (num1 == 0)
                {

                    Console.WriteLine($"O primeiro valor foi: {num1} \n" +
                        $"Ele é nulo \n");

                }
                else
                {
                    Console.WriteLine($"O primeiro valor foi: {num1} \n" +
                        $"Ele é positivo \n");

                }


            }
            else if (num1 < 0)
            {

                Console.WriteLine($"O primeiro valor foi: {num1} \n" +
                    $"Ele é negativo \n");

            }


            if (num2 >= 0)
            {

                if (num2 == 0)
                {

                    Console.WriteLine($"O segundo valor foi: {num2} \n" +
                        $"Ele é nulo \n");

                }
                else
                {
                    Console.WriteLine($"O segundo valor foi: {num2} \n" +
                        $"Ele é positivo \n");

                }


            }
            else if (num2 < 0)
            {

                Console.WriteLine($"O segundo valor foi: {num2} \n" +
                    $"Ele é negativo \n");

            }


            if (num3 >= 0)
            {

                if (num3 == 0)
                {

                    Console.WriteLine($"O terceiro valor foi: {num3} \n" +
                        $"Ele é nulo \n");

                }
                else
                {
                    Console.WriteLine($"O terceiro valor foi: {num3} \n" +
                        $"Ele é positivo \n");

                }


            }
            else if (num3 < 0)
            {

                Console.WriteLine($"O terceiro valor foi: {num3} \n" +
                    $"Ele é negativo \n");

            }






        }
    }
}
