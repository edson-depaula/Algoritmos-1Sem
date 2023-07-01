using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_32
{
    class Program
    {
        static void Main(string[] args)
        {

            //Receber o salário de um funcionário, exibir o valor deste salário, 
            //calcular e mostrar seu novo salário, 
            //sabendo que ele recebeu um aumento de 25 %.

            Console.Write("Insira o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write($"\nO salário deste funcinário é R${salario}.\n\n");
            double salaument = salario * 1.25;

            Console.Write($"Seu novo salário com o aumento de 25% é: R${salaument}.\n\n");




        }
    }
}
