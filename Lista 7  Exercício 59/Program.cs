using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler dois números e imprimir todos os números pares e múltiplos de 7 compreendidos
            //entre os números digitados pelo usuário.
            //Atenção: o usuário pode digitar o primeiro número menor que o segundo e vice - versa

            double trocanum = 0;

            Console.WriteLine("Digite o primeiro número:  ");
            double prinum = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:  ");
            double senum = double.Parse(Console.ReadLine());

            if (prinum > senum)
            {
                while (prinum > senum)
                {
                    if (prinum % 2 == 0 && prinum % 7 == 0)
                    {
                        Console.WriteLine($"O número {prinum} é par e multiplo de 7.");
                    }
                    prinum--;
                }
            }

            if (senum > prinum)
            {
                while (prinum < senum)
                {
                    if (senum % 2 == 0 && senum % 7 == 0)
                    {
                        Console.WriteLine($"O número {senum} é par e multiplo de 7.");
                    }
                    senum--;
                }
            }




        }
    }
}
