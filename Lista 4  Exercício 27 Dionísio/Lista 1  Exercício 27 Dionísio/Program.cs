using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_27_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                double numquarta = Math.Pow(numero, 4);
                if (numquarta % 2 == 0)
                {
                    if (numquarta % 5 == 0)
                    {
                        Console.Write($"\n\nO número digitado foi: {numero}");
                        Console.Write($"\n\nSeu valor elevado ao quadrado é: {Math.Pow(numero, 2)}");
                        Console.Write($"\n\nSeu valor elevado ao cubo é: {Math.Pow(numero, 3)}");
                        Console.Write($"\n\nSeu valor elevado a sétima: {Math.Pow(numero, 7)}");

                    }
                    else
                    {
                        Console.WriteLine("Não é múltiplo de 5!");
                    }
                }
                else
                {
                    Console.WriteLine("O número não é par!");
                    Console.WriteLine($"O número digitado foi: {numero}");
                    Console.WriteLine($"Sua raiz quadrada é: {Math.Pow(numero, 1.0 / 2.0)}");
                    Console.WriteLine($"Sua raiz cúbica é: {Math.Pow(numero, 1.0 / 3.0)}");
                    Console.WriteLine($"Sua raiz sétima é: {Math.Pow(numero, 1.0 / 7.0)}");

                }

            }
            else
            {
                Console.WriteLine("\nO número deve ser maior que zero!");
            }







        }
    }
}
