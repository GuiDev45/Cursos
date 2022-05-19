using System;

namespace Secao_06_Aula_068_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //? significa que é opcional, double pode ser null.
            double? x = null;
            double? y = 10.0;

            //Esse método significa, Pega o valor de x ou se esse valor não existir pega o seu valor padrão, como o valor padrão de double é 0, vai imprimir 0.
            Console.WriteLine(x.GetValueOrDefault());
            //No caso do y, vai imprimir o valor de 10, pois a variável tem valor, se não tem valor ele pega o padrão do tipo, no caso double 0.
            Console.WriteLine(y.GetValueOrDefault());

            //Esse método pergunta se a variável tem valor ou não.
            Console.WriteLine(x.HasValue);//Saída false, x não tem valor.
            Console.WriteLine(y.HasValue);//Saída true, y tem valor.

            //Se não tivesse esse if, a aplicação ia quebrar, o Value não aceita nulo e manda uma exceção.
            //if x.Tem valor ? se não (x é nulo).
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x é nulo");
            }
            
            //y tem valor, então a saída é normal.
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y é nulo");
            }

            //OPERADOR DE COALESCÊNCIA NULA.

            double? x1 = null;
            double? y1 = 10;

            //Esses ?? significa que, o a vai receber o x1 e se x1 for nulo, então vai receber o 5, i nesni para a variável b.
            double a = x1 ?? 5;
            double b = y1 ?? 5;

            Console.WriteLine(a);//Saída 5, porque o x1 é nulo.
            Console.WriteLine(b);//Saída 10, porque y1 recebeu o valor de 10.
        }
    }
}
