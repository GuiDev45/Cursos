using System;

namespace Secao_03_Estrutura_Condicional_28
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1035*/

            //Declaração das variáveis.
            int A, B, C, D;

            //Declaração do vetor com entrada de dados e Split para ter o recorte cada vez que tiver espaço digitado.
            string[] vet = Console.ReadLine().Split(' ');

            //Variáveis recebendo a entrada de dados em suas respectivas posições. (Que o Split recortou devido cada espaço digitado).
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            //Estrutura Condicional.
            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0) {
                Console.WriteLine("Valores aceitos");
            }
            else {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
