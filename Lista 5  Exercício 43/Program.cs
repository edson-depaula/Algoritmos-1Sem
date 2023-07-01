using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_43
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("-------------------\n");

            Console.Write("Insira sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("\nInsira seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());
            double alturaaoquad = Math.Pow(altura, 2);
            double imc = peso / alturaaoquad;

            Console.Write($"\nSeu Índice de Massa Corporal é igual a: {imc}.\n"); 

            if (imc < 17)
            {
                Console.Write("\nVocê está muito abaixo do peso.\n");
            } else if ((imc >= 17) && (imc <= 18.49)) 
            {
                Console.Write("\nVocê está abaixo do peso.\n");
            } else if ((imc >= 18.5) && (imc <= 24.99))
            {
                Console.Write("\nSeu peso está normal.\n");
            } else if ((imc >= 25) && (imc <= 29.99))
            {
                Console.Write("\nVocê está acima do peso.\n");
            } else if ((imc >= 30) && (imc <= 34.99))
            {
                Console.Write("\nVocê está com obesidade Grau 1.\n");
            } else if ((imc >= 35) && (imc <= 39.99))
            {
                Console.Write("\nVocê está com obesidade Grau 2 (severa).\n");
            } else if ((imc >= 40) && (imc <= 100))
            {
                Console.Write("\nVocê está com obesidade Grau 3 (mórbida).\n");
            } else
            {
                Console.Write("\nVOCÊ É IDIOTA?\n");
            }




        }
    }
}
