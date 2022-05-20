using System;

namespace Secao_07_Aula_085_palavra_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var vai tomar um tipo dependendo o que foi sua entrada, no caso 10, var vai assumir int.
            var x = 10;

            //mesmo esquema, o compilador vai assumir que var vai ser double, porque está recebendo 20.0.
            var y = 20.0;

            //....
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //Mas cuidado com o var, dependendo da falta de atenção fazer a variável y(double) receber z(string), vai ser aceito, não vai acusar erro mas está errado.
        }
    }
}
