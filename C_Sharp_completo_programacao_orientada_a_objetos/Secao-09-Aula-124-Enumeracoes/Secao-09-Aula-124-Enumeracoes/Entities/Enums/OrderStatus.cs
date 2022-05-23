
namespace Secao_09_Aula_124_Enumeracoes.Entities.Enums
{
    internal enum OrderStatus : int // : int, o tipo de enum do OrderStatus vai ser int.
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
