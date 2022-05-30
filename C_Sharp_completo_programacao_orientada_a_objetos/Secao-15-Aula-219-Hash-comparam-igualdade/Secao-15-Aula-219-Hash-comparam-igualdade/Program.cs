using System;
using System.Collections.Generic;

namespace Secao_15_Aula_219_Hash_comparam_igualdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Maria"));
            //Se o GetHashCode e Equals estiverem implementados:
            //primeiro GetHashCode.Se der igual, usa Equals para confirmar

            //Se GetHashCode e Equals NÃO estiverem implementados:
            //tipos referência: compara as referências dos objetos/referências de memória, ponteiro...
            //tipos valor: comparar os valores dos atributos
        }
    }
}
