using MPTomsoft.Models;
using MPTomsoft.ServiceContracts;
using System.Reflection;
using System.Text;

namespace MPTomsoft.Services
{
    public class ApiService : IApiService
    {
        private readonly string username = "luceed_mb";
        private readonly string password = "7e5y2Uza";

        public Task<ArticlesDto> GetArticles(QueryModel query)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/artikli/naziv/{query.Query}";
            return QueryApi<ArticlesDto>(url);
        }

        public Task<TransactionPaymentDto> GetTransactionsByPayments(TransactionQueryModel query)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/placanja/{query.Uid}/{query.DateFrom}/{query.DateTo}";
            return QueryApi<TransactionPaymentDto>(url);
        }

        public Task<TransactionProductDto> GetTransactionsByProducts(TransactionQueryModel query)
        {
            var url = $"http://apidemo.luceed.hr/datasnap/rest/mpobracun/artikli/{query.Uid}/{query.DateFrom}/{query.DateTo}";
            return QueryApi<TransactionProductDto>(url);
        }

        private async Task<T> QueryApi<T>(string getUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                string auth = username + ":" + password;
                auth = Convert.ToBase64String(Encoding.Default.GetBytes(auth));
                client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
                T dto = default(T);
                HttpResponseMessage response = await client.GetAsync(getUrl);
                if (response.IsSuccessStatusCode)
                {
                    dto = await response.Content.ReadFromJsonAsync<T>();
                }
                return dto;
            }
        }
    }
}
