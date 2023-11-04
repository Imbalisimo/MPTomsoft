using Microsoft.AspNetCore.Mvc;
using MPTomsoft.Models;
using MPTomsoft.ServiceContracts;
using MPTomsoft.Services;

namespace MPTomsoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private readonly IApiService _apiService;

        public ArticleController(ILogger<ArticleController> logger, IApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get([FromQuery] QueryModel query)
        {
            return Ok(_apiService.GetArticles(query).Result.Result);
        }
    }
}