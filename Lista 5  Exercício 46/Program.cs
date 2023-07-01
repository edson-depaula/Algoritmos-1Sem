using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_47
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a primeira nota: ");
            double prinota = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a segunda nota: ");
            double senota = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a terceira nota: ");
            double ternota = double.Parse(Console.ReadLine());

            Console.WriteLine("\nHá dois tipos de média, escolha uma delas:");
            Console.Write("Para média simples digite 1, para média ponderada com pesos, 3, 3 e 4 digite 2. ");

            double tipomedia = double.Parse(Console.ReadLine());

            if (tipomedia == 1)
            {
                Console.Write($"\nA média simples das notas é: {(prinota + senota + ternota) / 3}.\n");
            } else if (tipomedia == 2)
            {
                Console.Write($"\nA média ponderada das notas é {(3 * prinota + 3 * senota + 4 * ternota) / 10}.\n");
            } else
            {
                Console.Write($"\nERRO!");
            }










        }
    }
}
