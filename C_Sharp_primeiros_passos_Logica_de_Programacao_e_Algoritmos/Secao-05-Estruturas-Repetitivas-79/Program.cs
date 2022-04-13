using System;

namespace Secao_05_Estruturas_Repetitivas_79
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1144*/

            int m1, m2;
            
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                m1 = (int)Math.Pow(i, 2);
                m2 = m1 * i;

                Console.Write(i + " ");
                Console.Write(m1 + " ");
                Console.WriteLine(m2);
                Console.Write(i + " ");

                m1++;
                m2++;

                Console.Write(m1 + " ");
                Console.WriteLine(m2);
            }
        }
    }
}
