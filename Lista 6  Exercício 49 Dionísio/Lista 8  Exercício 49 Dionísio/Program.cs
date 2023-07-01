using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_49_Dionísio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }

            while (n1 <= n2)
            {
                Console.Write($"{n1} |");
                n1++;
            }








        }
    }
}
