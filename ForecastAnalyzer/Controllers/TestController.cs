using Microsoft.AspNetCore.Mvc;

namespace ForecastAnalyzer.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
