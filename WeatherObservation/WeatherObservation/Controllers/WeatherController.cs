using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherObservation.Utils;

namespace WeatherObservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("{wmo}")]
        public async Task<IActionResult> GetWeatherData(string wmo)
        {
            var client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.GetAsync(UrlUtils.GetUrl(wmo));

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return Ok(json);
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Error occurred while fetching weather data");
            }
        }

        [HttpGet("{wmo}/{dataType}")]
        public async Task<IActionResult> GetSpecificObservationData(string wmo, string dataType)
        {
            var client = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(UrlUtils.GetUrl(wmo));

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var specificData = ObservationUtils.ExtractSpecificValue(json, dataType);
                return Ok(specificData);
            }

            return BadRequest($"Failed to retrieve {dataType} data.");
        }
    }
}
