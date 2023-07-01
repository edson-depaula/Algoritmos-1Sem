using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1__Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do raio: ");

            double entraio = double.Parse(Console.ReadLine());

            double area = (Math.PI) * (Math.Pow(entraio, 2));

            double perimetro = 2 * (Math.PI) * (entraio);

            Console.WriteLine($"A Area da circunferência é: {area}");
            Console.WriteLine($"O perímetro da circunferência é: {perimetro}");



        }
    }
}
