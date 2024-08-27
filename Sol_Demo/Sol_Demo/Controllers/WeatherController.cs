using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.DTO;
using Sol_Demo.Services;

namespace Sol_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService = null;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeatherAsync(String city, CancellationToken cancellationToken)
        {
            var result = await _weatherService.GetCurrentWeatherAsync(city, cancellationToken);

            return base.StatusCode(Convert.ToInt32(result.StatusCode), result);
        }
    }
}