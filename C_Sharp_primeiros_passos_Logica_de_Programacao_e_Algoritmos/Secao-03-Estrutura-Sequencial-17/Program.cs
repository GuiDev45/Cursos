using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_17
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1012*/

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Cálculo matemático das áreas.
            double areaTriangulo = A * C / 2.0;
            double areaCirculo = C * C * 3.14159;
            double areaTrapezio = (A + B) / 2.0 * C;
            double areaQuadrado = Math.Pow(B, 2.0);
            double areaRetangulo = A * B;

            //Saída de dados com três casas decimais.
            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
