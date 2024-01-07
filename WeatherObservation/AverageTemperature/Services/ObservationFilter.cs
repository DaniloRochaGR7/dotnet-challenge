using CommonResources.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageTemperature.Services
{
    public static class ObservationFilter
    {
        private const string StationName = "Adelaide Airport";
        private const string DateFormat = "yyyyMMddHHmmss";

        public static List<Observation> FilterObservations(WeatherData weatherData, int ObservationPeriodInHours)
        {
            return weatherData.Observations.Data
                .Where(obs => obs.Name == StationName && IsWithinObservationPeriod(obs, ObservationPeriodInHours))
                .ToList();
        }

        private static bool IsWithinObservationPeriod(Observation observation, int ObservationPeriodInHours)
        {
            DateTime observationTime = DateTime.ParseExact(observation.LocalDateTimeFull, DateFormat, null);
            return (DateTime.Now - observationTime).TotalHours <= ObservationPeriodInHours;
        }
    }
}
