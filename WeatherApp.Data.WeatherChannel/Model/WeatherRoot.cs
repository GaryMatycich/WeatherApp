using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure.Model
{
    public class WeatherRoot
    {
        public Metadata Metadata { get; set; }
        public Forecast[] Forecasts { get; set; }
    }

}
