using System.Globalization;

namespace System
{
    static class DateTimeExtensions
    {
        static public string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duraction = DateTime.Now - thisObj;

            if (duraction.TotalHours <= 24)
            {
                return duraction.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duraction.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
