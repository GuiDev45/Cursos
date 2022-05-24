using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_146_Exercicio_proposto.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}