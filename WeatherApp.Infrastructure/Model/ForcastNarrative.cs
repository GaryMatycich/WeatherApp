using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure.Model
{
    class ForcastNarrative
    {
        public string ForcastSum { get; }

        public ForcastNarrative(string Summary)
        {
            ForcastSum = Summary; 
        }
    }
}
