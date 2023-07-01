using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Algoritmos_Edson_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 1.\n\n");

            //Crie um algoritmo que receba como entra um número positivo de quatro algarismos
            //ou mais e imprima o algarismo da casa das centenas.


            Console.Write("Digite um número com quatro ou mais algarismos: ");
            int num = int.Parse(Console.ReadLine());

            int modulo = num % 1000;
            int centena = modulo / 100;

            if (num < 1000)
            {
                Console.WriteLine("ERRO!!!");
            }
            else if (num >= 1000 && num <= 999999999)
            {
                Console.WriteLine($"\nA casa das centenas é: {centena}.\n\n");
            }
            else
            {
                Console.WriteLine("\n\nERRO!!!");
            }








        }
    }
}
