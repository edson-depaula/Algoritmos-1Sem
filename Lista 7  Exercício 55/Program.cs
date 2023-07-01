using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_55
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Faça um programa que receba vários números, calcule e mostre:
            //• A soma dos números digitados
            //• A quantidade de números digitados
            //• A média dos números digitados
            //• O maior número digitado
            //• O menor número digitado
            //• A média dos números pares
            //• Finalize a entrada de dados caso o usuário informe o valor 0.

            double num = 1;
            double soma = 0;
            double quant = 0;
            double maiornum = 0;
            double menornum = 0;
            double somapar = 0;
            double quantpar = 0;

            while (num != 0)
            {
                Console.Write("Digite um número qualquer: ");
                num = double.Parse(Console.ReadLine());

                if (num != 0)
                {
                    soma += num;
                }
                if (num != 0)
                {
                    quant++;
                }
                if (num > maiornum)
                {
                    maiornum = num;
                }
                if (num < menornum)
                {
                    menornum = num;
                }
                if (num % 2 == 0)
                {
                    somapar += num;
                }
                if (num % 2 == 0)
                {
                    quantpar++;
                }

                
            }

            Console.WriteLine($"\nA soma dos números digitados é: {soma}.");
            Console.WriteLine($"A quantidade de números digitados é: {quant}.");
            Console.WriteLine($"A média dos números digitados é: {soma/quant}.");
            Console.WriteLine($"O maior número digitado é: {maiornum}.");
            Console.WriteLine($"O menor número digitado é: {menornum}.");
            Console.WriteLine($"A média dos números pares é: {somapar/quantpar}.");







        }
    }
}
