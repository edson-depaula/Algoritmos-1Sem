using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edson_1GTI_Simulado_Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 1.\n\n");

            //Entrar com um número de 2 algarismos ou mais e imprimir o algarismo da
            //casa das dezenas.

            Console.Write("Digite um número com dois ou mais algarismos: ");
            int num = int.Parse(Console.ReadLine());

            int modulo = num % 100;
            int dezena = modulo / 10;

            if (num < 10)
            {
                Console.WriteLine("ERRO!!!");
            }
            else if (num >= 10 && num <= 999999999)
            {
                Console.WriteLine($"\nA casa das dezenas é: {dezena}.\n\n");
            } else
            {
                Console.WriteLine("\n\nERRO!!!");
            }







        }
    }
}
