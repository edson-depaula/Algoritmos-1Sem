using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_10__Exercício_91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N
            //alunos e calcular a média aritmética das notas. Contar quantos alunos estão com a nota
            //acima de 7.0.Obs.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem:
            //Não há nenhum aluno com nota acima de 5.

            Console.Write("Digite a quantidade de alunos: ");
            int qtdalunos = int.Parse(Console.ReadLine());

            int[] notas = new int [qtdalunos];
            double soma = 0;

            Console.WriteLine("");
            for(int i = 0; i < qtdalunos; i++)
            {
                Console.Write($"Digite a nota do {i + 1}º aluno: ");
                notas[i] = int.Parse(Console.ReadLine());
                soma += notas[i];
            }

            Console.WriteLine($"\nA média aritmética das notas é: {soma / qtdalunos}");


            int notamaissete = 0;

            for (int i = 0; i < qtdalunos; i++)
            {
                if (notas[i] > 7)
                {
                    notamaissete++;
                }
            }


            int notamaiscinco = 0;

            for (int i = 0; i < qtdalunos; i++)
            {
                if (notas[i] > 5)
                {
                    notamaiscinco++;
                }
            }

            
            Console.WriteLine($"\n{notamaissete} alunos tiraram nota acima de 7.");

            if (notamaiscinco == 0)
            {
                Console.WriteLine("\nNenhum aluno tirou nota maior que 5!\n");
            }

        }
    }
}
