using System;
using Secao_09_Aula_124_Enumeracoes.Entities.Enums;//Lembrar de chamar onde está a pasta.

namespace Secao_09_Aula_124_Enumeracoes.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
