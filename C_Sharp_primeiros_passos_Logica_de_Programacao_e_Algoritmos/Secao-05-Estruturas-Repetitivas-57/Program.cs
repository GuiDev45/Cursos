using System;

namespace Secao_05_Estruturas_Repetitivas_57
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1134*/

            int alcool = 0, gasolina = 0, diesel = 0;

            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4) {
                switch (codigo) {
                    case 1:
                        alcool++;
                    break;
                    case 2:
                        gasolina++;
                    break;
                    case 3:
                        diesel++;
                    break;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
