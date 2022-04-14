using System;

namespace Secao_05_Estruturas_Repetitivas_85
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1099*/

            int N = int.Parse(Console.ReadLine());
            
            int X, Y, soma, maior, menor;
            string[] valor;

            for (int i = 1; i <= N; i++) {
                valor = Console.ReadLine().Split(' ');
                X = int.Parse(valor[0]);
                Y = int.Parse(valor[1]);

                if (X > Y) {
                    maior = X;
                    menor = Y;
                } 
                else {
                    maior = Y;
                    menor = X;
                }

                soma = 0;
                menor += 1;
                for (int c = menor; c < maior; c++) {
                    if (c % 2 != 0) {
                        soma += c;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
