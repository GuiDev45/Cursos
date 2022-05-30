using System;

namespace Secao_15_Aula_216_GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            //Equals é mais lento porém é 100% de chance da comparação nunca dar errada.
            Console.WriteLine(a.Equals(b));//é possível invocar o .Equals porque ele faz "parte" do string.
            //Saída false, o nome Maria não é igual o nome Alex.

            //HasCode é mais rápido para comparar porém de vez em nunca essa comparação pode dar errada,
            //Exemplo: Maria com Maria - -1033252024, 4593850239
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            //Saída -1033252024
            //      -862768602
            //o HashCode retornou os números de acordo com a regra dele mostrando que a e b não são iguais.

            //Fazer a busca usando o HashCode e para ter a certeza compara com o Equals
        }
    }
}
