using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{

	public class NoSuchDailyWeatherException : Exception
	{
        private DateTime date;

        public NoSuchDailyWeatherException() { }

        public NoSuchDailyWeatherException(DateTime date)
        {
            this.date = date;
        }
        
        public NoSuchDailyWeatherException(string message, DateTime date) : base(message)
        {
            this.date = date;
        }
	}
}
