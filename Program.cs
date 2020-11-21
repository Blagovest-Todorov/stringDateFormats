using System;
using System.Threading;
using System.Globalization;

namespace _06.DateFormats
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = "25.10.2020";
            DateTime date = DateTime.ParseExact(dateStr,"dd.MM.yyyy",
                            CultureInfo.InvariantCulture);
            Console.WriteLine(date);

            DateTime parsed = DateTime.ParseExact("17.02.15","dd.MM.yy", CultureInfo.InvariantCulture);
            //not to comply with ani culture, parse in this way ordered into the method !!!
            Console.WriteLine(parsed.DayOfYear);
        }
    }
}
