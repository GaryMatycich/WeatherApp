using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Infrastructure.Model;

namespace WeatherApp.Infrastructure
{
    public interface IWeatherForcastService
    {
        Task<WeatherPayload> GetForecastAsync(string zip, ForecastInterval forecastInterval);
    }
}
