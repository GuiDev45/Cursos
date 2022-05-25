using System;

namespace Secao_11_Aula_155_Exercicio_proposto.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}