using System;
using System.IO;

namespace Secao_13_Aula_198_StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-198-StreamWriter\file1.txt";
            string targetPath = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-198-StreamWriter\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
