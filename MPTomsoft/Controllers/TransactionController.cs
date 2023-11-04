using Microsoft.AspNetCore.Mvc;
using MPTomsoft.Models;
using MPTomsoft.ServiceContracts;

namespace MPTomsoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;
        private readonly IApiService _apiService;

        public TransactionController(ILogger<ArticleController> logger, IApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        [HttpGet("payment")]
        public async Task<IActionResult> GetTransactionsByPayment([FromQuery] TransactionQueryModel query)
        {
            return Ok(_apiService.GetTransactionsByPayments(query).Result.Result);
        }

        [HttpGet("product")]
        public async Task<IActionResult> GetTransactionsByProduct([FromQuery] TransactionQueryModel query)
        {
            return Ok(_apiService.GetTransactionsByProducts(query).Result.Result);
        }
    }
}