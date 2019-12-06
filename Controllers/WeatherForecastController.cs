using Microsoft.AspNetCore.Mvc;

namespace JOS.DictionaryModelBindingBug.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody]MyInput input)
        {
            return Ok();
        }
    }
}
