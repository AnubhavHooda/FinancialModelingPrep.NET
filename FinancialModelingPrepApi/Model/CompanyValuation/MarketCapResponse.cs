using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.CompanyValuation
{
    public class MarketCapResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("marketCap")]
        public double MarketCap { get; set; }
    }
}
