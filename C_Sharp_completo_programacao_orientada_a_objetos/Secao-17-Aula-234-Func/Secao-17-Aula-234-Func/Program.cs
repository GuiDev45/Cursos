﻿using System;
using System.Collections.Generic;
using System.Linq;
using Secao_17_Aula_234_Func.Entities;

namespace Secao_17_Aula_234_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Func possui retorno.
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
