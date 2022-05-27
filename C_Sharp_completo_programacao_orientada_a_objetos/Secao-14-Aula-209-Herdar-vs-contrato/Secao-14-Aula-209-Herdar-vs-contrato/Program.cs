using System;
using Secao_14_Aula_209_Herdar_vs_contrato.Model.Entities;
using Secao_14_Aula_209_Herdar_vs_contrato.Model.Enums;

namespace Secao_14_Aula_209_Herdar_vs_contrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}