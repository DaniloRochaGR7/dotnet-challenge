using System.Text.Json.Serialization;

namespace AverageTemperature.Model
{
    public class Header
    {
        [JsonPropertyName("refresh_message")]
        public string RefreshMessage { get; set; }

        [JsonPropertyName("ID")]
        public string Id { get; set; }

        [JsonPropertyName("main_ID")]
        public string MainId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state_time_zone")]
        public string StateTimeZone { get; set; }

        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
