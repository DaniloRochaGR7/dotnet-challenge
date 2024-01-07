using CommonResources.Model;
using Newtonsoft.Json;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace WeatherObservation.Utils
{
    public static class ObservationUtils
    {
        public static string ExtractSpecificValue(string json, string dataType)
        {
            var observation = JsonConvert.DeserializeObject<WeatherData>(json)?.Observations?.Data?.FirstOrDefault();

            if (observation != null)
            {
                // Try to find the property by the JSON property name
                foreach (var prop in observation.GetType().GetProperties())
                {
                    var jsonProperty = prop.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false).FirstOrDefault() as JsonPropertyNameAttribute;
                    if (jsonProperty != null && jsonProperty.Name == dataType)
                    {
                        var value = prop.GetValue(observation);
                        return JsonConvert.SerializeObject(new { Name = dataType, Value = value });
                    }
                }

                // If the property was not found by the JSON property name, try to find it by the class property name
                var property = observation.GetType().GetProperty(dataType, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (property != null)
                {
                    var value = property.GetValue(observation);
                    return JsonConvert.SerializeObject(new { Name = dataType, Value = value });
                }
            }

            return "{}"; // Default to an empty object if observation is not available or property is not found
        }
    }
}
