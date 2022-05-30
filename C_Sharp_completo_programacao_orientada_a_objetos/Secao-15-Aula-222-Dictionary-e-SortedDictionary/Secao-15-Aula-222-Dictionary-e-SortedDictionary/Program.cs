using System;
using System.Collections.Generic;

namespace Secao_15_Aula_222_Dictionary_e_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primeiro string é a chave e o segundo string é o valor.
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99999999";
            cookies["phone"] = "88888888";//Dictionary não aceita repetição, então ele vai sobreescrever o primeiro phone.

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES:");
            //poderia ser apenas var, no lugar de KeyValuePair <string, string>, é a mesma coisa.
            foreach (KeyValuePair <string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
