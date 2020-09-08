using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure
{
    interface IWeatherForcastService
    {
        int GetTemperture();
        string GetPrecipitation();
        int GetForcastNarrative();

    }
}
