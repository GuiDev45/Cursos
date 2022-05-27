using System;
using System.Collections.Generic;
using System.Text;
using Secao_14_Aula_206_Solucao_com_interface.Entities;

namespace Secao_14_Aula_206_Solucao_com_interface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Ou seja, vai esperar o serviço de um construtor qualquer, seja a taxa brasileira ou alguma regra de taxa de outro pais.
        private ITtaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITtaxService taxService)//é passado no construtor...
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);//Math.Ceiling arredonda para cima.
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
