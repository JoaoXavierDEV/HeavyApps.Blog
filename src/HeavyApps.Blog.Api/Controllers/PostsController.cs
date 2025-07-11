using HeavyApps.Blog.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HeavyApps.Blog.Api.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : MainController
    {
        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }
    }
}
