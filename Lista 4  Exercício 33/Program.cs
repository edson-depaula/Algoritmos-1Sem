using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_33
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Receber a altura do degrau de uma escada e a altura que o usuário deseja alcançar
            //subindo a escada. Calcular e mostrar quantos degraus o usuário deverá subir para
            //atingir seu objetivo, sem se preocupar com a altura do usuário.

            Console.Write("Qual a altura do degrau em centimetros? ");
            double alturadeg = double.Parse(Console.ReadLine());

            Console.Write("\n\nQual altura você deseja alcançar em metros? ");
            double alcancaralt = double.Parse(Console.ReadLine());

            double degraumt = alturadeg / 100;
            double degraus = alcancaralt / degraumt;

            Console.Write($"\n\nPara alcançar a altura desejada você deve subir {degraus} degraus.\n\n");




        }
    }
}
