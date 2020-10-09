using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure.Model
{
    public class WeatherPayload
    {
        public List<DailyForecast> Forecasts { get; set;}
    }

}
