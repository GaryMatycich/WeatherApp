using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Infrastructure.Model
{
    public class Temperature
    {
        private readonly int _celsius;

        private readonly int _fahrenheit;

        public int Celsius => _celsius;

        public int Fahrenheit => _fahrenheit;

        private Temperature(int celsius, int fahrenheit)
        {
            _celsius = celsius;
            _fahrenheit = fahrenheit;
        }

        public static Temperature TemperatureFromCelsius(int input)
        {
            return new Temperature(input, (input * 9/5) + 32);
        }

        public static Temperature TemperatureFromFahrenheit(int input)
        {
            return new Temperature((input - 32) * 5/9, input);
        }
    }
}
