using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{
    public class WeatherGenerator
    {
        private double minTemperature;
        private double maxTemperature;
        private double minHumidity;
        private double maxHumidity;
        private double minWindSpeed;
        private double maxWindSpeed;
        private IRandomGenerator randomGenerator;

        public double MinTemperature { get { return this.minTemperature; } }
        public double MaxTemperature { get { return this.maxTemperature; } }
        public double MinHumidity { get { return this.minHumidity; } }
        public double MaxHumidity { get { return this.maxHumidity; } }
        public double MinWindSpeed { get { return this.minWindSpeed; } }
        public double MaxWindSpeed { get { return this.maxWindSpeed; } }

        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator randomGenerator)
        {
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
            this.randomGenerator = randomGenerator;
        }

        public void SetGenerator(IRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        public Weather Generate()
        {
            return new Weather(randomGenerator.GenerateDouble(MinTemperature, MaxTemperature), randomGenerator.GenerateDouble(MinHumidity, MaxHumidity), randomGenerator.GenerateDouble(MinWindSpeed, MaxWindSpeed));
        }
    }
}
