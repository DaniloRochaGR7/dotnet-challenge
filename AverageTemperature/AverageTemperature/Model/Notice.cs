using System.Text.Json.Serialization;

namespace AverageTemperature.Model
{
    public class Notice
    {
        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("copyright_url")]
        public string CopyrightUrl { get; set; }

        [JsonPropertyName("disclaimer_url")]
        public string DisclaimerUrl { get; set; }

        [JsonPropertyName("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
