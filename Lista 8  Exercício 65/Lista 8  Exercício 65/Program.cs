using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_65
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que, dado o nível de alerta de risco, imprima se ele for GRAVE.
            //O nível de alerta é um número que varia de 0 a 10.
            //O nível é considerado GRAVE quando ele é superior a 9.

            Console.Write("Digite um valor para análise de risco: ");
            double num = double.Parse(Console.ReadLine());

            if (num < 0 || num > 10)
            {
                Console.WriteLine("O número está fora do intervalo estipulado!");
            } else if (num > 9)
            {
                Console.WriteLine("\nO risco é considerado GRAVE!\n");
            } else if (num <= 9)
            {
                Console.WriteLine("\nO risco é considerado aceitável. Tenha um bom dia!\n");
            }








        }
    }
}
