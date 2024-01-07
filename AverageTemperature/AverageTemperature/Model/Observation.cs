using System.Text.Json.Serialization;

namespace AverageTemperature.Model
{
    public class Observation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("local_date_time_full")]
        public string LocalDateTimeFull { get; set; }

        [JsonPropertyName("air_temp")]
        public double AirTemp { get; set; }
    }
}
