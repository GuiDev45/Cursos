using System;
//Apenas com o System já é possivel fazer a instância

namespace Secao_16_Aula_226_Extension_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
