using System;
namespace Daily_Quoute_WebAPP
{
	public class QuoteClient: IQuoteClient
	{
		private readonly HttpClient _httpClient = new();
		public QuoteClient()
		{

			_httpClient.BaseAddress = new Uri("https://api.api-ninjas.com/");
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public async Task<HttpResponseMessage> GetQuote()
		{
            return await _httpClient.GetAsync(new Uri("/v1/quotes"));
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="category"></param>
		/// <returns></returns>
        public async Task<HttpResponseMessage> GetQuote(string category)
        {
            return await _httpClient.GetAsync(new Uri($"/v1/quotes?category={category}"));
        }
    }
}

