using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edson_1GTI__Simulado_Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Edson Carlos Santos de Paula  M: F2212694  Ex: 1.\n\n");



            Console.Write("Digite o limite superior: ");
            double limitesup = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do incremento: ");
            double incremento = double.Parse(Console.ReadLine());

            //Criar um algoritmo que leia um número que será o limite superior de um intervalo e o incremento.
            //Imprimir todos os números no intervalo de 0 até esse número.
            //Suponha que os dois números lidos são obrigatoriamente maiores que zero.
            //Exemplo:
            //Limite superior: 20
            //Incremento: 5
            //Saída: 0, 5, 10, 15, 20

            if (incremento <= 0 || limitesup <= 0)
            {
                Console.WriteLine("Digite números maiores que zero!");
            } else
            {
                double aux = 0;
                while (aux <= limitesup)
                {
                    Console.Write($"{aux} | ");
                    aux += incremento;
                }
            }




        }
    }
}
