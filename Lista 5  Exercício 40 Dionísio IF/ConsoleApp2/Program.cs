using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------");
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------\n");
            
            Console.WriteLine("Digite + para Somar");
            Console.WriteLine("Digite - para Subtrair");
            Console.WriteLine("Digite * para Multiplicar");
            Console.WriteLine("Digite / para Dividir\n");
            Console.Write(">>> ");
            string operacao = Console.ReadLine();

            double numero1 = 0;
            double numero2 = 0;

            if (operacao == "+")
            {
                Console.Write("\nDigite o valor do primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("\nDigite o valor do segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                double soma = numero1 + numero2;
                Console.Write($"\nValor da soma: {soma}.\n");
            }
            else if (operacao == "-")
            {
                Console.Write("\nDigite o valor do primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("\nDigite o valor do segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                double subtracao = numero1 - numero2;
                Console.Write($"\nValor da subtração: {subtracao}.\n");
            }
            else if (operacao == "*")
            {
                Console.Write("\nDigite o valor do primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("\nDigite o valor do segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
                double multiplicacao = numero1 * numero2;
                Console.Write($"\nValor da multiplicação: {multiplicacao}.\n");
            }
            else if (operacao == "/")
            {
                Console.Write("\nDigite o valor do primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("\nDigite o valor do segundo número: ");
                numero2 = double.Parse(Console.ReadLine());

                if (numero2 == 0)
                {
                    Console.Write("\nNão é possível dividir por 0.");
                }
                else
                {
                    double divisao = numero1 / numero2;
                    Console.Write($"\nValor da divisao: {divisao}.\n");
                }

            } else
            {
                Console.WriteLine("\nERRO!!!\n");
            }


        }
    }
}
