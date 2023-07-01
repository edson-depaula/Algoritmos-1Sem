using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_40
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual tipo de operação você deseja realizar?");
            Console.Write("Adição, Subtração, Multiplicação ou Divisão? ");
            string operação = Console.ReadLine();

            switch (operação)
            {
                case "Adição":
                    Console.Write("\n\nDigite o primeiro número a ser somado: ");
                    double prinumad = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o segundo número a ser somado: ");
                    double senumad = double.Parse(Console.ReadLine());
                    Console.Write($"\nO resultado da soma é: {prinumad + senumad}.\n\n");
                    break;

                case "Subtração":
                    Console.Write("\n\nDigite o primeiro número a ser subtraído: ");
                    double prinumsub = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o segundo número a ser subtraído: ");
                    double senumsub = double.Parse(Console.ReadLine());
                    Console.Write($"\nO resultado da subtração é: {prinumsub - senumsub}.\n\n");
                    break;

                case "Multiplicação":
                    Console.Write("\n\nDigite o primeiro número a ser multiplicado: ");
                    double prinumult = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o segundo número a ser multiplicado: ");
                    double senumult = double.Parse(Console.ReadLine());
                    Console.Write($"\nO resultado da multiplicação é: {prinumult * senumult}.\n\n");
                    break;

                case "Divisão":
                    Console.Write("\n\nDigite o primeiro número a ser dividido: ");
                    double prinumdiv = double.Parse(Console.ReadLine());
                    Console.Write("\nDigite o segundo número a ser dividido: ");
                    double senumdiv = double.Parse(Console.ReadLine());
                    double divisao = prinumdiv / senumdiv;
                    if (senumdiv == 0)
                    {
                        Console.WriteLine("\nImpossível dividir por 0.\n\n");
                    } else
                    {
                        Console.Write($"\nO resultado da divisão é: {divisao}.\n\n");
                    }
                    
                    
                    break;

            }


        }
    }
}
