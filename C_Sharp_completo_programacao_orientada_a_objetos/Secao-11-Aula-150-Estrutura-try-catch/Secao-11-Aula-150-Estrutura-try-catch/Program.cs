using System;

namespace Secao_11_Aula_150_Estrutura_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            //Se dividr por 0 vai quebrar o programa,
            //e já existe uma exceção para isso então o try vai tentar rodar o primeiro bloco de código e o catch vai pegar caso essa exceção ocorra,
            //imprimindo a mensagem de erro, essa mensagem é a mensagem padrão da exceção.
        }
    }
}