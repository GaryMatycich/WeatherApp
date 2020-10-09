namespace WeatherApp.Infrastructure.Model
{
    public class Metadata
    {
        public string language { get; set; }
        public string transaction_id { get; set; }
        public string version { get; set; }
        public string location_id { get; set; }
        public string units { get; set; }
        public int expire_time_gmt { get; set; }
        public int status_code { get; set; }
    }

}
