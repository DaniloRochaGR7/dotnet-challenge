using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AverageTemperature.Services
{
    public static class JsonServices
    {
        public static async Task<string> GetJsonDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
                    return string.Empty;
                }
            }
        }
    }
}
