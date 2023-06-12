using System.Text.Json.Serialization;

namespace InvestEasy.FinancialModelingPrep.Model.Error
{
    public class ErrorResponse
    {
        [JsonPropertyName("Error Message")]
        public string ErrorMessage { get; set; }
    }
}
