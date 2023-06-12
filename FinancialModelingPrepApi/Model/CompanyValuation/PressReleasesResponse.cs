using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.CompanyValuation
{
    public class PressReleasesResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
