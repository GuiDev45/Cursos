using System;

namespace Secao_03_Estrutura_Condicional_41
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1049*/

            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado" && palavra2 == "ave") {
                if (palavra3 == "carnivoro") {
                    Console.WriteLine("aguia");
                }
                else if (palavra3 == "onivoro") {
                    Console.WriteLine("pomba");
                }
            }
            if (palavra1 == "vertebrado" && palavra2 == "mamifero") {
                if (palavra3 == "onivoro") {
                    Console.WriteLine("homem");
                }
                else if (palavra3 == "herbivoro") {
                    Console.WriteLine("vaca");
                }
            }

            if (palavra1 == "invertebrado" && palavra2 == "inseto") {
                if (palavra3 == "hematofago") {
                    Console.WriteLine("pulga");
                }
                else if (palavra3 == "herbivoro") {
                    Console.WriteLine("lagarta");
                }
            }
            if (palavra1 == "invertebrado" && palavra2 == "anelideo") {
                if (palavra3 == "hematofago") {
                    Console.WriteLine("sanguessuga");
                }
                else if (palavra3 == "onivoro") {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}
