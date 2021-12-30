using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WeatherForecast
{
	public class DailyForecastRepository : IEnumerable<DailyForecast>
	{
		private List<DailyForecast> dailyForecasts;

		public DailyForecastRepository()
		{
			this.dailyForecasts = new List<DailyForecast>();
		}

		public DailyForecastRepository(DailyForecastRepository dailyForecastRepository)
		{
			this.dailyForecasts = new List<DailyForecast>();
            foreach (DailyForecast day in dailyForecastRepository)
            {
				dailyForecasts.Add(day);
            }
		}

		public void Add(DailyForecast forecast)
		{
			if (this.dailyForecasts.Count == 0)
			{
				dailyForecasts.Add(forecast);
				return;
			}
			for (int i = 0; i < this.dailyForecasts.Count; i++)
			{
				if (forecast.Date.ToShortDateString() == this.dailyForecasts[i].Date.ToShortDateString())
				{
					this.dailyForecasts.RemoveAt(i);
					this.dailyForecasts.Insert(i, forecast);
					return;
				}
                if (i == 0 && this.dailyForecasts[i].Date > forecast.Date)
                {
                    this.dailyForecasts.Insert(i, forecast);
                    return;
                }
				if (i + 1 < this.dailyForecasts.Count)
				{
					if (this.dailyForecasts[i].Date < forecast.Date && this.dailyForecasts[i].Date > forecast.Date)
					{
						this.dailyForecasts.Insert(i, forecast);
						return;
					}
				}
			}
			dailyForecasts.Add(forecast);
		}

		public void Add(List<DailyForecast> forecasts)
		{
			foreach (DailyForecast day in forecasts)
			{
				Add(day);
			}
		}

        public void Remove(DateTime date)
		{
            for (int i = 0; i < dailyForecasts.Count; i++)
            {
				if (date.ToShortDateString() == dailyForecasts[i].Date.ToShortDateString())
                {
					dailyForecasts.RemoveAt(i);
					return;
                }
            }
			throw new NoSuchDailyWeatherException($"No daily forecast for {date.Date}", date);
		}

        public IEnumerator<DailyForecast> GetEnumerator()
        {
			return dailyForecasts.GetEnumerator();
		}

        IEnumerator IEnumerable.GetEnumerator()
        {
			return this.GetEnumerator();
		}

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			foreach (DailyForecast day in dailyForecasts)
			{
				builder.Append(day + "\n");
			}
			return builder.ToString();
		}

    }
}
