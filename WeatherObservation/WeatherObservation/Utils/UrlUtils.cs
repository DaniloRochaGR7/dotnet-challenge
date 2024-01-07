namespace WeatherObservation.Utils
{
    public static class UrlUtils
    {
        public static string GetUrl(string wmo)
        {
            return $"http://www.bom.gov.au/fwo/IDS60901/IDS60901.{wmo ?? "94672"}.json";
        }
    }
}
