using System;
using System.IO;

namespace Secao_13_Aula_196_FileStream_e_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-196-FileStream-e-StreamReader\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}
