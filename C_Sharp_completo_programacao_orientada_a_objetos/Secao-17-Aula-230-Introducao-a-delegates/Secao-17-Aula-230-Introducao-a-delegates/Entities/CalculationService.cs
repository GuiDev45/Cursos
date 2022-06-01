
namespace Secao_17_Aula_230_Introducao_a_delegates.Entities
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x)
        {
            return x * x;
        }
    }
}