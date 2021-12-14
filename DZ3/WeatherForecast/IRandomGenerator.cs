using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast
{
    public interface IRandomGenerator
    {
        double GenerateDouble(double min, double max);
    }
}
