using System;
using System.Globalization;
using Secao_14_Aula_209_Herdar_vs_contrato.Model.Entities;
using System.Text;

namespace Secao_14_Aula_209_Herdar_vs_contrato.Model.Entities
{
    internal class Circle : AbstractShape
    {

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}