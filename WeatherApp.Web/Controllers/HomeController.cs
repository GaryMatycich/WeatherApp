using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherApp.Api.WeatherChannel;
using WeatherApp.Infrastructure;
using WeatherApp.Infrastructure.Model;
using WeatherApp.Web.Models;

namespace WeatherApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherForcastService _weatherForcastService;

        public HomeController(
            ILogger<HomeController> logger,
            IWeatherForcastService weatherForcastService)
        {
            _logger = logger;
            _weatherForcastService = weatherForcastService ?? throw new ArgumentNullException(nameof(weatherForcastService));
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            var result = await _weatherForcastService.GetForecastAsync("84003", ForecastInterval.Three);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
