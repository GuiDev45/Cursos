using System;
using Secao_10_Aula_145_Exercicio_resolvido.Entities.Enums;

namespace Secao_10_Aula_145_Exercicio_resolvido.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
