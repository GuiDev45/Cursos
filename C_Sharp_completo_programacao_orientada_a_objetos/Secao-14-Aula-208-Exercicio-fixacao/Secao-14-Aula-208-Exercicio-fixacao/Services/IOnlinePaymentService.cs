
namespace Secao_14_Aula_208_Exercicio_fixacao.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}