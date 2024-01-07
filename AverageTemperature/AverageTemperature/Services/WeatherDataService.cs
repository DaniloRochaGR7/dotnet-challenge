using AverageTemperature.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace AverageTemperature.Services
{
    public static class WeatherDataService
    {
        public static async Task<WeatherData> FetchWeatherDataAsync(string url)
        {
            string jsonData = await JsonServices.GetJsonDataAsync(url);
            return JsonSerializer.Deserialize<WeatherData>(jsonData);
        }
    }
}
