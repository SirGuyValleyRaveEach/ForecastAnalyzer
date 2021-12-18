using ForecastAnalyzer.Models;
using ForecastAnalyzer.Services;
using Microsoft.AspNetCore.Mvc;

namespace ForecastAnalyzer.Controllers
{
    public class ForecastController : Controller
    {
        private ForecastService _forecastService;

        public ForecastController()
        {
            _forecastService = new ForecastService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var forecast = _forecastService.GetForecast();
            return View(forecast);
        }

    }
}
