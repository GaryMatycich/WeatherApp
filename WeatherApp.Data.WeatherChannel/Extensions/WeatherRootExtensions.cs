using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Infrastructure.Model;

namespace WeatherApp.Api.WeatherChannel.Extensions
{
    public static class WeatherRootExtensions
    {
        public static WeatherPayload ToWeatherPayload(this WeatherRoot input)
        {
            var payload = new WeatherPayload
            {
                Forecasts = new List<DailyForecast>()
            };
            foreach (var forecast in input.Forecasts)
            {
                payload.Forecasts.Add(new DailyForecast()
                {
                    Day = new ForecastInformation()
                    {
                        Temperature = forecast.Day?.Temp ?? 0,
                        Summary = forecast.Day?.Narrative,
                        DayName = forecast.Day?.DayPartName
                    },
                    Night = new ForecastInformation()
                    {
                        Temperature = forecast.Night.Temp,
                        Summary = forecast.Night.Narrative,
                        DayName = forecast.Night.DayPartName
                    }
                });
            }
            return payload;
        }
    }
}
