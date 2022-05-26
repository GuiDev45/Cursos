using System;
using System.IO;

namespace Secao_13_File_fileInfo_e_IOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sourcePath é o caminho do arquivo de origem,
            string sourcePath = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-File-fileInfo-e-IOException\file1.txt";

            string targetPath = @"C:\workspaces\ws-vs2022-cSharp\C-Sharp-Curso-Completo\Secao-13-File-fileInfo-e-IOException\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);//Copiou o arquivo txt que o sourcePath pegou.
                string[] lines = File.ReadAllLines(sourcePath);//Vai ler todas as linhas do arquivo e guardar dentro do vetor.
                foreach (string line in lines)
                {
                    Console.WriteLine(line);//Vai imprimir as linhas que está no arquivo txt.
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");//Se já existir a cópia desse arquivo vai acusar a exceção.
                Console.WriteLine(e.Message);
            }
        }
    }
}
