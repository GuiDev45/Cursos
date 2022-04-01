using System;

namespace Secao_03_Estrutura_Sequencial_18
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1013*/

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            //Estrutura Condicional para decidir o maior elemento digitado.
            if(A > B && A > C) {
                Console.WriteLine(A + " eh o maior");
            }
            else if(B > C) {
                Console.WriteLine(B + " eh o maior");
            }
            else{
                Console.WriteLine(C + " eh o maior");
            }
        }
    }
}
