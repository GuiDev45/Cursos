using System;
using System.Globalization;
using Secao_09_Aula_128_129_130_Exercicios_resolvidos.Entities;
using Secao_09_Aula_128_129_130_Exercicios_resolvidos.Entities.Enums;

namespace Secao_09_Aula_128_129_130_Exercicios_resolvidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            //transformando o enum em string com argumento de entrada de dados.
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Objetos Department e Worker instanciados.
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter " + "#" + (i+1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //Instanciando o contrato.
                HourContract contract = new HourContract(date, valuePerHour, hours);
                //Adicionando o contrato ao trabalhador/Worker
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //Recortando o monthAndYear, do 0 caractere até o 2 caractere que seria os dois números do mês MM.
            int month = int.Parse(monthAndYear.Substring(0, 2));
            //Recortando o monthAndYear, do caractere 3 em diante, YYYY.
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
