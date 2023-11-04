using Microsoft.AspNetCore.Mvc;
using MPTomsoft.Models;

namespace MPTomsoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ILogger<ArticleController> _logger;

        public TransactionController(ILogger<ArticleController> logger)
        {
            _logger = logger;
        }

        [HttpGet("payment")]
        public async Task<IActionResult> GetTransactionsByPayment([FromQuery] TransactionQueryModel model)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/placanja/{model.Uid}/{model.DateFrom}/{model.DateTo}";
            return Ok(QueryApi<TransactionPaymentDto>(url).Result.Result);
        }

        [HttpGet("product")]
        public async Task<IActionResult> GetTransactionsByProduct([FromQuery] TransactionQueryModel model)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/artikli/{model.Uid}/{model.DateFrom}/{model.DateTo}";
            return Ok(QueryApi<TransactionProductDto>(url).Result.Result);
        }
    }
}