using System;

namespace Secao_09_Aula_132_Exercicio_proposto_Enumeracoes_e_composicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
