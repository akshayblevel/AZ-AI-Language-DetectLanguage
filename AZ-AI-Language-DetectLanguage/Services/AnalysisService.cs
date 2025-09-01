using AZ_AI_Language_DetectLanguage.Interfaces;
using AZ_AI_Language_DetectLanguage.Models;
using Azure;
using Azure.AI.TextAnalytics;

namespace AZ_AI_Language_DetectLanguage.Services
{
    public class AnalysisService(TextAnalyticsClient textAnalytics) : IAnalysisService
    {
        public async Task<DetectResponse> DetectLanguage(string data)
        {
            Response<DetectedLanguage> response = await textAnalytics.DetectLanguageAsync(data);
            var d = response.Value;

            var result = new DetectResponse
            {
                DetectedLanguage = d.Name,
                Iso6391Name = d.Iso6391Name,
                ConfidenceScore = d.ConfidenceScore
            };

            return result;
        }
    }
}
