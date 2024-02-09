using System;
using Newtonsoft.Json;

namespace Daily_Quoute_WebAPP
{
	public class Quote
	{
        [JsonProperty("quote")]
        public string quote { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
    }
}

