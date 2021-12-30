using System;
using System.Text;

namespace WeatherForecast
{
    public class ForecastUtilities
    {
        public ForecastUtilities() { }

        // feels like temperature constants
        public const double c1 = -8.78469475556;
        public const double c2 = 1.61139411;
        public const double c3 = 2.33854883889;
        public const double c4 = -0.14611605;
        public const double c5 = -0.012308094;
        public const double c6 = -0.0164248277778;
        public const double c7 = 0.002211732;
        public const double c8 = 0.00072546;
        public const double c9 = -0.000003582;

        public static DailyForecast Parse(string dailyWeatherInput)
        {
            int day = int.Parse(dailyWeatherInput.Substring(0, 2));
            int month = int.Parse(dailyWeatherInput.Substring(3, 2));
            int year = int.Parse(dailyWeatherInput.Substring(6, 4));
            DateTime date = new DateTime(year, month, day);

            double temperature = double.Parse(dailyWeatherInput.Substring(20, 4));
            double windSpeed = double.Parse(dailyWeatherInput.Substring(25, 5));
            double humidity = double.Parse(dailyWeatherInput.Substring(31, 3));
            Weather forecast = new Weather(temperature, humidity, windSpeed);

            DailyForecast dailyForecast = new DailyForecast(date, forecast);
            return dailyForecast;
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            int max = 0;
            for (int i = 1; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > weathers[max].CalculateWindChill())
                {
                    max = i;
                }
            }
            return weathers[max];
        }

        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Weather day in weathers)
            {
                builder.Append(day.ToString() + "\n");
            }
            foreach (IPrinter printer in printers)
            {
                printer.Print(builder.ToString());
            }
        }
    }
}
