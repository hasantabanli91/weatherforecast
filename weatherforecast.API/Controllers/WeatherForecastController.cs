using Microsoft.AspNetCore.Mvc;
using weatherforecast.BLL.Interface;
using weatherforecast.Entities;

namespace weatherforecast.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherforecastService _weatherforecastService;
        public WeatherForecastController(IWeatherforecastService weatherforecastService)
        {
            _weatherforecastService = weatherforecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetAll()
        {
            return _weatherforecastService.GettAll();
        }
    }
}