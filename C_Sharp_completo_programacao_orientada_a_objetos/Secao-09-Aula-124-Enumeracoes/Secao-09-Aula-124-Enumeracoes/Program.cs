using Secao_09_Aula_124_Enumeracoes.Entities;//Lembrar de chamar onde está a pasta.
using Secao_09_Aula_124_Enumeracoes.Entities.Enums;//Lembrar de chamar onde está a pasta.
using System;

namespace Secao_09_Aula_124_Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Convertendo para string.
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);//Saída PendingPayment

            //Convertendo o tipo enumerado para string.
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);//Saída Delivered, obs: tem que estar igual ao texto do enum.
        }
    }
}
