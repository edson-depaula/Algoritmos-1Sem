using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8__Exercício_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tendo como dados de entrada a altura e o sexo de uma pessoa, 
            //construa um algoritmo quecalcule seu peso ideal, utilizando as seguintes fórmulas:
            //para homens: (72.7 * h) – 58; 
            //para mulheres: (62.1 * h) – 44.7.

            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("\nDigite seu sexo: ");
            string sexo = Console.ReadLine();

            double pesoidhom = (72.7 * altura) - 58;
            double pesoidmul = (62.1 * altura) - 44.7;

            if (sexo == "Masculino" || sexo == "masculino" || sexo == "M" || sexo == "m")
            {
                Console.WriteLine($"\nO seu peso ideal é: {pesoidhom}KG.\n");
            }

            if (sexo == "Feminino" || sexo == "feminino" || sexo == "F" || sexo == "f")
            {
                Console.WriteLine($"\nO seu peso ideal é: {pesoidmul}KG.\n");
            }


             















        }
    }
}
