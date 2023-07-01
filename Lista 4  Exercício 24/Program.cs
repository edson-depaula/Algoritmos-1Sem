using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //salário minimo igual a R$1216,00

            Console.Write("Insira o valor do salário mínimo: ");
            double salmin = double.Parse(Console.ReadLine());
            double quilowatts = (salmin / 7) / 100;

            Console.Write("\nInsira o total de quilowatts gastos no mês: ");
            double quilonomes = double.Parse(Console.ReadLine());

            Console.Write($"\n\nO valor de cada quilowatt é de: R${quilowatts}");
            double valorquilowatts = quilowatts * quilonomes;

            Console.Write($"\n\nO valor total a ser pago é de: R${valorquilowatts}");
            double quilodezdesconto = valorquilowatts * 0.90;

            Console.Write($"\n\nO valor a ser pago com 10% de desconto é: R${quilodezdesconto}");



        }
    }
}
