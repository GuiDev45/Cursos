using System;
using System.Globalization;

namespace Secao_04_Aula_42_Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();//Criando o objeto e instanciando a classe.

            Console.WriteLine("Entre a largura e altura do retângulo:");
            //Usando o objeto retangulo criado, para invocar o atributo Largura.
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Como está dentro de um Console.Write, ele entende o ToString que está na classe Retangulo
            Console.WriteLine(retangulo);
        }
    }
}
