using System;
using System.Net.Http;

namespace Daily_Quoute_WebAPP
{
	public interface IQuoteClient
	{
        public Task<HttpResponseMessage> GetQuote();
        public Task<HttpResponseMessage> GetQuote(string category);
       
    }
}

