using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{
    public class BiasedGenerator : IRandomGenerator
    {
        private Random generator;

        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double GenerateDouble(double min, double max)
        {
            double bias = generator.NextDouble();
            double half = (max + min) / 2;
            
            if (bias <= 2.0/3.0)
            {
                return generator.NextDouble() * (half - min) + min;
            }
            else
            {
                return generator.NextDouble() * (max - half) + half;
            }
        }
    }
}
