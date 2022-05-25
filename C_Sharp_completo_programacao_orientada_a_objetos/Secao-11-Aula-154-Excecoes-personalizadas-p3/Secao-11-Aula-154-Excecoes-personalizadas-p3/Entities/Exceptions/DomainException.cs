using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_11_Aula_154_Excecoes_personalizadas_p3.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}