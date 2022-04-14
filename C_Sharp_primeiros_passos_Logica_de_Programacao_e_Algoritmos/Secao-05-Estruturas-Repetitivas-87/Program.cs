using System;

namespace Secao_05_Estruturas_Repetitivas_87
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1145*/

            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            int cont = 1;

            if (X >= 1 && X <= 20) {
                if (Y > X) {
                    while (Y >= cont) {                        
                        for (int i = 1; i <= X; i++) {
                            if (cont <= Y && i < X) {
                                Console.Write(cont + " ");
                                cont++;
                            } 
                            else if (cont <= Y && i == X) {
                                Console.WriteLine(cont);
                                cont++;
                            }
                        }
                    }
                }
            }
        }
    }
}
