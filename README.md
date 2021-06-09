# WeatherApp
Personal weather application I created in order to learn how to interact with and request data from an API

### Some notable code includes
Here I created a Weather channel service class that utilized a forcast interface. This service makes a call to the weather channels API and collects a 3 day forcast based on area code.
```
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
```
This is the interface being referenced
```
namespace WeatherApp.Infrastructure
{
    public interface IWeatherForcastService
    {
        Task<WeatherPayload> GetForecastAsync(string zip, ForecastInterval forecastInterval);
    }
}
```
