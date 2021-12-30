using System;
using System.Text;

namespace WeatherForecast
{
    public class WeeklyForecast
    {
        private DailyForecast[] weeklyForecast;

        public WeeklyForecast(DailyForecast[] weeklyForecast)
        {
            this.weeklyForecast = weeklyForecast;
        }

        public DailyForecast this[int index]
        {
            get { return this.weeklyForecast[index]; }
        }

        public double GetMaxTemperature()
        {
            DailyForecast maxTemperature = weeklyForecast[0];
            for (int i = 0; i < weeklyForecast.Length; i++)
            {
                if (weeklyForecast[i] > maxTemperature)
                {
                    maxTemperature = weeklyForecast[i];
                }
            }
            return maxTemperature.Temperature;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (DailyForecast day in weeklyForecast)
            {
                builder.Append($"{day.ToString()}\n");
            }
            return builder.ToString();
        }
    }
}
