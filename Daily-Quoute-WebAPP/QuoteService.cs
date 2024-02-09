using System;
using Newtonsoft.Json;

namespace Daily_Quoute_WebAPP
{
	public class QuoteService: IQuoteService
	{
		private readonly IQuoteClient _quoteClient;

		public QuoteService(IQuoteClient quoteClient)
		{
			_quoteClient = quoteClient;

        }


		public async Task<Quote?> GetQuote()
        {
            var response = await _quoteClient.GetQuote();

            var content = await response.Content.ReadAsStringAsync();
            if (String.IsNullOrEmpty(content))
                return null;
            else
                return JsonConvert.DeserializeObject<Quote>(content);
        }

        public async Task<Quote?> GetQuote(string category)
        {
			var response = await _quoteClient.GetQuote(category);

            var content = await response.Content.ReadAsStringAsync();

            if (String.IsNullOrEmpty(content))
                return null;
            else
                return JsonConvert.DeserializeObject<Quote>(content);

        }
    }
}

