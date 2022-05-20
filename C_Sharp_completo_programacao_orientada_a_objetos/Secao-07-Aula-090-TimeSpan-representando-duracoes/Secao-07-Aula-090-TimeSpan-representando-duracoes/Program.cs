using System;

namespace Secao_07_Aula_090_TimeSpan_representando_duracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //É o tempo em horas minutos em segundos, a saída fica 00:01:30
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan();//Com o construtor vazio 00:00:00
            Console.WriteLine(t2);

            //1 dia, 2 horas, 11 minutos, 21 segundos.
            TimeSpan t3 = new TimeSpan(1, 2, 11, 21);//Saída 1.02:11:21
            Console.WriteLine(t3);

            //1 dia, 2 horas, 11 minutos, 21 segundos, 321 milissegundos.
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t4);

            //1 dia e meio.5
            TimeSpan t5 = TimeSpan.FromDays(1.5);//Saída 1.12:00:00
            Console.WriteLine(t5);

            //1 hora e meia.5
            TimeSpan t6 = TimeSpan.FromHours(1.5);//Saída 01:30:00
            Console.WriteLine(t6);

            //1 minuto e meio.5
            TimeSpan t7 = TimeSpan.FromMinutes(1.5);//Saída 00:01:30
            Console.WriteLine(t7);

            //1 segundo e meio.5
            TimeSpan t8 = TimeSpan.FromSeconds(1.5);//Saída 00:00:01.5000000
            Console.WriteLine(t8);

            //O mesmo vai acontecer com seconds e com milliseconds.
        }
    }
}
