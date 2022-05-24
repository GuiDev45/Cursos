using Secao_10_Aula_145_Exercicio_resolvido.Entities.Enums;

namespace Secao_10_Aula_145_Exercicio_resolvido.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //É obrigatório ter o construtor da classe abstrata no caso a classe Color.
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        //Forma de declarar o método da classe abstrata Color, é só sobreescrever com o override.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
