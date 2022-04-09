using System;

namespace Secao_05_Estruturas_Repetitivas_61
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1131*/

            int golInter = 0;
            int golGremio = 0;
            int decisao = 0;
            int pontoInter = 0;
            int pontoGremio = 0;
            int pontoGrenal = 0;
            int empate = 0;

            string[] vet = Console.ReadLine().Split(' ');
            golInter = int.Parse(vet[0]);
            golGremio = int.Parse(vet[1]);

            while (decisao != 2) {
                if (golInter > golGremio) {
                    pontoInter++;
                }
                else {
                    pontoGremio++;
                }

                if (golInter == golGremio) {
                    empate++;
                }

                pontoGrenal++;

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                decisao = int.Parse(Console.ReadLine());
                if (decisao != 2) {
                    vet = Console.ReadLine().Split(' ');
                    golInter = int.Parse(vet[0]);
                    golGremio = int.Parse(vet[1]);
                }
            }

            Console.WriteLine(pontoGrenal + " grenais");
            Console.WriteLine("Inter:" + pontoInter);
            Console.WriteLine("Gremio:" + pontoGremio);
            Console.WriteLine("Empates:" + empate);

            if (golInter > golGremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
