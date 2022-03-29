using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args){
            /*Funções Matemáticas*/

            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            
            //Math.sqrt = Raiz quadrada.
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);

            //Math.Pow = Potenciação
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);

            //Math.Abs = Valor Absoluto.
            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);

            //Incluindo funções em expressões maiores
            double delta = Math.Pow(B, 2.0) - 4 * A * C;
            double x1 = (- B + Math.Sqrt(delta)) / (2.0 * A);
            double x2 = (- B - Math.Sqrt(delta)) / (2.0 * A);
        }
    }
}
