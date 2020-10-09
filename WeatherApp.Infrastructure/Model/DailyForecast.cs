namespace WeatherApp.Infrastructure.Model
{
    public class DailyForecast
    {
        public ForecastInformation Day { get; set; }
        public ForecastInformation Night { get; set; }
    }
}
