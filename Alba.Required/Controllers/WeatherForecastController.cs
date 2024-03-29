using Alba.Required.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alba.Required.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
        }

        [Produces("application/json")]
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok(new Group { RequiredModel = new RequiredModel() { Id = "test" } });
        }
    }
}
