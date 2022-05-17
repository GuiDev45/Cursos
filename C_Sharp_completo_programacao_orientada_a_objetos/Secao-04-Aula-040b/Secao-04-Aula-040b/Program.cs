using System;
using System.Globalization;

namespace Secao_04_Aula_040b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto tipo Funcionário "f1 e f2", instanciando com o "new".
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();//Invocando o atributo "Nome" da classe Funcionário, utilizando o objeto criado.
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
