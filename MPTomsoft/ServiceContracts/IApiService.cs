using MPTomsoft.Models;

namespace MPTomsoft.ServiceContracts
{
    public interface IApiService
    {
        Task<ArticlesDto> GetArticles(QueryModel query);
        Task<TransactionPaymentDto> GetTransactionsByPayments(TransactionQueryModel query);
        Task<TransactionProductDto> GetTransactionsByProducts(TransactionQueryModel query);
    }
}
