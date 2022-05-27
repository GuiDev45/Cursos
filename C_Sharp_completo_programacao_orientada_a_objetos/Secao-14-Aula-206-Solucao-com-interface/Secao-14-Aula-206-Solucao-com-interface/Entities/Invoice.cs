using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Secao_14_Aula_206_Solucao_com_interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        //Na verdade é uma propriedade da classe que foi implementado somente o get para o cálculo,
        //talvez se o pessoal enxergar que é uma propriedade e não uma função ajude a entende essa parte.

        //Outra discussão sobre isso: 
        //Qual é a diferença, bem como vantagens e desvantagens de utilizar a propriedade calculada,
        //que foi feito em "TotalPayment", com relação a se criar um método para retornar o resultado deste cálculo?
        //Tinha conhecimento de que era possível, porém até o momento estávamos utilizando apenas métodos pra fazer estes tipos de operações.

        //Resposta:
        //Essa é uma ótima pergunta e uma discussão que pode ser longa rs.
        //As duas principais razões pelas quais, na minha opinião, devemos preferir a property, são:
        //1) O valor é um cálculo realmente simples é impossível de gerar alguma exceção(erro).
        //2) O valor realmente significa uma propriedade do objeto.

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
