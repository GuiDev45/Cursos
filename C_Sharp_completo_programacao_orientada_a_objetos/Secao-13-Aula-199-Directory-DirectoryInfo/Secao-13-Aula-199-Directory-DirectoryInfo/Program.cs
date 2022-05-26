using System;
using System.IO;

namespace Secao_13_Aula_199_Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-199-Directory-DirectoryInfo\myfolder";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-Aula-199-Directory-DirectoryInfo\myfolder\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
