using System;

namespace Secao_06_Aula_073_Modificadores_de_parametros_ref_e_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;

            Calculadora.Triplo(a, out triplo);
            Console.WriteLine(triplo);
        }
    }
}
