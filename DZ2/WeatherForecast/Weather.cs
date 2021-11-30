using System;

namespace WeatherForecast
{
    public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;

        public Weather()
        {
            temperature = 20;
            humidity = 25;
            windSpeed = 5;
        }
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        public double GetTemperature()
        {
            return temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetWindSpeed()
        {
            return windSpeed;
        }
        public void SetTemperature(double value)
        {
            this.temperature = value;
        }
        public void SetHumidity(double value)
        {
            this.humidity = value;
        }
        public void SetWindSpeed(double value)
        {
            this.windSpeed = value;
        }

        public double Temperature
        {
            get { return this.temperature; }
        }
        public double Humidity
        {
            get { return this.humidity; }
        }
        public double WindSpeed
        {
            get { return this.windSpeed; }
        }

        public double CalculateFeelsLikeTemperature()
        {
            double feelsLikeTemperature = ForecastUtilities.c1 + ForecastUtilities.c2 * temperature + ForecastUtilities.c3 * humidity + ForecastUtilities.c4 * temperature * humidity + ForecastUtilities.c5 * Math.Pow(temperature, 2) + ForecastUtilities.c6 * Math.Pow(humidity, 2) + ForecastUtilities.c7 * Math.Pow(temperature, 2) * humidity + ForecastUtilities.c8 * temperature * Math.Pow(humidity, 2) + ForecastUtilities.c9 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);
            return feelsLikeTemperature;
        }

        public double CalculateWindChill()
        {
            double windChill = (13.12 + (0.6215 * temperature) - (11.37 * Math.Pow(windSpeed, 0.16)) + (0.3965 * temperature * Math.Pow(windSpeed, 0.16)));
            if (temperature <= 10 && windSpeed >= 4.8)
            {
                return windChill;
            }
            return 0;
        }

        public string GetAsString()
        {
            return $"T={Temperature}°C, w={WindSpeed} km/h, h={Humidity}%";
        }
    }
}
