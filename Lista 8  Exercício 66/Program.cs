using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores inteiros A e B e maiores que zero.
            //Se os valores forem iguais deverá se somar os dois, caso contrário multiplique
            //A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para
            //uma variável C e mostrar seu conteúdo na tela.

            Console.Write("Digite o primeiro número maior que zero: ");
            double prinum = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número maior que zero: ");
            double senum = double.Parse(Console.ReadLine());

            if (prinum <=0  || senum <= 0)
            {
                Console.WriteLine("DIGITE VALORES MAIORES QUE ZERO!");
            }

            if (prinum == senum)
            {
                double soma = prinum + senum;
                Console.WriteLine($"\nA soma dos valores é: {soma}.\n");

            } else if (prinum != senum)
            {
                double mult = prinum * senum;
                Console.WriteLine($"\nA multiplicação dos valores é: {mult}.\n");
            }









        }
    }
}
