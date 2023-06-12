﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.StockTimeSeries
{
    public class HistoricalStockSplitResponse
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("historical")]
        public List<HistoricalStockSplitItem> Historical { get; set; }
    }
}
