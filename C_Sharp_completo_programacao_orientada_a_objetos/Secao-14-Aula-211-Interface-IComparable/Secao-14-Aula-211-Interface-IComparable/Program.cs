using System;
using System.IO;
using System.Collections.Generic;
using Secao_14_Aula_211_Interface_IComparable.Entities;

namespace Secao_14_Aula_211_Interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-14-Aula-211-Interface-IComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();//Sort(), ordena a lista, precisa do IComparable.
                    //Não tem como ordenar essa lista sem comparar um funcionario/Employee com outro, por isso a necessidade do IComparable
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
