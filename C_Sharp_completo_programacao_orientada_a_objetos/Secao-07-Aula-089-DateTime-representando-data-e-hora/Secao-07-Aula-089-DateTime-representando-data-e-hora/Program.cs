using System;
using System.Globalization;

namespace Secao_07_Aula_089_DateTime_representando_data_e_hora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mostra a hora atual do sistema que você está.
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            //Essa é a forma como a hora é armazenada - "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum.
            Console.WriteLine(d1.Ticks);

            //Construtores mais usados.
            //Especifica o tempo que está dentro dos parênteses.
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);//Com horas minutos e segundos.
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //Vai te dar a data atual, porém com as horas zeradas.
            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);

            //Retorna o horário GMT/horário universal 
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d5);

            //Vai converter pra 15/08/2000, muito bancos de dados usam o formato 2000-08-15
            DateTime d6 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d6);
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:22");//É possivel fazer com o horário também.
            Console.WriteLine(d7);

            //Outro tipo de formatação.
            DateTime d8 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d8);
            DateTime d9 = DateTime.Parse("15/08/2000 13:05:22");
            Console.WriteLine(d9);

            //Basicamente é uma máscara de formatação
            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d10);
            DateTime d11 = DateTime.ParseExact("15/08/2000 13:05:22", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);

        }
    }
}
