using System;

namespace Secao_03_Estrutura_Condicional_35
{
    class Program
    {
        static void Main(string[] args){

            

            string[] horario = Console.ReadLine().Split(' ');
            /*URI online judge Extremamente Básico 1046*/

            int horaInicial = int.Parse(horario[0]);
            int horaFinal = int.Parse(horario[1]);
            int calculoHoraInicial, calculoHoraFinal, calculoTempoEvento = 0;

            if (horaFinal < horaInicial) {
                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;
            }

            if (horaFinal == horaInicial) {
                calculoTempoEvento = 24;
            }

            if (horaFinal > horaInicial) {
                calculoHoraInicial = 24 - horaInicial;
                calculoHoraFinal = horaFinal - 24;
                calculoTempoEvento = calculoHoraInicial + calculoHoraFinal;
            }

            Console.WriteLine("O JOGO DUROU " + calculoTempoEvento + " HORA(S)");
        }
    }
}
