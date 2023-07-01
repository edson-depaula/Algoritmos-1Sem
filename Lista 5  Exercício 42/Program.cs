using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_7__Exercício_42
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write($"\nInsira a primeira nota do(a) {nome}: ");
            double prinota = double.Parse(Console.ReadLine());

            Console.Write($"\nInsira a segunda nota do(a) {nome}: ");
            double senota = double.Parse(Console.ReadLine());

            double media = (prinota + senota) / 2;

            //Console.Write($"\nA média aritmética do(a) {nome} é: {(prinota + senota) / 2}");
            //Console.Write($"A média do(a) {nome} foi {media} e ele(a) está APROVADO!");

            if (prinota > 10)
            {
                Console.Write("\nAs notas estão fora do intervalo estabelecido!\n\n");
            } else if (prinota < 0)
            {
                Console.Write("\nAs notas estão fora do intervalo estabelecido!\n\n");
            } else if (senota > 10)
            {
                Console.Write("\nAs notas estão fora do intervalo estabelecido!\n\n");
            } else if (senota < 0)
            {
                Console.Write("\nAs notas estão fora do intervalo estabelecido!\n\n");
            } else if (media > 7)
            {
                Console.Write($"\nAs notas do(a) aluno(a) {nome} foram {prinota} e {senota}. A média foi {media} e ele está APROVADO!\n\n");
            } else if (media < 5)
            {
                Console.Write($"\nAs notas do(a) aluno(a) {nome} foram {prinota} e {senota}. A média foi {media} e ele está RETIDO!\n\n");
            } else
            {
                Console.Write($"\nAs notas do(a) aluno(a) {nome} foram {prinota} e {senota}. A média foi {media} e ele esta de RECUPERAÇÃO!\n\n");
            }


        }
    }
}
