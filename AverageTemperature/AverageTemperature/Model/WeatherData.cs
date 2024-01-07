using System.Text.Json.Serialization;

namespace AverageTemperature.Model
{
    public class WeatherData
    {
        [JsonPropertyName("observations")]
        public Observations Observations { get; set; }
    }
}
