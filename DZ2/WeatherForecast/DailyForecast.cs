using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{
    public class DailyForecast
    {
        private DateTime date;
        private Weather forecast;

        public DateTime Date
        {
            get { return this.date; }
        }
        public Weather Forecast
        {
            get { return this.forecast; }
        }
        public double Temperature
        {
            get { return this.forecast.Temperature; }
        }
        public double Humidity
        {
            get { return this.forecast.Humidity; }
        }
        public double WindSpeed
        {
            get { return this.forecast.WindSpeed; }
        }

        public DailyForecast(DailyForecast dailyForecast)
        {
            this.date = dailyForecast.Date;
            this.forecast = dailyForecast.Forecast;
        }
        public DailyForecast(DateTime date, Weather forecast)
        {
            this.date = date;
            this.forecast = forecast;
        }

        public static bool operator >(DailyForecast left, DailyForecast right)
        {
            if (left.Temperature > right.Temperature)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(DailyForecast left, DailyForecast right)
        {
            if (left.Temperature > right.Temperature)
            {
                return false;
            }
            return true;
        }

        public string GetAsString()
        {
            return $"{date}: {forecast.GetAsString()}";
        }
    }
}
