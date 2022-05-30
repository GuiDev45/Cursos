using System;
using System.Collections.Generic;

namespace Secao_15_Aula_217_HashSet_e_SortedSet_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();//Conjunto instanciado.

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            //Contém Nootbook nesse conjunto ? se sim retorna true, se não false.
            Console.WriteLine(set.Contains("Notebook"));

            //lembrando que não existe acessar a posição no conjunto, set[i]...
            //para cada string s em set...
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
            //Saída
            //TV
            //Notebook
            //Tablet
        }
    }
}
