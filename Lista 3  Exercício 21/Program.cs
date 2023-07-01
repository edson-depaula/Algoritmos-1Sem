using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira a primeira nota do aluno: ");
            double prinota = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a segunda nota do aluno: ");
            double senota = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a terceira nota do aluno: ");
            double ternota = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a quarta nota do aluno: ");
            double quarnota = double.Parse(Console.ReadLine());

            double mediapond = (3.0 * prinota + 5.0 * senota + 6.0 * ternota + 6.0 * quarnota) / 20;

            Console.Write($"\n\nA nota obtida foi: {mediapond}, e o aluno está ");

            Console.Write((mediapond >= 6.00) ? "Aprovado.\n\n" : "Reprovado.\n\n");




        }
    }
}
