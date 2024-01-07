using CommonResources.Model;
using System.Collections.Generic;
using System.Linq;

namespace AverageTemperature.Services
{
    public static class TemperatureCalculator
    {
        public static double CalculateAverageTemperature(List<Observation> observations)
        {
            return observations.Average(obs => obs.AirTemp);
        }
    }
}
