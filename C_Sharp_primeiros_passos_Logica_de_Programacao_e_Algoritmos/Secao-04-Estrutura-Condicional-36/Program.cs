using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_36
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1048*/

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double reajuste;
            double novoSalario;

            if (salario <= 400.0) {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.0 && salario <= 800.0) {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800.0 && salario <= 1200.0) {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200.0 && salario <= 2000.0) {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.0) {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }   
    }
}
