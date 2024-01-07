using System.Text.Json.Serialization;

namespace CommonResources.Model
{
    public class Observation
    {
        [JsonPropertyName("sort_order")]
        public int SortOrder { get; set; }

        [JsonPropertyName("wmo")]
        public int Wmo { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("history_product")]
        public string HistoryProduct { get; set; }

        [JsonPropertyName("local_date_time")]
        public string LocalDateTime { get; set; }

        [JsonPropertyName("local_date_time_full")]
        public string LocalDateTimeFull { get; set; }

        [JsonPropertyName("aifstime_utc")]
        public string AifstimeUtc { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("apparent_t")]
        public double ApparentT { get; set; }

        [JsonPropertyName("cloud")]
        public string Cloud { get; set; }

        [JsonPropertyName("cloud_base_m")]
        public int CloudBaseM { get; set; }

        [JsonPropertyName("cloud_oktas")]
        public int CloudOktas { get; set; }

        [JsonPropertyName("cloud_type_id")]
        public int? CloudTypeId { get; set; }

        [JsonPropertyName("cloud_type")]
        public string CloudType { get; set; }

        [JsonPropertyName("delta_t")]
        public double DeltaT { get; set; }

        [JsonPropertyName("gust_kmh")]
        public int GustKmh { get; set; }

        [JsonPropertyName("gust_kt")]
        public int GustKt { get; set; }

        [JsonPropertyName("air_temp")]
        public double AirTemp { get; set; }

        [JsonPropertyName("dewpt")]
        public double Dewpt { get; set; }

        [JsonPropertyName("press")]
        public double Press { get; set; }

        [JsonPropertyName("press_qnh")]
        public double PressQnh { get; set; }

        [JsonPropertyName("press_msl")]
        public double PressMsl { get; set; }

        [JsonPropertyName("press_tend")]
        public string PressTend { get; set; }

        [JsonPropertyName("rain_trace")]
        public string RainTrace { get; set; }

        [JsonPropertyName("rel_hum")]
        public int RelHum { get; set; }

        [JsonPropertyName("sea_state")]
        public string SeaState { get; set; }

        [JsonPropertyName("swell_dir_worded")]
        public string SwellDirWorded { get; set; }

        [JsonPropertyName("swell_height")]
        public double? SwellHeight { get; set; }

        [JsonPropertyName("swell_period")]
        public double? SwellPeriod { get; set; }

        [JsonPropertyName("vis_km")]
        public string VisKm { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }

        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; }

        [JsonPropertyName("wind_spd_kmh")]
        public int WindSpdKmh { get; set; }

        [JsonPropertyName("wind_spd_kt")]
        public int WindSpdKt { get; set; }
    }
}
