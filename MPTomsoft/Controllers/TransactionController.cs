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
        public async Task<IActionResult> GetTransactionsByPayment([FromQuery] TransactionQueryModel model)
        {
            return Ok(_apiService.GetTransactionsByPayments(model).Result.Result);
        }

        [HttpGet("product")]
        public async Task<IActionResult> GetTransactionsByProduct([FromQuery] TransactionQueryModel model)
        {
            return Ok(_apiService.GetTransactionsByProducts(model).Result.Result);
        }
    }
}