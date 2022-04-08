using System;

namespace Secao_05_Estruturas_Repetitivas_54
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1114*/

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
