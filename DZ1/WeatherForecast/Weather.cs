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
            this.temperature = 20;
            this.humidity = 2;
            this.windSpeed = 5;
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

        private const double c1 = -8.78469475556;
        private const double c2 = 1.61139411;
        private const double c3 = 2.33854883889;
        private const double c4 = -0.14611605;
        private const double c5 = -0.012308094;
        private const double c6 = -0.0164248277778;
        private const double c7 = 0.002211732;
        private const double c8 = 0.00072546;
        private const double c9 = -0.000003582;

        public double CalculateFeelsLikeTemperature()
        {
            return c1 + c2 * temperature + c3 * humidity + c4 * temperature * humidity + c5 * Math.Pow(temperature, 2) + c6 * Math.Pow(humidity, 2) + c7 * Math.Pow(temperature, 2) * humidity + c8 * temperature * Math.Pow(humidity, 2) + c9 * Math.Pow(temperature, 2) * Math.Pow(humidity, 2);
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
    }
}
