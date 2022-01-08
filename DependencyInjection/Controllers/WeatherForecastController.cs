using DependencyInjection.Infraestructure;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecast _weatherForecast;
        public WeatherForecastController(IWeatherForecast weatherForecast,ILogger<WeatherForecastController> logger)
        {
            _weatherForecast = weatherForecast;
            _logger = logger;
        }

        [HttpGet("{cityCode}" , Name = "GetWeatherForecast")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<WeatherForecast> Get(int cityCode)
        {
            var currentTemperature = _weatherForecast.GetWeatherForecast(cityCode);
            if (currentTemperature is null)
                return NotFound($"the city code {cityCode} I have entered does not exist");

            return Ok(currentTemperature);
        }
    }
}