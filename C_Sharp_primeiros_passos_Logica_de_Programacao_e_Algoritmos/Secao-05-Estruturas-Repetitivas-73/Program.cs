using System;

namespace Secao_05_Estruturas_Repetitivas_73
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1097*/

            int num1 = 7;
            int num2 = 6;
            int num3 = 5;

            for (int i = 1; i < 10; i++) {
                Console.WriteLine("I=" + i + " " + "J=" + num1);
                Console.WriteLine("I=" + i + " " + "J=" + num2);
                Console.WriteLine("I=" + i + " " + "J=" + num3);
                i++;
                num1 += 2;
                num2 += 2;
                num3 += 2;
            }
        }
    }
}
