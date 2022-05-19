using System;
using System.Collections.Generic;

namespace Secao_06_Aula_077_List_parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            //Add - adiciona valores na lista, o Add adiciona ao final da lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            //Insert - adiciona valores na lista, porém o Insert da a chance de escolhar a posição a onde vai o valor, no caso posição 2 da lista.
            list.Insert(2, "Marco");

            //Laço foreach normal, para cada obj em list faça x.
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //Count - mostra qual o tamanho da lista.
            Console.WriteLine("Tamanho da lista: " + list.Count);

            Console.WriteLine();

            //Find - Encontra o primeiro elemento de uma lista que satisfaça um predicado, OBS não precisa da função bool/Test, pode ser criada uma expressão lambda.
            string s1 = list.Find(Test);
            Console.WriteLine("Primeiro nome que começa com a letra 'A': " + s1);

            //Find - Expressão lambda.
            //É a mesa função do Test só que em expressão lambda, basicamente uma forma resumida.
            string s2 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro: " + s2);

            //FindLast - é o mesmo que o Find, porém vai pegar o último nome.
            string s3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Último: " + s3);

            Console.WriteLine();

            //FindIndex - acha o primeiro valor pela POSIÇÃO.
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("A primeira posição que comece com a letra 'A': " + pos1);

            //FindIndex - acha o último valor pela POSIÇÃO.
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("A última posição que comece com a letra 'A': " + pos2);

            Console.WriteLine();

            //Essa lista vai guardar o resultado do "filtro".
            List<string> list2 = list.FindAll(x => x.Length == 5);//Todo string que tiver 5 caracteres vai ser guardado nessa nova lista.
            //Imprimindo os valores da list2 com o laço foreach
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //Remove - remove o elemendo da lista.
            //Obs: se o nome não existir o remove simplismente não faz nada.
            list.Remove("Zorro");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //RemoveAll - remove todos os elementos de acordo com o lambda criado.
            list.RemoveAll(x => x[0] == 'M');//Todo elemento que tiver a inicial M vai ser removido.

            //RemoveAt - remove o elemento na posição que foi passada, no caso o que estiver na posição 2 será removido.
            list.RemoveAt(2);

            //RemoveRange - remove apartir de uma posição, apartir da posição 2 quero remover 2 elementos, basicamente é isso.
            list.RemoveRange(2, 2);
        }

        //Find - Se esse teste for verdadeiro então vai imprimir. s[0] porque como é uma cadeia de caractere o primeiro caractere está na posição 0.
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
