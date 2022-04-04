using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_27
{
    class Program
    {
        static void Main(string[] args){
            //Declaração de variáveis.
            double nota1, nota2, media;

            //Entrada de dados.
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático
            media = nota1 + nota2;

            //Estrutura Condicional.
            if (media > 60.0) {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            
        }
    }
}
