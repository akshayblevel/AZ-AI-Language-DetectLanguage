using AZ_AI_Language_DetectLanguage.Models;

namespace AZ_AI_Language_DetectLanguage.Interfaces
{
    public interface IAnalysisService
    {
        Task<DetectResponse> DetectLanguage(string data);
    }
}
