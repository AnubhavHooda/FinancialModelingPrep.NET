using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalDividendsResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<HistoricalDividendItem> Historical { get; set; }
    }
}
