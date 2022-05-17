namespace Secao_04_Aula_048_Exercicio_01
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;//É static porque essa porcentagem de iof nunca vai mudar.

        //É static porque os cálculos não vão mudar, 
        //apenas as entradas para os cálculos vão ser diferentes.
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}