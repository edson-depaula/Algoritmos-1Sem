using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que receba obrigatoriamente um número maior que zero
            //e imprima todos os números de zero até o número digitado

            Console.Write("Insira um número maior que zero: ");
            double num = double.Parse(Console.ReadLine());

            if (num <=0)
            {
                Console.WriteLine("Impossível realizar operação!!!");
            } else
            {
                double aux = 0;

                while (aux <= num)
                {
                    

                    Console.Write($"{aux} | ");
                    aux ++;

                }
            }





        }
    }
}
