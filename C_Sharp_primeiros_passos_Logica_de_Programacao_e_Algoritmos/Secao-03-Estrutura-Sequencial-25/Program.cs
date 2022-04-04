using System;

namespace Secao_03_Estrutura_Sequencial_25
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1020*/

            //Declaração das variáveis.
            int idade, quociente, resto;
            int ano = 365;
            int mes = 30;

            //Entrada de dados.
            idade = int.Parse(Console.ReadLine());

            //Cálculo matemático.
            quociente = idade / ano;
            Console.WriteLine(quociente + " ano(s)");
            resto = idade % ano;

            quociente = resto / mes;
            Console.WriteLine(quociente + " mes(es)");
            resto = resto % mes;

            //Saída de dados.
            Console.WriteLine(resto + " dia(s)");
        }
    }
}
