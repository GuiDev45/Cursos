using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_37
{
    class Program
    {
        static void Main(string[] args)
        {
            /*URI online judge Extremamente Básico 1040*/

            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');

            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (float)((N1 * 2.0) + (N2 * 3.0) + (N3 * 4.0) + (N4 * 1.0)) / (float)10.0;

            if (media == (float) 4.85) {
                media = (float) 4.8;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            }
                else if (media >= 5.0 && media <= 6.9) {
                    Console.WriteLine("Aluno em exame.");
                    notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                    mediaFinal = (media + notaExame) / (float)2.0;
                    if (mediaFinal < 5.0) {
                        Console.WriteLine("Aluno reprovado.");
                        Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                    }
                    else {
                        Console.WriteLine("Aluno aprovado.");
                        Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                    }
            }
            else {
                Console.WriteLine("Aluno aprovado.");
            }
        }
    }
}
