using Secao_10_Aula_145_Exercicio_resolvido.Entities.Enums;

namespace Secao_10_Aula_145_Exercicio_resolvido.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        //Como o método é abstrato, obrigatoriamente a classe também deve ser abstrata.
        public abstract double Area();
    }
}
