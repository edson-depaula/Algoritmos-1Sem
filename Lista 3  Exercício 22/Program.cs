using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_22
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

            double mediaarit = (prinota + senota + ternota) / 3;
            Console.Write($"\nA média aritmética foi: {mediaarit}. O aluno está ");

            Console.WriteLine((mediaarit >= 6.00) ? "Aprovado!\n" : "Reprovado!\n");



        }
    }
}
