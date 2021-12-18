using ForecastAnalyzer.Models;
using System;

namespace ForecastAnalyzer.Services
{
    public class ForecastService
    {
        public Forecast GetForecast() 
        {
            return new Forecast
            {
                Temperature = 21.3,
                Humidity = 52.4,
                WindDirection = 147.2,
                WindSpeed = 5.2
            };
        }
    }
}
