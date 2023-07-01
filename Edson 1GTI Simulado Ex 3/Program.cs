using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edson_1GTI_Simulado_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 1.\n\n");

            //Faça um programa que receba vários números, calcule e mostre:
            //A quantidade de números digitados[positivos]
            //A quantidade de números digitados[negativos]
            //A média dos números digitados
            //Finalize a entrada de dados caso o usuário informe o valor 0

            int num = 1;
            int qtdpos = 0;
            int qtdneg = 0;
            int qtdger = 0;
            double soma = 0;
            double media = 0;

            while (num != 0)
            {
                Console.Write("Digite um número qualquer: ");
                num = int.Parse(Console.ReadLine());

                //tem que ser só if pois senão ele não testará a outra condição e dará errado

                if (num > 0)
                {
                    qtdpos++;
                }

                if (num < 0)
                {
                    qtdneg++;
                }

                if (num != 0)
                {
                    qtdger++;
                    soma += num;
                    media = soma / qtdger;
                }

                

            }

            Console.WriteLine($"\nNúmeros positivos digitados: {qtdpos}.");
            Console.WriteLine($"Números negativos digitados: {qtdneg}.");
            Console.WriteLine($"A média dos números digitados é: {media}.\n");

        }
    }
}
