using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure.Model
{
    class Precipitation
    {
        public int PrecipitationChance { get; }

        public Precipitation(int precipitationChance)
        {
            PrecipitationChance = precipitationChance;
        }
    }
}
