using CommonResources.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherObservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public WeatherController()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet()]
        public async Task<IActionResult> GetWeatherData()
        {
            string apiUrl = $"http://www.bom.gov.au/fwo/IDS60901/IDS60901.94672.json";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                return Ok(weatherData);
            }

            return BadRequest("Failed to retrieve weather data.");
        }

        [HttpGet("{wmo}")]
        public async Task<IActionResult> GetWeatherData(string wmo)
        {
            string apiUrl = $"http://www.bom.gov.au/fwo/IDS60901/IDS60901.{wmo}.json";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                return Ok(weatherData);
            }

            return BadRequest("Failed to retrieve weather data.");
        }

        [HttpGet("{wmo}/airtemp")]
        public async Task<IActionResult> GetAirTemp(string wmo)
        {
            string apiUrl = $"http://www.bom.gov.au/fwo/IDS60901/IDS60901.{wmo}.json";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                // Extract air temperature data
                var airTempData = weatherData.Observations.Data.Select(observation => new
                {
                    observation.Name,
                    observation.LocalDateTimeFull,
                    observation.AirTemp
                });

                return Ok(airTempData);
            }

            return BadRequest("Failed to retrieve air temperature data.");
        }
    }
}
