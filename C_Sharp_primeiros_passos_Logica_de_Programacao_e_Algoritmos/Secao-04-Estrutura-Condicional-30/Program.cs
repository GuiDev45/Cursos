using System;

namespace Secao_03_Estrutura_Condicional_30
{
    class Program
    {
        static void Main(string[] args){
            //Declaração das variáveis.
            int num1, num2, num3;

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet = Console.ReadLine().Split();

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            //Estrutura Condicional.
            if (num1 <= num2 && num1 <= num3) {
                Console.WriteLine("MENOR = " + num1);
            }
            else if (num2 <= num3) {
                Console.WriteLine("MENOR = " + num2);
            }
            else {
                Console.WriteLine("MENOR = " + num3);
            }
        }
    }
}
