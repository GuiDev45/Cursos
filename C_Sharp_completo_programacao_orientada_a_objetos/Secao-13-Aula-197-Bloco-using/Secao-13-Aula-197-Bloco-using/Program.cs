using System;
using System.IO;

namespace Secao_13_Aula_197_Bloco_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-197-Bloco-using\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
