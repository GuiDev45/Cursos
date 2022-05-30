using System;
using Secao_15_Aula_216_GetHashCode_e_Equals_p2.Entities;

namespace Secao_15_Aula_216_GetHashCode_e_Equals_p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));//É o mesmo que perguntar pro Equals, a é igual b ?
            //Saída False.

            //Porém se o Alex tivesse o mesmo Email de maria, acusaria que os dois são iguais,
            //porque o Equals e o HashCode em Client está comparando pelo atributo Email.
            Client c = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(c));//É o mesmo que perguntar pro Equals, a é igual b ?
            //Saída True.

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            //Saída -1195778599, a tem o mesmo email que o c.
            //      2111068095
            //      -1195778599

            Console.WriteLine(a == b);
            //Saída False, por o == é a referência do ponteiro,
            //então vai ser false, não é se o a é igual b objeto, == é a referência do ponteiro.
            //Uma coisa é comparar referência de memória, outra coisa é comparar conteúdo.
        }
    }
}
