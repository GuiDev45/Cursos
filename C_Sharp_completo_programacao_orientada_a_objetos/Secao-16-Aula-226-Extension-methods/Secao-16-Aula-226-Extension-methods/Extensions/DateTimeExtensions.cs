using System;
using System.Globalization;

namespace System//Pode dizer que essa classe é do System e não precisa usar o caminha do arquivo.
{
    static class DateTimeExtensions
    {
        //Até a onde eu entendi é uma função static.
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
