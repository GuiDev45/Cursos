﻿using System;
using Secao_09_Aula_131_Exercicios_resolvidos_02_StringBuilder.Entities;

namespace Secao_09_Aula_131_Exercicios_resolvidos_02_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to new Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.Comments.Add(c1);
            p1.Comments.Add(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.Comments.Add(c3);
            p2.Comments.Add(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}