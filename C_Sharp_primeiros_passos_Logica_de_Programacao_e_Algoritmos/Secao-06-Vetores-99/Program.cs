using System;
using System.Globalization;

namespace Secao_06_Vetores_99
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            8) Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. 
            Fazer um programa que calcule e escreva:
            - a maior e a menor altura do grupo
            - a média de altura das mulheres
            - o número de homens
            Exemplo:
            Entrada                                 Saída
            5                                       Menor altura = 1.54
            1.70 F                                  Maior altura = 1.83
            1.83 M                                  Media das alturas das mulheres = 1.69
            1.54 M                                  Numero de homens = 2
            1.61 F
            1.75 F
            */

            Console.Write("Quantas pessoas vão ser digitadas ?: ");
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            double menorAltura = altura[0];
            for (int i = 1; i < N; i++) {
                if (altura[i] < menorAltura) {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            double maiorAltura = altura[0];
            for (int i = 1; i < N; i++) {
                if (altura[i] > maiorAltura) {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < N; i++) {
                if (sexo[i] == 'F') {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + altura[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0) {
                Console.WriteLine("Nao há nenhuma mulher dentre as pessoas");
            }
            else {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Média das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

            int contHomens = 0;
            for (int i = 0; i < N; i++) {
                if (sexo[i] == 'M') {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);

        }
    }
}
