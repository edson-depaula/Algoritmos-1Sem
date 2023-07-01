using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_44
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------");
            Console.WriteLine(" Sorveteria");
            Console.WriteLine("------------");

            Console.WriteLine("\nTipo 1 --- R$1,50");
            Console.WriteLine("Tipo 2 --- R$2,60");
            Console.WriteLine("Tipo 3 --- R$3,75\n");

            Console.Write("Insira quantos picolés do tipo 1 foram comprados: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("Insira quantos picolés do tipo 2 foram comprados: ");
            double p2 = double.Parse(Console.ReadLine());

            Console.Write("Insira quantos picolés do tipo 3 foram comprados: ");
            double p3 = double.Parse(Console.ReadLine());

            double v1 = 1.50;
            double v2 = 2.60;
            double v3 = 3.75;

            double total1 = v1 * p1;
            double total2 = v2 * p2;
            double total3 = v3 * p3;
            double totarr = total1 + total2 + total3;

            if (p1 <0)
            {
                Console.Write("\nPara de ser idiota e coloca o valor certo!\n");
            } else if (p2 <0)
            {
                Console.Write("\nPara de ser idiota e coloca o valor certo!\n");
            } else if (p3 <0)
            {
                Console.Write("\nPara de ser idiota e coloca o valor certo!\n");
            } else
            {
                Console.Write($"\nO total vendido em unidades foi: {p1 + p2 + p3}.\n");
                Console.Write($"\nForam comprados {p1} picolés do tipo 1 (R${total1}), {p2} do tipo 2 (R${total2}) e {p3} do tipo 3 (R${total3}).\n");
                Console.Write($"\nO total arrecadado foi de R${totarr}.\n\n");
            }

            

            





        }
    }
}
