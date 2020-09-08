using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure
{
    public interface IWeatherForcastService
    {
        int GetTemperture();
        int GetPrecipitation();
        string GetForcastNarrative();

    }
}
