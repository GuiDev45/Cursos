using System;

namespace Secao_06_Aula_072_Modificador_de_parametros_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(2, 3);//Pelo modificador params que está na classe Calculadora, não precisa instanciar o vetor com new int[], 
            int s2 = Calculadora.Soma(2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
