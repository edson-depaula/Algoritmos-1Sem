using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_47
{
    class Program
    {
        static void Main(string[] args)
        {

            int aux = 0;
            int soma = 0;

            while (aux <= 100)
            {
                soma += aux;
                aux++;
            }

            Console.WriteLine(soma);




        }
    }
}
