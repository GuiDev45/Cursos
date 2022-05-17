using System;
using System.Globalization;

namespace Secao_04_Aula_42_Exercicio_01
{
    internal class Retangulo
    {
        public double Largura;//Por padrão do C# os atributos começam com letra maiúscula.
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()//Não tem parâmetro de entrada, então os parênteses ficam vazios.
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()//Por padrão do C# os métodos começam com letra maiúscula.
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        //public, override para sobrescrever, do tipo string, e basta apenas o return para começar a concatenar.
        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n"
            + $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}