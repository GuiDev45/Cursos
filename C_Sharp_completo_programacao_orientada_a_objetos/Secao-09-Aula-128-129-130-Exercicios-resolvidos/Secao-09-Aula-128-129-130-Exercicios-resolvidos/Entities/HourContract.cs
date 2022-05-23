using System;

namespace Secao_09_Aula_128_129_130_Exercicios_resolvidos.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()//Método para resolver o valor total das horas trabalhadas.
        {
            return Hours * ValuePerHour;
        }
    }
}
