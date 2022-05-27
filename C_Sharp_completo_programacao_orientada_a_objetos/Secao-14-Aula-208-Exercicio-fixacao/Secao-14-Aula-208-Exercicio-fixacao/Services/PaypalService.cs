using Secao_14_Aula_208_Exercicio_fixacao.Services;

namespace Secao_14_Aula_208_Exercicio_fixacao.Services
{
    internal class PaypalService : IOnlinePaymentService
    {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}