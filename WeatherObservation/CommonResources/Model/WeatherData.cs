using System.Text.Json.Serialization;

namespace CommonResources.Model
{
    public class WeatherData
    {
        [JsonPropertyName("observations")]
        public Observations Observations { get; set; }
    }
}
