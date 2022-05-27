using Secao_14_Aula_209_Herdar_vs_contrato.Model.Enums;

namespace Secao_14_Aula_209_Herdar_vs_contrato.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}