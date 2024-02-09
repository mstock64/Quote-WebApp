using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Daily_Quoute_WebAPP.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IQuoteService _quoteService;

    public IndexModel(ILogger<IndexModel> logger, IQuoteService quoteService)
    {
        _logger = logger;
        _quoteService = quoteService;
    }

    public void OnGet()
    {

    }

    public async Task<Quote> GetQuotes()
    {
        return await _quoteService.GetQuote();
    }
    public async Task<Quote> GetQuotesAsync(string category)
    {
        return await _quoteService.GetQuote(category);
    }
}

