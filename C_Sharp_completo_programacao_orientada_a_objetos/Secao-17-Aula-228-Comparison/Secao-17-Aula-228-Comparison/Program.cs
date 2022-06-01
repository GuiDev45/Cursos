using System;
using System.Globalization;
using System.Collections.Generic;
using Secao_17_Aula_228_Comparison.Entities;

namespace Secao_17_Aula_228_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Usando o método/função no argumento do Sort
            //Dessa forma vai ordenar os produtos por nome, não necessitando fazer o IComparable na classe Product.
            //Essa forma se chama delegate.
            list.Sort(CompareProducts);

            //OUTRA FORMA COM LAMBDA
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //OUTRA FORMA COM LAMBDA DENTRO DO .Sort
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //Método auxiliar que compara 2 produtos, false se forem diferentes e true se forem iguais.
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
