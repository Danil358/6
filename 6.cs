using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema6
{
    internal class Program
    {

public class DateTimeParsingExample
        {
            public static void Main(string[] args)
            {
                string dateString1 = "2024-03-15";
                string dateString2 = "15.03.2024";
                string dateString3 = "March 15, 2024";
                string dateTimeString = "2024-03-15 14:30:00";

                DateTime date1 = DateTime.Parse(dateString1);
                Console.WriteLine($"Parse(\"{dateString1}\"): {date1}");
                
                DateTime date2 = DateTime.ParseExact(dateString2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine($"ParseExact(\"{dateString2}\"): {date2}");
 
                DateTime date3;
                if (DateTime.TryParse(dateString3, out date3))
                {
                    Console.WriteLine($"TryParse(\"{dateString3}\"): {date3}");
                }
                else
                {
                    Console.WriteLine($"TryParse(\"{dateString3}\"): Не удалось разобрать дату.");
                }
 
                DateTime date4;
                if (DateTime.TryParseExact(dateString3, "MMMM dd, yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date4))
                {
                    Console.WriteLine($"TryParseExact(\"{dateString3}\"): {date4}");
                }
                else
                {
                    Console.WriteLine($"TryParseExact(\"{dateString3}\"): Не удалось разобрать дату.");
                }
                
                DateTime dateTime;
                if (DateTime.TryParseExact(dateTimeString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                {
                    Console.WriteLine($"TryParseExact(\"{dateTimeString}\"): {dateTime}");
                }
                else
                {
                    Console.WriteLine($"Не удалось разобрать дату и время.");
                }
            }
        }


    }
}
