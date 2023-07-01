using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_63
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Criar um algoritmo que leia um número que será o limite superior de um intervalo e o
            //incremento.
            //Imprimir todos os números no intervalo de 0 até esse número.
            //Suponha que os dois números lidos são obrigatoriamente maiores que zero.
            //Exemplo:
            //• Limite superior: 20
            //• Incremento: 5
            //• Saída: 0, 5, 10, 15, 20

            double auxiliar = 0;

            Console.Write("Digite o limite superior: ");
            double limitsup = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do incremento: ");
            double incremento = double.Parse(Console.ReadLine());

            while (auxiliar <= limitsup)
            {
                Console.Write($"{auxiliar} | ");
                auxiliar += incremento;
            }








        }
    }
}
