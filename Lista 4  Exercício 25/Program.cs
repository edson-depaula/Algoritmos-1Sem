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

            Console.Write("Insira o valor da base do triângulo em metros: ");
            double ladoa = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a altura do triângulo em metros: ");
            double ladob = double.Parse(Console.ReadLine());

            double areatri = (ladoa * ladob) / 2;
            Console.Write($"\n\nA área deste triângulo é igual a: {areatri}m².\n");

            double hipotenusa = Math.Sqrt(Math.Pow(ladoa, 2) + Math.Pow(ladob, 2));

            if (ladoa > 0)
            {
                if (ladob > 0)
                {
                    if (hipotenusa >= 0)
                    {
                        Console.Write($"\nA hipotenusa do triângulo é {hipotenusa}.");
                    } else { Console.Write("\nNão atende aos requisitos.");
                    }
                } else { Console.Write("\nDigite um numero positivo.");
                }
            } else { Console.Write("\nDigite um numero positivo.");
            }

            
            Console.ReadLine();


        }
    }
}
