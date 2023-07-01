using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_41
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um número qualquer: ");
            double numqualquer = double.Parse(Console.ReadLine());

            if (numqualquer > 0)
            {
                Console.Write($"\nO número digitado foi: {numqualquer}, e sua raiz quadrada é: {Math.Pow(numqualquer, 1.0 / 2.0)}.\n\n");

            } else if (numqualquer < 0)
            {
                Console.Write($"\nO número digitado foi: {numqualquer}, e seu valor ao quadrado é: {Math.Pow(numqualquer, 2)}.\n\n");
            } else
            {
                Console.Write("\nErro!\n\n");
            }




        }
    }
}
