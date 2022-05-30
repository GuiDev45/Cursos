using System;
using System.Collections.Generic;

namespace Secao_15_Aula_218_HashSet_e_SortedSet_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //Chamando a função
            PrintCollection(a);
            //Saída - 0 2 4 5 6 8 10

            //union
            //Criando um conjunto c, e inserindo todos os elementos do conunto a dentro de c
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);//UnionWith, agora está unindo o c com o b.
                           //OBS todos os elementos que o c não tiver ele vai pegar de b, mas os iguais não se repetem.
            PrintCollection(c);
            //Saída - 0 2 4 5 6 7 8 9 10

            //insersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);//É uma interseção, a saída vai ser os elementos iguais de a e b.
            PrintCollection(d);
            //Saída - 5 6 8 10

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);//São os elementos de a excluindo os elementos iguais que tinha no conjunto b.
            PrintCollection(e);
            //Saída - 0 2 4
        }

        //Função auxiliar para imprimir o conjunto
        //IEnumerable é tipo o Iterator do Java, é uma interface do Collections para percorrer a coleção.
        static void PrintCollection<T>(IEnumerable<T> collection)//É do tipo generics então aceita imprimir qualquer tipo de coleção.
        {
            foreach (T obj in collection)//Sempre usar o foreach para percorrer a coleção.
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        } 
    }
}
