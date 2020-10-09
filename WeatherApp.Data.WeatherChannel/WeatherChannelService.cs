using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Api.WeatherChannel.Extensions;
using WeatherApp.Infrastructure;
using WeatherApp.Infrastructure.Model;

namespace WeatherApp.Api.WeatherChannel
{
    public class WeatherChannelService : IWeatherForcastService
    {
        private readonly HttpClient _httpClient;
        private static JsonSerializerOptions _options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        public WeatherChannelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherPayload> GetForecastAsync(string zip, ForecastInterval forecastInterval)
        {
            var uri = $"/v1/location/{zip}:4:US/forecast/daily/{(int)forecastInterval}day.json?apiKey=320c9252a6e642f38c9252a6e682f3c6";
            var json = await _httpClient.GetStringAsync(uri);
            return JsonSerializer.Deserialize<WeatherRoot>(json, _options).ToWeatherPayload();
        }
    }
}
