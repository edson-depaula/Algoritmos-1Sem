using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(" LANCHONETE DO EDSON");
            Console.WriteLine("----------------------\n");

            Console.WriteLine("CÓDIGO          ESPECIFICAÇÃO        PREÇO UNITÁRIO");
            Console.WriteLine(" 100            Cachorro Quente          R$4,50");
            Console.WriteLine(" 101            Bauru Simples            R$4,50");
            Console.WriteLine(" 102            Bauru com ovo            R$5,50");
            Console.WriteLine(" 103            Hamburguer               R$6,50");
            Console.WriteLine(" 104            Refrigerante             R$3,50");

            double cquente = 4.50;
            double bauru = 4.50;
            double bauruovo = 5.50;
            double hamburg = 6.50;
            double refri = 3.50;

            Console.Write("\nInsira o código do produto comprado: ");
            double codigo = double.Parse(Console.ReadLine());

            Console.Write("\nInsira a quantidade comprada do produto: ");
            double quantidade = double.Parse(Console.ReadLine());

            if (codigo == 100)
            {
                Console.Write($"\nO valor total a ser pago é de: R${cquente * quantidade}.\n");
            }
            else if (codigo == 101)
            {
                Console.Write($"\nO valor total a ser pago é de: R${bauru * quantidade}.\n");
            }
            else if (codigo == 102)
            {
                Console.Write($"\nO valor total a ser pago é de: R${bauruovo * quantidade}.\n");
            }
            else if (codigo == 103)
            {
                Console.Write($"\nO valor total a ser pago é de: R${hamburg * quantidade}.\n");
            }
            else if (codigo == 104)
            {
                Console.Write($"\nO valor total a ser pago é de: R${refri * quantidade}.\n");
            } else
            {
                Console.Write($"\nProduto não encontrado na base de dados!\n");
            }





        }
    }
}
