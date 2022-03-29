using System;

namespace Secao_03_Estrutura_Sequencial_01
{
    class Program
    {
        static void Main(string[] args){
            /*Ler um texto até a quebra de linha e armazenar em uma variável
             *Ler três palavras, uma em cada linha, armazenando cada uma em uma variável
             *Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável*/

            //Console.WriteLine(); É a saída de dados.
            Console.WriteLine("Digite uma frase:");
            //Console.ReadLine(); É a entrada de dados.
            string frase = Console.ReadLine();

            Console.WriteLine("Digite mais três palavras:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Digite as três palavras do vetor:");
            //Comando Split: Ele consegue recortar a string passando o parâmetro que precise ser usado como argumento, no caso vai quebrar a linha onde tiver espaço.
            string[] vet = Console.ReadLine().Split(' ');
            //As três palavras digitadas vão ser armazenadas nessas posições do vetor.
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Saída do vetor:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}
