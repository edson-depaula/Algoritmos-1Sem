using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_64
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie um algoritmo que, dado dois números informados pelo usuário
            //(obrigatoriamente  maior que zero e menor ou igual a cem), 
            //informe qual é o menor deles. 

            Console.Write("Digite o primeiro número >0 e <=100: ");
            double prinum = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número >0 e <=100: ");
            double senum = double.Parse(Console.ReadLine());

            double menornum = 0;


            if (prinum < 0 || prinum > 100 || senum < 0 || senum > 100)
            {
                Console.WriteLine("Erro!!!");

            } else if (prinum > senum)
            {
                menornum += senum;
                Console.WriteLine($"O menor número é o {senum}.");

            } else if (senum > prinum)
            {
                menornum += prinum;
                Console.WriteLine($"O menor número é o {prinum}.");

            }  
            
        }
    }
}
