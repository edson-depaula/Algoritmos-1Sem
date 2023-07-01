using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_52
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int maiornumero = numero;
            int menornumero = numero;

            int controle = 0;

            while (numero >= controle)
            {
                Console.Write("Digite outro número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maiornumero)
                {
                    maiornumero = numero;
                }

                if (numero < menornumero && numero >=0)
                {
                    menornumero = numero;
                }


            }


            Console.Write($"Maior número é {maiornumero} e o menor número é o {menornumero}.");

            



        }
    }
}
