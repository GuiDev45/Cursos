using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_206_Solucao_com_interface.Services
{
    //Agora BrazilTaxService é um sub tipo de ITaxService.
    internal class BrazilTaxService : ITtaxService //declaração igual de herança, porém não é herança
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
