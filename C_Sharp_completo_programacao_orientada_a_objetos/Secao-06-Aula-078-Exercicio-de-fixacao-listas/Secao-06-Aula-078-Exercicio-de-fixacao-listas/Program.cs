using System;
using System.Globalization;
using System.Collections.Generic;

namespace Secao_06_Aula_078_Exercicio_de_fixacao_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();//instância da List do tipo Funcionario.

            Console.Write("Quantos funcionários vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionário #" + (i + 1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id, nome, salario));//instância da classe Funcionario com seu construtor.
                Console.WriteLine();
            }

            Console.WriteLine("Entre com o id do funcionário que vai receber aumento de salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == procurarId);

            if (func != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();

            Console.WriteLine("Atualização da lista de funcionários:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
