using System;
using System.Globalization; //É necessário para usar o CultureInfo.InvariantCulture.

namespace Secao_03_Estrutura_Sequencial_02
{
    class Program
    {
        static void Main(string[] args){
            /*Ler um número inteiro.
             *Ler um caractere.
             *Ler um número double.
             *Ler um nome (única palavra), sexo (caractere F ou M), 
             idade (inteiro) e altura (double) na mesma linha, 
             armazenando-os em quatro variáveis com os devidos tipos.*/

            Console.WriteLine("Digite um número inteiro");
            //Essa é a forma de entrada de dados de outro tipo que não seja string, tem que converter com o .Parse, passando o Console.ReadLine() como argumento.
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Número int digitado: " + n1);

            Console.WriteLine("Digite um caractere:");
            //Para entrada de dados em char é o mesmo esquema do exemplo acima.
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Caractere digitado: " + ch);

            Console.WriteLine("Digite um número flutuante");
            //CultureInfo.InvariantCulture, serve para altera a vírgula pelo ponto.
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Para a saída de dados com o ponto (.) é necessário usar o 
            .ToString passando o "Placeholder" que é o "F2 duas casas decimais" e o CultureInfo.InvariantCulture como o argumento do .ToString*/
            Console.WriteLine("Número double digitado: " + n2.ToString("F2", CultureInfo.InvariantCulture));

            //Lembrando que o .Split vai recortar a string a partir do argumento dela, no caso vai quebrar a linha após o espaço.
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            //char.Parse é o casting, já que o vetor é do tipo string.
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
