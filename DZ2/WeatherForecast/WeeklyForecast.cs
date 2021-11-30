using System;
using System.Collections.Generic;
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
            for (int i = 0; i < 7; i++)
            {
                if (weeklyForecast[i] > maxTemperature)
                {
                    maxTemperature = weeklyForecast[i];
                }
            }
            return maxTemperature.Temperature;
        }

        public string GetAsString()
        {
            return $"{weeklyForecast[0].GetAsString()}\n{weeklyForecast[1].GetAsString()}\n{weeklyForecast[2].GetAsString()}\n{weeklyForecast[3].GetAsString()}\n{weeklyForecast[4].GetAsString()}\n{weeklyForecast[5].GetAsString()}\n{weeklyForecast[6].GetAsString()}\n";
        }
    }
}
