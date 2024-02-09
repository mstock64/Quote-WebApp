using System;
namespace Daily_Quoute_WebAPP
{
	public interface IQuoteService
	{
        public Task<Quote?> GetQuote(string category);
        public Task<Quote?> GetQuote();

    }
}

