using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_9__Exercício_82
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando a estrutura for entre com quatro números e imprimir o cubo e a raiz cúbica
            //de cada número

            double limite = 4;

            for (int i = 0; i < limite; i++)
            {
                Console.Write("\nDigite um número; ");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine($"O cubo do número {num} é: {Math.Pow(num, 3)} e sua raíz cúbica é: {Math.Pow(num, 1.0/3.0)}.");
            }













        }
    }
}
