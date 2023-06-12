using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.StockMarket
{
    public class StockMarketSymbolResponse
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }

        [JsonPropertyName("changes")]
        public double Changes { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("changesPercentage")]
        public string ChangesPercentage { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
    }
}
