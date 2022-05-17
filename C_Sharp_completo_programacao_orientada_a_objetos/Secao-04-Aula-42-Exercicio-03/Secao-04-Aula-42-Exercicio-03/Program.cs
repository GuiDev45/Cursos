using System;
using System.Globalization;

namespace Secao_04_Aula_42_Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();//Criando o objeto e instanciando a classe.

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();//Usando o objeto aluno criado, para invocar o atributo Nome.

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
