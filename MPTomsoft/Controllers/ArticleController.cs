using Microsoft.AspNetCore.Mvc;
using MPTomsoft.Models;

namespace MPTomsoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ArticleController> _logger;

        public ArticleController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] QueryModel model)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/artikli/naziv/{model.Query}";
            return Ok(QueryApi<ArticlesDto>(url).Result.Result);
        }
    }
}