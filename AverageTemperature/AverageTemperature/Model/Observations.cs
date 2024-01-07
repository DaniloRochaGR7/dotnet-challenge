using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AverageTemperature.Model
{
    public class Observations
    {
        [JsonPropertyName("notice")]
        public List<Notice> Notice { get; set; }

        [JsonPropertyName("header")]
        public List<Header> Header { get; set; }

        [JsonPropertyName("data")]
        public List<Observation> Data { get; set; }
    }
}
