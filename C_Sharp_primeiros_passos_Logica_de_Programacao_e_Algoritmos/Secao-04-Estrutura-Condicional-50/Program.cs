using System;

namespace Secao_03_Estrutura_Condicional_50
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1066*/

            int num, pares, impares, positivos, negativos;

            int pares = 0, impares = 0, positivos = 0, negativos = 0;

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                pares++;
            }
            else {
                impares++;
            }
            if (num > 0) {
                positivos++;
            }
            else if (num < 0) {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");
        }
    }
}
