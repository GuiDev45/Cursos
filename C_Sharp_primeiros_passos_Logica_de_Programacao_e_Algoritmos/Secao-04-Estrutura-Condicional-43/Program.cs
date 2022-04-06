using System;

namespace Secao_03_Estrutura_Condicional_43
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1042*/

            int menor = 0, medio = 0, maior = 0;

            string[] vet = Console.ReadLine().Split(' ');

            int num1 = int.Parse(vet[0]);
            int num2 = int.Parse(vet[1]);
            int num3 = int.Parse(vet[2]);

            if (num1 < num2 && num1 < num3 && num2 < num3) {
                menor = num1;
                medio = num2;
                maior = num3;
            } 
            else if (num1 < num2 && num1 < num3 && num2 > num3) {
                menor = num1;
                medio = num3;
                maior = num2;
            } 
            else if (num1 > num2 && num1 < num3 && num2 < num3) {
                menor = num2;
                medio = num1;
                maior = num3;
            } 
            else if (num1 > num2 && num1 > num3 && num2 < num3) {
                menor = num2;
                medio = num3;
                maior = num1;
            } 
            else if (num1 > num2 && num1 > num3 && num2 > num3) {
                menor = num3;
                medio = num2;
                maior = num1;
            } 
            else {
                menor = num3;
                medio = num1;
                maior = num2;
            }

            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);

            Console.WriteLine("");

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}
