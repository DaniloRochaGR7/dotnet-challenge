using AverageTemperature.Model;
using AverageTemperature.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AverageTemperature
{
    internal class Program
    {
        private readonly static string _weatherJsonUrl = "http://www.bom.gov.au/fwo/IDS60901/IDS60901.94672.json";
        private const int ObservationPeriodInHours = 72;
        
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This service consumes the Bureau of Meteorology weather observation " +
                                "data for the Adelaide Airport weather observation station, and " +
                                "calculates the average temperature of a given period.\r\n\r\n");

            try
            {
                var weatherData = await WeatherDataService.FetchWeatherDataAsync(_weatherJsonUrl);
                List<Observation> adelaideObservations = ObservationFilter.FilterObservations(weatherData, ObservationPeriodInHours);
                double averageTemperature = TemperatureCalculator.CalculateAverageTemperature(adelaideObservations);

                Console.WriteLine($"The average temperature for the previous {ObservationPeriodInHours} hours is {averageTemperature:F1}ºC.");
                Console.WriteLine($"For precision purposes: {averageTemperature}ºC.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("\r\n\r\nFinishing program");
            Console.ReadLine();
        }
    }
}
