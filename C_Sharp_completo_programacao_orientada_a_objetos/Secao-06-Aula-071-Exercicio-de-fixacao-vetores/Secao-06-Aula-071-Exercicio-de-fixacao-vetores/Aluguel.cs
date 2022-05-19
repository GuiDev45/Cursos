using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_06_Aula_071_Exercicio_de_fixacao_vetores
{
    internal class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Aluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
