using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_204_Solucao_sem_interface_p1.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
